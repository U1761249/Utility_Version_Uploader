using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Util_Version_Uploader
{
    public partial class Form1 : Form
    {

        string workingDir = null;
        string utilDir = null;
        string project = null;

        Cursor oldCursor;

        DataTable projects = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "Directories.txt");
            if (File.Exists(path))
            {
                UpdateTable(path);
            }
            else MessageBox.Show("Unable to locate the Directories.txt file.");

        }
        private void BtnAlter_Click(object sender, EventArgs e)
        {
            AlterDirectories();
        }

        private void AlterDirectories()
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.Description = "Select your Project Source directory.";
            folderBrowserDialog1.SelectedPath = tbWorking.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbWorking.Text = folderBrowserDialog1.SelectedPath;
            }

            folderBrowserDialog1.Description = "Select your Export Destination directory.";
            folderBrowserDialog1.SelectedPath = tbUtil.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbUtil.Text = folderBrowserDialog1.SelectedPath;
            }

            UpdateFile();
        }

        private void UpdateFile()
        {
            string path = Path.Combine(Application.StartupPath, "Directories.txt");
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.Create(path).Dispose();

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(tbWorking.Text);
                sw.WriteLine(tbUtil.Text);
            }
            UpdateTable(path);
        }

        private void UpdateTable(string path)
        {
            StreamReader file = new StreamReader(path);
            try
            {
                workingDir = file.ReadLine();
                tbWorking.Text = workingDir;
                utilDir = file.ReadLine();
                tbUtil.Text = utilDir;
                file.Close();
            }
            catch (Exception) { }

            if (workingDir != null && utilDir != null)
            {
                projects = new DataTable();
                try
                {
                    projects.Columns.Add("Projects");
                    projects.Columns.Add("Creation", typeof(DateTime));
                    string[] directories = Directory.GetDirectories(workingDir);
                    foreach (string dir in directories)
                    {
                        string tempProject = Path.GetFileNameWithoutExtension(dir + ".txt"); // Add txt to the end to get the last directory.
                        string[] executablePath = Directory.GetFiles(dir, tempProject + ".exe", SearchOption.AllDirectories);

                        if (executablePath.Length > 0)
                        {
                            projects.Rows.Add
                            (
                                Path.GetFileNameWithoutExtension(dir),
                                Directory.GetLastWriteTime(dir)
                            );
                        }

                    }
                }
                catch (DirectoryNotFoundException)
                {
                    AlterDirectories();
                }
                gvProjects.DataSource = projects;
                gvProjects.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gvProjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvProjects.MultiSelect = false;
                gvProjects.RowHeadersVisible = false;
                gvProjects.AllowUserToAddRows = false;
                gvProjects.AllowUserToResizeColumns = false;
                gvProjects.AllowUserToResizeRows = false;
                gvProjects.ReadOnly = true;


            }
            else MessageBox.Show("One of the directories was not specified. \nCheck the contents of the Directories.txt");
        }

        private void GvProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                project = gvProjects.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (project != null)
            {
                oldCursor = this.Cursor;
                this.Cursor = Cursors.WaitCursor;
                greyThings(true);
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void greyThings(bool stat)
        {
            splitContainer1.Enabled = !stat;
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime newestAssemblyDate = new DateTime(1970, 01, 01);
            string newestAssembly = "";
            string[] executablePath = Directory.GetFiles(Path.Combine(workingDir, project), project + ".exe", SearchOption.AllDirectories);
            foreach (string tempPath in executablePath)
            {
                FileInfo fi = new FileInfo(tempPath);
                if (fi.LastWriteTime > newestAssemblyDate)
                {
                    newestAssemblyDate = fi.LastWriteTime;
                    newestAssembly = tempPath;
                }

            }
            if (newestAssembly != "")
            {
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(newestAssembly);
                string fileVersion = $"v{fvi.FileVersion}";
                string importDir = Path.Combine(utilDir, project, fileVersion);

                if (Directory.Exists(importDir))
                {
                    DialogResult result = MessageBox.Show($"{fileVersion} already exists. \nWould you like to overwrite?", "Replace?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        Directory.Delete(importDir, true);


                        Directory.CreateDirectory(importDir);
                        Upload(newestAssembly, importDir);
                        Application.Exit();
                    }
                }
                else
                {
                    Directory.CreateDirectory(importDir);
                    Upload(newestAssembly, importDir);
                    Revisions(importDir, fileVersion);
                    Application.Exit();
                }
            }
        }

        public void Upload(string exePath, string utilDir)
        {

            string dir = Path.GetDirectoryName(exePath);
            var files = Directory.GetFiles(dir);
            foreach (string file in files)
            {
                if (Path.GetFileName(file) != project + ".exe.config" && Path.GetFileName(file) != project + ".pdb")
                {

                    File.Copy(file, Path.Combine(utilDir, Path.GetFileName(file)));

                }
            }

            dir = Directory.GetParent(dir).ToString();
            dir = Directory.GetParent(dir).ToString();
            dir = Directory.GetParent(dir).ToString();

            try
            {
                ZipFile.CreateFromDirectory(dir, Path.Combine(utilDir, "Source.zip"));
            }
            catch (IOException ioe) { MessageBox.Show(ioe.Message); }
        }

        public void Revisions(string utilDir, string version)
        {
            utilDir = Directory.GetParent(utilDir).ToString();
            string revisionFile = Path.Combine(utilDir, "Revisions.txt");

            try
            {

                string entry = $"{version} - {DateTime.Now.ToString("dd/MM/yy")}";


                string currentContent = String.Empty;

                if (File.Exists(revisionFile))
                {
                    currentContent = File.ReadAllText(revisionFile);
                }
                File.WriteAllText(revisionFile, entry + "\r\n" + "=================" + "\r\n\r\n\r\n" + currentContent);


            }
            catch (Exception) { }

            Process.Start("Notepad.exe", revisionFile);
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = oldCursor;
            greyThings(false);
        }
    }
}

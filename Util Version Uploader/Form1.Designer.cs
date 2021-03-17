namespace Util_Version_Uploader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbLocal = new System.Windows.Forms.Label();
            this.lbUtil = new System.Windows.Forms.Label();
            this.tbWorking = new System.Windows.Forms.TextBox();
            this.tbUtil = new System.Windows.Forms.TextBox();
            this.btnAlter = new System.Windows.Forms.Button();
            this.gvProjects = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBegin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProjects)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(334, 363);
            this.splitContainer1.SplitterDistance = 324;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gvProjects);
            this.splitContainer2.Size = new System.Drawing.Size(334, 324);
            this.splitContainer2.SplitterDistance = 76;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.11013F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.88987F));
            this.tableLayoutPanel1.Controls.Add(this.lbLocal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbUtil, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbWorking, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbUtil, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAlter, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.98551F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.13044F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 69);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbLocal
            // 
            this.lbLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLocal.AutoSize = true;
            this.lbLocal.Location = new System.Drawing.Point(3, 4);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(76, 13);
            this.lbLocal.TabIndex = 0;
            this.lbLocal.Text = "Source:";
            // 
            // lbUtil
            // 
            this.lbUtil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUtil.AutoSize = true;
            this.lbUtil.Location = new System.Drawing.Point(3, 25);
            this.lbUtil.Name = "lbUtil";
            this.lbUtil.Size = new System.Drawing.Size(76, 13);
            this.lbUtil.TabIndex = 1;
            this.lbUtil.Text = "Destination:";
            // 
            // tbWorking
            // 
            this.tbWorking.Enabled = false;
            this.tbWorking.Location = new System.Drawing.Point(85, 3);
            this.tbWorking.Name = "tbWorking";
            this.tbWorking.ReadOnly = true;
            this.tbWorking.Size = new System.Drawing.Size(233, 20);
            this.tbWorking.TabIndex = 2;
            // 
            // tbUtil
            // 
            this.tbUtil.Enabled = false;
            this.tbUtil.Location = new System.Drawing.Point(85, 25);
            this.tbUtil.Name = "tbUtil";
            this.tbUtil.ReadOnly = true;
            this.tbUtil.Size = new System.Drawing.Size(233, 20);
            this.tbUtil.TabIndex = 3;
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(3, 44);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(50, 21);
            this.btnAlter.TabIndex = 4;
            this.btnAlter.Text = "Alter";
            this.btnAlter.UseVisualStyleBackColor = false;
            this.btnAlter.Click += new System.EventHandler(this.BtnAlter_Click);
            // 
            // gvProjects
            // 
            this.gvProjects.AllowUserToAddRows = false;
            this.gvProjects.AllowUserToDeleteRows = false;
            this.gvProjects.AllowUserToResizeColumns = false;
            this.gvProjects.AllowUserToResizeRows = false;
            this.gvProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gvProjects.EnableHeadersVisualStyles = false;
            this.gvProjects.Location = new System.Drawing.Point(4, 4);
            this.gvProjects.MultiSelect = false;
            this.gvProjects.Name = "gvProjects";
            this.gvProjects.ReadOnly = true;
            this.gvProjects.RowHeadersVisible = false;
            this.gvProjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProjects.ShowEditingIcon = false;
            this.gvProjects.Size = new System.Drawing.Size(327, 239);
            this.gvProjects.TabIndex = 0;
            this.gvProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvProjects_CellClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnBegin);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(318, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(197, 3);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(118, 23);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "Export Version";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 363);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 100000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 402);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Publisher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProjects)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbLocal;
        private System.Windows.Forms.Label lbUtil;
        private System.Windows.Forms.TextBox tbWorking;
        private System.Windows.Forms.TextBox tbUtil;
        private System.Windows.Forms.DataGridView gvProjects;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBegin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAlter;
    }
}


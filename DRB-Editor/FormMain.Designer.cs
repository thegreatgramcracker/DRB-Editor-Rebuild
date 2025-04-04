namespace DRB_Editor
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pgdDlg = new System.Windows.Forms.PropertyGrid();
            this.lbxDlgs = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pgdDlgoShape = new System.Windows.Forms.PropertyGrid();
            this.lbxDlgos = new System.Windows.Forms.ListBox();
            this.pgdDlgShape = new System.Windows.Forms.PropertyGrid();
            this.pgdDlgo = new System.Windows.Forms.PropertyGrid();
            this.lblDlgShape = new System.Windows.Forms.Label();
            this.lblDlgoShape = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLblPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.ofdDrb = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgdDlg
            // 
            this.pgdDlg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgdDlg.Enabled = false;
            this.pgdDlg.HelpVisible = false;
            this.pgdDlg.Location = new System.Drawing.Point(223, 3);
            this.pgdDlg.Name = "pgdDlg";
            this.pgdDlg.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgdDlg.Size = new System.Drawing.Size(225, 231);
            this.pgdDlg.TabIndex = 1;
            this.pgdDlg.ToolbarVisible = false;
            this.pgdDlg.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.Pgd_PropertyValueChanged);
            // 
            // lbxDlgs
            // 
            this.lbxDlgs.DisplayMember = "Name";
            this.lbxDlgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxDlgs.Enabled = false;
            this.lbxDlgs.FormattingEnabled = true;
            this.lbxDlgs.IntegralHeight = false;
            this.lbxDlgs.Location = new System.Drawing.Point(3, 3);
            this.lbxDlgs.Name = "lbxDlgs";
            this.tableLayoutPanel1.SetRowSpan(this.lbxDlgs, 3);
            this.lbxDlgs.ScrollAlwaysVisible = true;
            this.lbxDlgs.Size = new System.Drawing.Size(214, 481);
            this.lbxDlgs.Sorted = true;
            this.lbxDlgs.TabIndex = 0;
            this.lbxDlgs.SelectedValueChanged += new System.EventHandler(this.LbxDlgs_SelectedValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pgdDlgoShape, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbxDlgos, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pgdDlgShape, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbxDlgs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pgdDlgo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pgdDlg, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDlgShape, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDlgoShape, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 487);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pgdDlgoShape
            // 
            this.pgdDlgoShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgdDlgoShape.Enabled = false;
            this.pgdDlgoShape.HelpVisible = false;
            this.pgdDlgoShape.Location = new System.Drawing.Point(674, 253);
            this.pgdDlgoShape.Name = "pgdDlgoShape";
            this.pgdDlgoShape.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgdDlgoShape.Size = new System.Drawing.Size(225, 231);
            this.pgdDlgoShape.TabIndex = 5;
            this.pgdDlgoShape.ToolbarVisible = false;
            this.pgdDlgoShape.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.Pgd_PropertyValueChanged);
            // 
            // lbxDlgos
            // 
            this.lbxDlgos.DisplayMember = "Name";
            this.lbxDlgos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxDlgos.Enabled = false;
            this.lbxDlgos.FormattingEnabled = true;
            this.lbxDlgos.IntegralHeight = false;
            this.lbxDlgos.Location = new System.Drawing.Point(454, 3);
            this.lbxDlgos.Name = "lbxDlgos";
            this.tableLayoutPanel1.SetRowSpan(this.lbxDlgos, 3);
            this.lbxDlgos.ScrollAlwaysVisible = true;
            this.lbxDlgos.Size = new System.Drawing.Size(214, 481);
            this.lbxDlgos.TabIndex = 3;
            this.lbxDlgos.SelectedValueChanged += new System.EventHandler(this.LbxDlgos_SelectedValueChanged);
            // 
            // pgdDlgShape
            // 
            this.pgdDlgShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgdDlgShape.Enabled = false;
            this.pgdDlgShape.HelpVisible = false;
            this.pgdDlgShape.Location = new System.Drawing.Point(223, 253);
            this.pgdDlgShape.Name = "pgdDlgShape";
            this.pgdDlgShape.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgdDlgShape.Size = new System.Drawing.Size(225, 231);
            this.pgdDlgShape.TabIndex = 2;
            this.pgdDlgShape.ToolbarVisible = false;
            this.pgdDlgShape.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.Pgd_PropertyValueChanged);
            // 
            // pgdDlgo
            // 
            this.pgdDlgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgdDlgo.Enabled = false;
            this.pgdDlgo.HelpVisible = false;
            this.pgdDlgo.Location = new System.Drawing.Point(674, 3);
            this.pgdDlgo.Name = "pgdDlgo";
            this.pgdDlgo.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgdDlgo.Size = new System.Drawing.Size(225, 231);
            this.pgdDlgo.TabIndex = 4;
            this.pgdDlgo.ToolbarVisible = false;
            this.pgdDlgo.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.Pgd_PropertyValueChanged);
            // 
            // lblDlgShape
            // 
            this.lblDlgShape.AutoSize = true;
            this.lblDlgShape.Location = new System.Drawing.Point(222, 237);
            this.lblDlgShape.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDlgShape.Name = "lblDlgShape";
            this.lblDlgShape.Size = new System.Drawing.Size(0, 13);
            this.lblDlgShape.TabIndex = 6;
            // 
            // lblDlgoShape
            // 
            this.lblDlgoShape.AutoSize = true;
            this.lblDlgoShape.Location = new System.Drawing.Point(673, 237);
            this.lblDlgoShape.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDlgoShape.Name = "lblDlgoShape";
            this.lblDlgoShape.Size = new System.Drawing.Size(0, 13);
            this.lblDlgoShape.TabIndex = 7;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(902, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.RestoreToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.texturesToolStripMenuItem,
            this.previewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // texturesToolStripMenuItem
            // 
            this.texturesToolStripMenuItem.CheckOnClick = true;
            this.texturesToolStripMenuItem.Enabled = false;
            this.texturesToolStripMenuItem.Name = "texturesToolStripMenuItem";
            this.texturesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.texturesToolStripMenuItem.Text = "Textures";
            this.texturesToolStripMenuItem.Click += new System.EventHandler(this.TexturesToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.CheckOnClick = true;
            this.previewToolStripMenuItem.Enabled = false;
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.CheckedChanged += new System.EventHandler(this.PreviewToolStripMenuItem_CheckedChanged);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transformToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // transformToolStripMenuItem
            // 
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transformToolStripMenuItem.Text = "Transform...";
            this.transformToolStripMenuItem.Click += new System.EventHandler(this.TransformToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLblPath});
            this.statusStrip.Location = new System.Drawing.Point(0, 511);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(902, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripLblPath
            // 
            this.statusStripLblPath.Name = "statusStripLblPath";
            this.statusStripLblPath.Size = new System.Drawing.Size(85, 17);
            this.statusStripLblPath.Text = "No file opened";
            // 
            // ofdDrb
            // 
            this.ofdDrb.FileName = "menu.drb";
            this.ofdDrb.Filter = "DRB files|*.drb*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 533);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(918, 570);
            this.Name = "FormMain";
            this.Text = "DRB Editor <version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid pgdDlg;
        private System.Windows.Forms.ListBox lbxDlgs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PropertyGrid pgdDlgoShape;
        private System.Windows.Forms.PropertyGrid pgdDlgShape;
        private System.Windows.Forms.PropertyGrid pgdDlgo;
        private System.Windows.Forms.ListBox lbxDlgos;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.OpenFileDialog ofdDrb;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLblPath;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem texturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.Label lblDlgShape;
        private System.Windows.Forms.Label lblDlgoShape;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformToolStripMenuItem;
    }
}


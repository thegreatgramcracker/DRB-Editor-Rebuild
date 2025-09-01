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
            this.label3 = new System.Windows.Forms.Label();
            this.pgdDlgoShape = new System.Windows.Forms.PropertyGrid();
            this.lbxDlgos = new System.Windows.Forms.ListBox();
            this.pgdDlgShape = new System.Windows.Forms.PropertyGrid();
            this.pgdDlgo = new System.Windows.Forms.PropertyGrid();
            this.lblDlgShape = new System.Windows.Forms.Label();
            this.lblDlgoShape = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dlgoReorderGroupbox = new System.Windows.Forms.GroupBox();
            this.dlgoDownButton = new System.Windows.Forms.Button();
            this.dlgoUpButton = new System.Windows.Forms.Button();
            this.dlgoEditGroupbox = new System.Windows.Forms.GroupBox();
            this.dlgoCopyButton = new System.Windows.Forms.Button();
            this.dlgoDeleteButton = new System.Windows.Forms.Button();
            this.dlgoDuplicateButton = new System.Windows.Forms.Button();
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
            this.dlgoPasteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dlgoCopyLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.dlgoReorderGroupbox.SuspendLayout();
            this.dlgoEditGroupbox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgdDlg
            // 
            this.pgdDlg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgdDlg.Enabled = false;
            this.pgdDlg.HelpVisible = false;
            this.pgdDlg.Location = new System.Drawing.Point(253, 3);
            this.pgdDlg.Name = "pgdDlg";
            this.pgdDlg.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgdDlg.Size = new System.Drawing.Size(244, 258);
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
            this.lbxDlgs.Size = new System.Drawing.Size(244, 535);
            this.lbxDlgs.Sorted = true;
            this.lbxDlgs.TabIndex = 0;
            this.lbxDlgs.SelectedValueChanged += new System.EventHandler(this.LbxDlgs_SelectedValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pgdDlgoShape, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbxDlgos, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pgdDlgShape, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbxDlgs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pgdDlgo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pgdDlg, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDlgShape, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDlgoShape, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dlgoReorderGroupbox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dlgoEditGroupbox, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1097, 559);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DLG";
            // 
            // pgdDlgoShape
            // 
            this.pgdDlgoShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgdDlgoShape.Enabled = false;
            this.pgdDlgoShape.HelpVisible = false;
            this.pgdDlgoShape.Location = new System.Drawing.Point(849, 280);
            this.pgdDlgoShape.Name = "pgdDlgoShape";
            this.pgdDlgoShape.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgdDlgoShape.Size = new System.Drawing.Size(245, 258);
            this.pgdDlgoShape.TabIndex = 5;
            this.pgdDlgoShape.ToolbarVisible = false;
            this.pgdDlgoShape.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.Pgd_PropertyValueChanged);
            // 
            // lbxDlgos
            // 
            this.lbxDlgos.DisplayMember = "Name";
            this.lbxDlgos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxDlgos.FormattingEnabled = true;
            this.lbxDlgos.IntegralHeight = false;
            this.lbxDlgos.Location = new System.Drawing.Point(599, 3);
            this.lbxDlgos.Name = "lbxDlgos";
            this.tableLayoutPanel1.SetRowSpan(this.lbxDlgos, 3);
            this.lbxDlgos.ScrollAlwaysVisible = true;
            this.lbxDlgos.Size = new System.Drawing.Size(244, 535);
            this.lbxDlgos.TabIndex = 3;
            this.lbxDlgos.SelectedValueChanged += new System.EventHandler(this.LbxDlgos_SelectedValueChanged);
            // 
            // pgdDlgShape
            // 
            this.pgdDlgShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgdDlgShape.Enabled = false;
            this.pgdDlgShape.HelpVisible = false;
            this.pgdDlgShape.Location = new System.Drawing.Point(253, 280);
            this.pgdDlgShape.Name = "pgdDlgShape";
            this.pgdDlgShape.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgdDlgShape.Size = new System.Drawing.Size(244, 258);
            this.pgdDlgShape.TabIndex = 2;
            this.pgdDlgShape.ToolbarVisible = false;
            this.pgdDlgShape.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.Pgd_PropertyValueChanged);
            // 
            // pgdDlgo
            // 
            this.pgdDlgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgdDlgo.Enabled = false;
            this.pgdDlgo.HelpVisible = false;
            this.pgdDlgo.Location = new System.Drawing.Point(849, 3);
            this.pgdDlgo.Name = "pgdDlgo";
            this.pgdDlgo.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgdDlgo.Size = new System.Drawing.Size(245, 258);
            this.pgdDlgo.TabIndex = 4;
            this.pgdDlgo.ToolbarVisible = false;
            this.pgdDlgo.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.Pgd_PropertyValueChanged);
            // 
            // lblDlgShape
            // 
            this.lblDlgShape.AutoSize = true;
            this.lblDlgShape.Location = new System.Drawing.Point(252, 264);
            this.lblDlgShape.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDlgShape.Name = "lblDlgShape";
            this.lblDlgShape.Size = new System.Drawing.Size(0, 13);
            this.lblDlgShape.TabIndex = 6;
            // 
            // lblDlgoShape
            // 
            this.lblDlgoShape.AutoSize = true;
            this.lblDlgoShape.Location = new System.Drawing.Point(848, 264);
            this.lblDlgoShape.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDlgoShape.Name = "lblDlgoShape";
            this.lblDlgoShape.Size = new System.Drawing.Size(0, 13);
            this.lblDlgoShape.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "DLGO";
            // 
            // dlgoReorderGroupbox
            // 
            this.dlgoReorderGroupbox.Controls.Add(this.dlgoDownButton);
            this.dlgoReorderGroupbox.Controls.Add(this.dlgoUpButton);
            this.dlgoReorderGroupbox.Enabled = false;
            this.dlgoReorderGroupbox.Location = new System.Drawing.Point(503, 3);
            this.dlgoReorderGroupbox.Name = "dlgoReorderGroupbox";
            this.dlgoReorderGroupbox.Size = new System.Drawing.Size(90, 258);
            this.dlgoReorderGroupbox.TabIndex = 11;
            this.dlgoReorderGroupbox.TabStop = false;
            this.dlgoReorderGroupbox.Text = "Reorder Dlgo";
            // 
            // dlgoDownButton
            // 
            this.dlgoDownButton.Location = new System.Drawing.Point(6, 48);
            this.dlgoDownButton.Name = "dlgoDownButton";
            this.dlgoDownButton.Size = new System.Drawing.Size(75, 23);
            this.dlgoDownButton.TabIndex = 1;
            this.dlgoDownButton.Text = "Move Down";
            this.dlgoDownButton.UseVisualStyleBackColor = true;
            this.dlgoDownButton.Click += new System.EventHandler(this.dlgoDownButton_Click);
            // 
            // dlgoUpButton
            // 
            this.dlgoUpButton.Location = new System.Drawing.Point(6, 19);
            this.dlgoUpButton.Name = "dlgoUpButton";
            this.dlgoUpButton.Size = new System.Drawing.Size(75, 23);
            this.dlgoUpButton.TabIndex = 0;
            this.dlgoUpButton.Text = "Move Up";
            this.dlgoUpButton.UseVisualStyleBackColor = true;
            this.dlgoUpButton.Click += new System.EventHandler(this.dlgoUpButton_Click);
            // 
            // dlgoEditGroupbox
            // 
            this.dlgoEditGroupbox.Controls.Add(this.dlgoCopyLabel);
            this.dlgoEditGroupbox.Controls.Add(this.label2);
            this.dlgoEditGroupbox.Controls.Add(this.dlgoPasteButton);
            this.dlgoEditGroupbox.Controls.Add(this.dlgoCopyButton);
            this.dlgoEditGroupbox.Controls.Add(this.dlgoDeleteButton);
            this.dlgoEditGroupbox.Controls.Add(this.dlgoDuplicateButton);
            this.dlgoEditGroupbox.Enabled = false;
            this.dlgoEditGroupbox.Location = new System.Drawing.Point(503, 280);
            this.dlgoEditGroupbox.Name = "dlgoEditGroupbox";
            this.dlgoEditGroupbox.Size = new System.Drawing.Size(90, 258);
            this.dlgoEditGroupbox.TabIndex = 12;
            this.dlgoEditGroupbox.TabStop = false;
            this.dlgoEditGroupbox.Text = "Edit Dlgo";
            // 
            // dlgoCopyButton
            // 
            this.dlgoCopyButton.Location = new System.Drawing.Point(7, 78);
            this.dlgoCopyButton.Name = "dlgoCopyButton";
            this.dlgoCopyButton.Size = new System.Drawing.Size(75, 23);
            this.dlgoCopyButton.TabIndex = 2;
            this.dlgoCopyButton.Text = "Copy";
            this.dlgoCopyButton.UseVisualStyleBackColor = true;
            this.dlgoCopyButton.Click += new System.EventHandler(this.dlgoCopyButton_Click);
            // 
            // dlgoDeleteButton
            // 
            this.dlgoDeleteButton.Location = new System.Drawing.Point(6, 48);
            this.dlgoDeleteButton.Name = "dlgoDeleteButton";
            this.dlgoDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.dlgoDeleteButton.TabIndex = 1;
            this.dlgoDeleteButton.Text = "Delete";
            this.dlgoDeleteButton.UseVisualStyleBackColor = true;
            this.dlgoDeleteButton.Click += new System.EventHandler(this.dlgoDeleteButton_Click);
            // 
            // dlgoDuplicateButton
            // 
            this.dlgoDuplicateButton.Location = new System.Drawing.Point(6, 19);
            this.dlgoDuplicateButton.Name = "dlgoDuplicateButton";
            this.dlgoDuplicateButton.Size = new System.Drawing.Size(75, 23);
            this.dlgoDuplicateButton.TabIndex = 0;
            this.dlgoDuplicateButton.Text = "Duplicate";
            this.dlgoDuplicateButton.UseVisualStyleBackColor = true;
            this.dlgoDuplicateButton.Click += new System.EventHandler(this.dlgoDuplicateButton_Click);
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
            this.menuStrip.Size = new System.Drawing.Size(1097, 24);
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
            this.texturesToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.texturesToolStripMenuItem.Text = "Textures";
            this.texturesToolStripMenuItem.Click += new System.EventHandler(this.TexturesToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.CheckOnClick = true;
            this.previewToolStripMenuItem.Enabled = false;
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
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
            this.transformToolStripMenuItem.CheckOnClick = true;
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.transformToolStripMenuItem.Text = "Transform...";
            this.transformToolStripMenuItem.CheckedChanged += new System.EventHandler(this.transformToolStripMenuItem_CheckedChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLblPath});
            this.statusStrip.Location = new System.Drawing.Point(0, 583);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1097, 22);
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
            // dlgoPasteButton
            // 
            this.dlgoPasteButton.Location = new System.Drawing.Point(7, 108);
            this.dlgoPasteButton.Name = "dlgoPasteButton";
            this.dlgoPasteButton.Size = new System.Drawing.Size(75, 23);
            this.dlgoPasteButton.TabIndex = 3;
            this.dlgoPasteButton.Text = "Paste";
            this.dlgoPasteButton.UseVisualStyleBackColor = true;
            this.dlgoPasteButton.Click += new System.EventHandler(this.dlgoPasteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Copy Name:";
            // 
            // dlgoCopyLabel
            // 
            this.dlgoCopyLabel.AutoSize = true;
            this.dlgoCopyLabel.Location = new System.Drawing.Point(6, 164);
            this.dlgoCopyLabel.Name = "dlgoCopyLabel";
            this.dlgoCopyLabel.Size = new System.Drawing.Size(33, 13);
            this.dlgoCopyLabel.TabIndex = 5;
            this.dlgoCopyLabel.Text = "name";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 605);
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
            this.dlgoReorderGroupbox.ResumeLayout(false);
            this.dlgoEditGroupbox.ResumeLayout(false);
            this.dlgoEditGroupbox.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox dlgoReorderGroupbox;
        private System.Windows.Forms.Button dlgoDownButton;
        private System.Windows.Forms.Button dlgoUpButton;
        private System.Windows.Forms.GroupBox dlgoEditGroupbox;
        private System.Windows.Forms.Button dlgoDuplicateButton;
        private System.Windows.Forms.Button dlgoDeleteButton;
        private System.Windows.Forms.Button dlgoCopyButton;
        private System.Windows.Forms.Button dlgoPasteButton;
        private System.Windows.Forms.Label dlgoCopyLabel;
        private System.Windows.Forms.Label label2;
    }
}


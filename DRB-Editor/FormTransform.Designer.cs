namespace DRB_Editor
{
    partial class FormTransform
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
            this.components = new System.ComponentModel.Container();
            this.button_OffsetDLG = new System.Windows.Forms.Button();
            this.upDown_LeftEdge = new System.Windows.Forms.NumericUpDown();
            this.upDown_TopEdge = new System.Windows.Forms.NumericUpDown();
            this.upDown_BottomEdge = new System.Windows.Forms.NumericUpDown();
            this.upDown_RightEdge = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_OffsetDLGO = new System.Windows.Forms.Button();
            this.button_SetDLG = new System.Windows.Forms.Button();
            this.button_SetDLGO = new System.Windows.Forms.Button();
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            this.label_fadeText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_LeftEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_TopEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_BottomEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_RightEdge)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OffsetDLG
            // 
            this.button_OffsetDLG.Location = new System.Drawing.Point(53, 179);
            this.button_OffsetDLG.Name = "button_OffsetDLG";
            this.button_OffsetDLG.Size = new System.Drawing.Size(129, 43);
            this.button_OffsetDLG.TabIndex = 0;
            this.button_OffsetDLG.Text = "Offset selected DLG position";
            this.button_OffsetDLG.UseVisualStyleBackColor = true;
            this.button_OffsetDLG.Click += new System.EventHandler(this.button_OffsetDLG_Click);
            // 
            // upDown_LeftEdge
            // 
            this.upDown_LeftEdge.Location = new System.Drawing.Point(12, 75);
            this.upDown_LeftEdge.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.upDown_LeftEdge.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
            this.upDown_LeftEdge.Name = "upDown_LeftEdge";
            this.upDown_LeftEdge.Size = new System.Drawing.Size(120, 20);
            this.upDown_LeftEdge.TabIndex = 1;
            // 
            // upDown_TopEdge
            // 
            this.upDown_TopEdge.Location = new System.Drawing.Point(131, 27);
            this.upDown_TopEdge.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.upDown_TopEdge.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
            this.upDown_TopEdge.Name = "upDown_TopEdge";
            this.upDown_TopEdge.Size = new System.Drawing.Size(120, 20);
            this.upDown_TopEdge.TabIndex = 2;
            // 
            // upDown_BottomEdge
            // 
            this.upDown_BottomEdge.Location = new System.Drawing.Point(131, 138);
            this.upDown_BottomEdge.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.upDown_BottomEdge.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
            this.upDown_BottomEdge.Name = "upDown_BottomEdge";
            this.upDown_BottomEdge.Size = new System.Drawing.Size(120, 20);
            this.upDown_BottomEdge.TabIndex = 3;
            // 
            // upDown_RightEdge
            // 
            this.upDown_RightEdge.Location = new System.Drawing.Point(255, 75);
            this.upDown_RightEdge.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.upDown_RightEdge.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
            this.upDown_RightEdge.Name = "upDown_RightEdge";
            this.upDown_RightEdge.Size = new System.Drawing.Size(120, 20);
            this.upDown_RightEdge.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Left Edge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Top Edge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bottom Edge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Right Edge";
            // 
            // button_OffsetDLGO
            // 
            this.button_OffsetDLGO.Location = new System.Drawing.Point(53, 228);
            this.button_OffsetDLGO.Name = "button_OffsetDLGO";
            this.button_OffsetDLGO.Size = new System.Drawing.Size(129, 43);
            this.button_OffsetDLGO.TabIndex = 9;
            this.button_OffsetDLGO.Text = "Offset selected DLGO position";
            this.button_OffsetDLGO.UseVisualStyleBackColor = true;
            this.button_OffsetDLGO.Click += new System.EventHandler(this.button_OffsetDLGO_Click);
            // 
            // button_SetDLG
            // 
            this.button_SetDLG.Location = new System.Drawing.Point(188, 179);
            this.button_SetDLG.Name = "button_SetDLG";
            this.button_SetDLG.Size = new System.Drawing.Size(129, 43);
            this.button_SetDLG.TabIndex = 10;
            this.button_SetDLG.Text = "Set selected DLG position";
            this.button_SetDLG.UseVisualStyleBackColor = true;
            this.button_SetDLG.Click += new System.EventHandler(this.button_SetDLG_Click);
            // 
            // button_SetDLGO
            // 
            this.button_SetDLGO.Location = new System.Drawing.Point(188, 228);
            this.button_SetDLGO.Name = "button_SetDLGO";
            this.button_SetDLGO.Size = new System.Drawing.Size(129, 44);
            this.button_SetDLGO.TabIndex = 11;
            this.button_SetDLGO.Text = "Set selected DLGO position";
            this.button_SetDLGO.UseVisualStyleBackColor = true;
            this.button_SetDLGO.Click += new System.EventHandler(this.button_SetDLGO_Click);
            // 
            // fadeTimer
            // 
            this.fadeTimer.Interval = 10;
            this.fadeTimer.Tick += new System.EventHandler(this.fadeTimer_Tick);
            // 
            // label_fadeText
            // 
            this.label_fadeText.ForeColor = System.Drawing.Color.Fuchsia;
            this.label_fadeText.Name = "label_fadeText";
            this.label_fadeText.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_fadeText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_SetDLGO);
            this.Controls.Add(this.button_SetDLG);
            this.Controls.Add(this.button_OffsetDLGO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upDown_RightEdge);
            this.Controls.Add(this.upDown_BottomEdge);
            this.Controls.Add(this.upDown_TopEdge);
            this.Controls.Add(this.upDown_LeftEdge);
            this.Controls.Add(this.button_OffsetDLG);
            this.MinimumSize = new System.Drawing.Size(416, 339);
            this.Name = "FormTransform";
            this.Text = "Transform DRB";
            ((System.ComponentModel.ISupportInitialize)(this.upDown_LeftEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_TopEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_BottomEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDown_RightEdge)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OffsetDLG;
        private System.Windows.Forms.NumericUpDown upDown_LeftEdge;
        private System.Windows.Forms.NumericUpDown upDown_TopEdge;
        private System.Windows.Forms.NumericUpDown upDown_BottomEdge;
        private System.Windows.Forms.NumericUpDown upDown_RightEdge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_OffsetDLGO;
        private System.Windows.Forms.Button button_SetDLG;
        private System.Windows.Forms.Button button_SetDLGO;
        private System.Windows.Forms.Timer fadeTimer;
        private System.Windows.Forms.ToolStripStatusLabel label_fadeText;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
namespace PowerRename
{
    partial class RenameForm
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
            this.Count_desi = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownDigit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownStep = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.Rename_rule = new System.Windows.Forms.GroupBox();
            this.Timebutton = new System.Windows.Forms.Button();
            this.Daybutton = new System.Windows.Forms.Button();
            this.Countbutton = new System.Windows.Forms.Button();
            this.OldFileNamebutton = new System.Windows.Forms.Button();
            this.files_List = new System.Windows.Forms.ListView();
            this.FileListpanel = new System.Windows.Forms.Panel();
            this.SetPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SureButton = new System.Windows.Forms.Button();
            this.CallOffButton = new System.Windows.Forms.Button();
            this.RenameFormattextBox = new System.Windows.Forms.TextBox();
            this.RebackButton = new System.Windows.Forms.Button();
            this.Count_desi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            this.Rename_rule.SuspendLayout();
            this.FileListpanel.SuspendLayout();
            this.SetPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Count_desi
            // 
            this.Count_desi.Controls.Add(this.label3);
            this.Count_desi.Controls.Add(this.numericUpDownDigit);
            this.Count_desi.Controls.Add(this.label2);
            this.Count_desi.Controls.Add(this.numericUpDownStep);
            this.Count_desi.Controls.Add(this.label1);
            this.Count_desi.Controls.Add(this.numericUpDownStart);
            this.Count_desi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Count_desi.Location = new System.Drawing.Point(527, 3);
            this.Count_desi.Name = "Count_desi";
            this.Count_desi.Size = new System.Drawing.Size(258, 100);
            this.Count_desi.TabIndex = 1;
            this.Count_desi.TabStop = false;
            this.Count_desi.Text = "计数器设置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(41, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "总位数：";
            // 
            // numericUpDownDigit
            // 
            this.numericUpDownDigit.Location = new System.Drawing.Point(122, 64);
            this.numericUpDownDigit.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownDigit.Name = "numericUpDownDigit";
            this.numericUpDownDigit.Size = new System.Drawing.Size(90, 21);
            this.numericUpDownDigit.TabIndex = 15;
            this.numericUpDownDigit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDigit.ValueChanged += new System.EventHandler(this.numericUpDownDigit_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(41, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "步   长：";
            // 
            // numericUpDownStep
            // 
            this.numericUpDownStep.Location = new System.Drawing.Point(122, 40);
            this.numericUpDownStep.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownStep.Name = "numericUpDownStep";
            this.numericUpDownStep.Size = new System.Drawing.Size(90, 21);
            this.numericUpDownStep.TabIndex = 13;
            this.numericUpDownStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStep.ValueChanged += new System.EventHandler(this.numericUpDownStep_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "起始值：";
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Location = new System.Drawing.Point(122, 16);
            this.numericUpDownStart.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(90, 21);
            this.numericUpDownStart.TabIndex = 11;
            this.numericUpDownStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStart.ValueChanged += new System.EventHandler(this.numericUpDownStart_ValueChanged);
            // 
            // Rename_rule
            // 
            this.Rename_rule.Controls.Add(this.Timebutton);
            this.Rename_rule.Controls.Add(this.Daybutton);
            this.Rename_rule.Controls.Add(this.Countbutton);
            this.Rename_rule.Controls.Add(this.OldFileNamebutton);
            this.Rename_rule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rename_rule.Location = new System.Drawing.Point(3, 3);
            this.Rename_rule.Name = "Rename_rule";
            this.Rename_rule.Size = new System.Drawing.Size(256, 100);
            this.Rename_rule.TabIndex = 2;
            this.Rename_rule.TabStop = false;
            this.Rename_rule.Text = "重命名规则";
            // 
            // Timebutton
            // 
            this.Timebutton.Location = new System.Drawing.Point(128, 49);
            this.Timebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Timebutton.Name = "Timebutton";
            this.Timebutton.Size = new System.Drawing.Size(85, 20);
            this.Timebutton.TabIndex = 3;
            this.Timebutton.Text = "时间[T]";
            this.Timebutton.UseVisualStyleBackColor = true;
            this.Timebutton.Click += new System.EventHandler(this.Timebutton_Click);
            // 
            // Daybutton
            // 
            this.Daybutton.Location = new System.Drawing.Point(128, 24);
            this.Daybutton.Margin = new System.Windows.Forms.Padding(2);
            this.Daybutton.Name = "Daybutton";
            this.Daybutton.Size = new System.Drawing.Size(85, 20);
            this.Daybutton.TabIndex = 2;
            this.Daybutton.Text = "日期[D]";
            this.Daybutton.UseVisualStyleBackColor = true;
            this.Daybutton.Click += new System.EventHandler(this.Daybutton_Click);
            // 
            // Countbutton
            // 
            this.Countbutton.Location = new System.Drawing.Point(21, 49);
            this.Countbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Countbutton.Name = "Countbutton";
            this.Countbutton.Size = new System.Drawing.Size(85, 20);
            this.Countbutton.TabIndex = 1;
            this.Countbutton.Text = "计数器[C]";
            this.Countbutton.UseVisualStyleBackColor = true;
            this.Countbutton.Click += new System.EventHandler(this.Countbutton_Click);
            // 
            // OldFileNamebutton
            // 
            this.OldFileNamebutton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OldFileNamebutton.Location = new System.Drawing.Point(21, 24);
            this.OldFileNamebutton.Margin = new System.Windows.Forms.Padding(2);
            this.OldFileNamebutton.Name = "OldFileNamebutton";
            this.OldFileNamebutton.Size = new System.Drawing.Size(85, 20);
            this.OldFileNamebutton.TabIndex = 0;
            this.OldFileNamebutton.Text = "原文件名[N]";
            this.OldFileNamebutton.UseVisualStyleBackColor = true;
            this.OldFileNamebutton.Click += new System.EventHandler(this.OldFileNamebutton_Click);
            // 
            // files_List
            // 
            this.files_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.files_List.Location = new System.Drawing.Point(0, 0);
            this.files_List.Margin = new System.Windows.Forms.Padding(2);
            this.files_List.Name = "files_List";
            this.files_List.Size = new System.Drawing.Size(790, 258);
            this.files_List.TabIndex = 9;
            this.files_List.UseCompatibleStateImageBehavior = false;
            // 
            // FileListpanel
            // 
            this.FileListpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileListpanel.Controls.Add(this.files_List);
            this.FileListpanel.Location = new System.Drawing.Point(13, 156);
            this.FileListpanel.Margin = new System.Windows.Forms.Padding(2);
            this.FileListpanel.Name = "FileListpanel";
            this.FileListpanel.Size = new System.Drawing.Size(790, 258);
            this.FileListpanel.TabIndex = 3;
            // 
            // SetPanel
            // 
            this.SetPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetPanel.Controls.Add(this.tableLayoutPanel2);
            this.SetPanel.Controls.Add(this.tableLayoutPanel1);
            this.SetPanel.Location = new System.Drawing.Point(15, 12);
            this.SetPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SetPanel.Name = "SetPanel";
            this.SetPanel.Size = new System.Drawing.Size(788, 139);
            this.SetPanel.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.Count_desi, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Rename_rule, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 106);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Controls.Add(this.SureButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CallOffButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.RenameFormattextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RebackButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 28);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SureButton
            // 
            this.SureButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SureButton.Location = new System.Drawing.Point(565, 2);
            this.SureButton.Margin = new System.Windows.Forms.Padding(2);
            this.SureButton.Name = "SureButton";
            this.SureButton.Size = new System.Drawing.Size(71, 24);
            this.SureButton.TabIndex = 0;
            this.SureButton.Text = "确定";
            this.SureButton.UseVisualStyleBackColor = true;
            this.SureButton.Click += new System.EventHandler(this.SureButton_Click);
            // 
            // CallOffButton
            // 
            this.CallOffButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CallOffButton.Location = new System.Drawing.Point(640, 2);
            this.CallOffButton.Margin = new System.Windows.Forms.Padding(2);
            this.CallOffButton.Name = "CallOffButton";
            this.CallOffButton.Size = new System.Drawing.Size(71, 24);
            this.CallOffButton.TabIndex = 1;
            this.CallOffButton.Text = "取消";
            this.CallOffButton.UseVisualStyleBackColor = true;
            this.CallOffButton.Click += new System.EventHandler(this.CallOffButton_Click);
            // 
            // RenameFormattextBox
            // 
            this.RenameFormattextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenameFormattextBox.Location = new System.Drawing.Point(2, 2);
            this.RenameFormattextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RenameFormattextBox.Name = "RenameFormattextBox";
            this.RenameFormattextBox.Size = new System.Drawing.Size(559, 21);
            this.RenameFormattextBox.TabIndex = 2;
            this.RenameFormattextBox.Text = "[N]";
            this.RenameFormattextBox.TextChanged += new System.EventHandler(this.RenameFormattextBox_TextChanged);
            // 
            // RebackButton
            // 
            this.RebackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RebackButton.Location = new System.Drawing.Point(715, 2);
            this.RebackButton.Margin = new System.Windows.Forms.Padding(2);
            this.RebackButton.Name = "RebackButton";
            this.RebackButton.Size = new System.Drawing.Size(71, 24);
            this.RebackButton.TabIndex = 3;
            this.RebackButton.Text = "撤销";
            this.RebackButton.UseVisualStyleBackColor = true;
            this.RebackButton.Click += new System.EventHandler(this.RebackButton_Click);
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 427);
            this.Controls.Add(this.SetPanel);
            this.Controls.Add(this.FileListpanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1442, 466);
            this.MinimumSize = new System.Drawing.Size(228, 466);
            this.Name = "RenameForm";
            this.Text = "批量重命名";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RenameForm_FormClosed);
            this.Shown += new System.EventHandler(this.RenameForm_Shown);
            this.Count_desi.ResumeLayout(false);
            this.Count_desi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            this.Rename_rule.ResumeLayout(false);
            this.FileListpanel.ResumeLayout(false);
            this.SetPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Count_desi;
        private System.Windows.Forms.GroupBox Rename_rule;
        private System.Windows.Forms.ListView files_List;
        private System.Windows.Forms.Panel FileListpanel;
        private System.Windows.Forms.Panel SetPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SureButton;
        private System.Windows.Forms.Button CallOffButton;
        private System.Windows.Forms.TextBox RenameFormattextBox;
        private System.Windows.Forms.Button OldFileNamebutton;
        private System.Windows.Forms.Button Timebutton;
        private System.Windows.Forms.Button Daybutton;
        private System.Windows.Forms.Button Countbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownDigit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownStart;
        private System.Windows.Forms.Button RebackButton;
    }
}
namespace PowerRename
{
    partial class AboutForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.About_close = new System.Windows.Forms.Button();
            this.About_Name = new System.Windows.Forms.Label();
            this.About_Developer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.About_Group_Instructions = new System.Windows.Forms.GroupBox();
            this.About_Instructions = new System.Windows.Forms.TextBox();
            this.Aboout_picture = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.About_Group_Instructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Aboout_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // About_close
            // 
            this.About_close.Location = new System.Drawing.Point(348, 227);
            this.About_close.Name = "About_close";
            this.About_close.Size = new System.Drawing.Size(75, 23);
            this.About_close.TabIndex = 0;
            this.About_close.Text = "确定";
            this.About_close.UseVisualStyleBackColor = true;
            this.About_close.Click += new System.EventHandler(this.About_close_Click);
            // 
            // About_Name
            // 
            this.About_Name.AutoSize = true;
            this.About_Name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.About_Name.Location = new System.Drawing.Point(6, 17);
            this.About_Name.Name = "About_Name";
            this.About_Name.Size = new System.Drawing.Size(176, 16);
            this.About_Name.TabIndex = 1;
            this.About_Name.Text = "程序名称：PowerRename";
            // 
            // About_Developer
            // 
            this.About_Developer.AutoSize = true;
            this.About_Developer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.About_Developer.Location = new System.Drawing.Point(6, 49);
            this.About_Developer.Name = "About_Developer";
            this.About_Developer.Size = new System.Drawing.Size(192, 16);
            this.About_Developer.TabIndex = 2;
            this.About_Developer.Text = "开发者：PowerRename团队";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "copyright 2017";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Aboout_picture);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.About_Developer);
            this.groupBox1.Controls.Add(this.About_Name);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "程序信息";
            // 
            // About_Group_Instructions
            // 
            this.About_Group_Instructions.Controls.Add(this.About_Instructions);
            this.About_Group_Instructions.Enabled = false;
            this.About_Group_Instructions.Location = new System.Drawing.Point(12, 123);
            this.About_Group_Instructions.Name = "About_Group_Instructions";
            this.About_Group_Instructions.Size = new System.Drawing.Size(411, 100);
            this.About_Group_Instructions.TabIndex = 5;
            this.About_Group_Instructions.TabStop = false;
            this.About_Group_Instructions.Text = "使用说明";
            // 
            // About_Instructions
            // 
            this.About_Instructions.Enabled = false;
            this.About_Instructions.Location = new System.Drawing.Point(9, 21);
            this.About_Instructions.Multiline = true;
            this.About_Instructions.Name = "About_Instructions";
            this.About_Instructions.Size = new System.Drawing.Size(396, 73);
            this.About_Instructions.TabIndex = 0;
            this.About_Instructions.Text = "这里是使用说明";
            // 
            // Aboout_picture
            // 
            this.Aboout_picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Aboout_picture.BackgroundImage")));
            this.Aboout_picture.Location = new System.Drawing.Point(250, 15);
            this.Aboout_picture.Name = "Aboout_picture";
            this.Aboout_picture.Size = new System.Drawing.Size(155, 85);
            this.Aboout_picture.TabIndex = 6;
            this.Aboout_picture.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.About_Group_Instructions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.About_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.About_Group_Instructions.ResumeLayout(false);
            this.About_Group_Instructions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Aboout_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button About_close;
        private System.Windows.Forms.Label About_Name;
        private System.Windows.Forms.Label About_Developer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox About_Group_Instructions;
        private System.Windows.Forms.TextBox About_Instructions;
        private System.Windows.Forms.PictureBox Aboout_picture;
    }
}

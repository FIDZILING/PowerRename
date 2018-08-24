namespace PowerRename
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Show_doc = new System.Windows.Forms.ToolStripMenuItem();
            this.Doc_PowerRename = new System.Windows.Forms.ToolStripMenuItem();
            this.Show_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_sure = new System.Windows.Forms.Button();
            this.Main_close = new System.Windows.Forms.Button();
            this.directory_Tree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.files_List = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Show_doc,
            this.Show_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Show_doc
            // 
            this.Show_doc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Doc_PowerRename});
            this.Show_doc.Name = "Show_doc";
            this.Show_doc.Size = new System.Drawing.Size(44, 21);
            this.Show_doc.Text = "文件";
            this.Show_doc.Click += new System.EventHandler(this.Show_doc_Click);
            // 
            // Doc_PowerRename
            // 
            this.Doc_PowerRename.Name = "Doc_PowerRename";
            this.Doc_PowerRename.Size = new System.Drawing.Size(152, 22);
            this.Doc_PowerRename.Text = "批量重命名";
            this.Doc_PowerRename.Click += new System.EventHandler(this.Doc_PowerRename_Click);
            // 
            // Show_About
            // 
            this.Show_About.Name = "Show_About";
            this.Show_About.Size = new System.Drawing.Size(44, 21);
            this.Show_About.Text = "关于";
            this.Show_About.Click += new System.EventHandler(this.Show_About_Click);
            // 
            // Main_sure
            // 
            this.Main_sure.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Main_sure.FlatAppearance.BorderSize = 0;
            this.Main_sure.Location = new System.Drawing.Point(667, 515);
            this.Main_sure.Name = "Main_sure";
            this.Main_sure.Size = new System.Drawing.Size(71, 24);
            this.Main_sure.TabIndex = 4;
            this.Main_sure.Text = "确定";
            this.Main_sure.UseVisualStyleBackColor = true;
            this.Main_sure.Click += new System.EventHandler(this.Main_sure_Click);
            // 
            // Main_close
            // 
            this.Main_close.Location = new System.Drawing.Point(771, 515);
            this.Main_close.Name = "Main_close";
            this.Main_close.Size = new System.Drawing.Size(75, 23);
            this.Main_close.TabIndex = 5;
            this.Main_close.Text = "退出";
            this.Main_close.UseVisualStyleBackColor = true;
            this.Main_close.Click += new System.EventHandler(this.Main_close_Click);
            // 
            // directory_Tree
            // 
            this.directory_Tree.ImageIndex = 0;
            this.directory_Tree.ImageList = this.imageList1;
            this.directory_Tree.Location = new System.Drawing.Point(13, 45);
            this.directory_Tree.Name = "directory_Tree";
            this.directory_Tree.SelectedImageIndex = 0;
            this.directory_Tree.Size = new System.Drawing.Size(253, 451);
            this.directory_Tree.TabIndex = 7;
            this.directory_Tree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.directory_Tree_BeforeExpand);
            this.directory_Tree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.directory_Tree_AfterExpand);
            this.directory_Tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.directory_Tree_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mycomputer.ico");
            this.imageList1.Images.SetKeyName(1, "close_folder.ico");
            this.imageList1.Images.SetKeyName(2, "open_folder.ico");
            this.imageList1.Images.SetKeyName(3, "Disk.ico");
            this.imageList1.Images.SetKeyName(4, "mydocument.ico");
            // 
            // files_List
            // 
            this.files_List.Location = new System.Drawing.Point(292, 45);
            this.files_List.Name = "files_List";
            this.files_List.Size = new System.Drawing.Size(567, 450);
            this.files_List.TabIndex = 8;
            this.files_List.UseCompatibleStateImageBehavior = false;
            this.files_List.SelectedIndexChanged += new System.EventHandler(this.files_List_SelectedIndexChanged);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "close_folder.ico");
            this.imageList2.Images.SetKeyName(1, "open_folder.ico");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.files_List);
            this.Controls.Add(this.directory_Tree);
            this.Controls.Add(this.Main_close);
            this.Controls.Add(this.Main_sure);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PowerRename";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Show_doc;
        private System.Windows.Forms.ToolStripMenuItem Show_About;
        private System.Windows.Forms.ToolStripMenuItem Doc_PowerRename;
        private System.Windows.Forms.Button Main_sure;
        private System.Windows.Forms.Button Main_close;
        private System.Windows.Forms.TreeView directory_Tree;
        private System.Windows.Forms.ListView files_List;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}


using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PowerRename
{
    /// <summary>
    /// 文件信息结构体
    /// </summary>
    public struct File_STRUCT
    {
        /// <summary>
        /// 序号
        /// </summary>
        public string Number;
        /// <summary>
        /// 文件名
        /// </summary>
        public string fileName;
        /// <summary>
        /// 大小
        /// </summary>
        public string fileSize;
        /// <summary>
        /// 后缀名
        /// </summary>
        public string exName;
        /// <summary>
        /// 最后使用时间
        /// </summary>
        public string lastUseTime;
    };
    
    public partial class MainForm : Form
    {
        /// <summary>
        /// IconIndexs类 对应ImageList中5张图片的序列
        /// </summary>
        private class IconIndexes
        {
            public const int MyComputer = 0;      //我的电脑
            public const int ClosedFolder = 1;    //文件夹关闭
            public const int OpenFolder = 2;      //文件夹打开
            public const int FixedDrive = 3;      //磁盘盘符
            public const int MyDocuments = 4;     //我的文档
        }
        /// <summary>
        /// 文件夹路径
        /// </summary>
        private string files_path;
        public MainForm()
        {
            StartPosition = FormStartPosition.CenterScreen;   //设置窗口居中显示
            InitializeComponent();
        }

        /// <summary>
        /// 主界面
        /// 加载磁盘目录信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //实例化TreeNode类 TreeNode(string text,int imageIndex,int selectImageIndex)            
            TreeNode rootNode = new TreeNode("我的电脑",
                IconIndexes.MyComputer, IconIndexes.MyComputer);  //载入显示 选择显示
            rootNode.Tag = "我的电脑";                            //树节点数据
            rootNode.Text = "我的电脑";                           //树节点标签内容
            this.directory_Tree.Nodes.Add(rootNode);               //树中添加根目录

            //显示MyDocuments(我的文档)结点
            var myDocuments = Environment.GetFolderPath           //获取计算机我的文档文件夹
                (Environment.SpecialFolder.MyDocuments);
            TreeNode DocNode = new TreeNode(myDocuments);
            DocNode.Tag = "我的文档";                            //设置结点名称
            DocNode.Text = "我的文档";
            DocNode.ImageIndex = IconIndexes.MyDocuments;         //设置获取结点显示图片
            DocNode.SelectedImageIndex = IconIndexes.MyDocuments; //设置选择显示图片
            rootNode.Nodes.Add(DocNode);                          //rootNode目录下加载节点
            DocNode.Nodes.Add("");

            //循环遍历计算机所有逻辑驱动器名称(盘符)
            foreach (string drive in Environment.GetLogicalDrives())
            {
                //实例化DriveInfo对象 命名空间System.IO
                var dir = new DriveInfo(drive);
                switch (dir.DriveType)           //判断驱动器类型
                {
                    case DriveType.Fixed:        //仅取固定磁盘盘符 Removable-U盘 
                        {
                            //Split仅获取盘符字母
                            TreeNode tNode = new TreeNode(dir.Name.Split(':')[0]);
                            tNode.Name = dir.Name;
                            tNode.Tag = tNode.Name;
                            tNode.ImageIndex = IconIndexes.FixedDrive;         //获取结点显示图片
                            tNode.SelectedImageIndex = IconIndexes.FixedDrive; //选择显示图片
                            directory_Tree.Nodes.Add(tNode);                    //加载驱动节点
                            tNode.Nodes.Add("");
                        }
                        break;
                }
            }
            rootNode.Expand();                  //展开树状视图
                                                //调用SetListView()函数初始化设置ListView
            SetListView();
        }
        private void SetListView()
        {
            //行和列是否显示网格线
            this.files_List.GridLines = false;
            //显示方式(注意View是Details详细显示)
            this.files_List.View = View.Details;
            //是否可编辑
            this.files_List.LabelEdit = false;
            //没有足够的空间显示时,是否添加滚动条
            this.files_List.Scrollable = true;
            //对表头进行设置
            this.files_List.HeaderStyle = ColumnHeaderStyle.Clickable;
            //是否可以选择行
            this.files_List.FullRowSelect = true;

            //设置listView列标题头 宽度为9/13 2/13 2/13 
            //其中设置标题头自动适应宽度,-1根据内容设置宽度,-2根据标题设置宽度
            this.files_List.Columns.Add("序号", 1 * files_List.Width / 15);
            this.files_List.Columns.Add("名称", 5 * files_List.Width / 15);
            this.files_List.Columns.Add("大小", 2 * files_List.Width / 15);
            this.files_List.Columns.Add("最后访问时间", 4 * files_List.Width / 15);
            this.files_List.Columns.Add("类型", 2 * files_List.Width / 15);
        }

        private void Show_doc_Click(object sender, EventArgs e)
        {

        }

        private void Show_mune_Click(object sender, EventArgs e)
        {

        }

        private void Show_About_Click(object sender, EventArgs e)
        {
            AboutForm aboutform = new AboutForm(); //创建关于窗口
            aboutform.StartPosition = FormStartPosition.CenterScreen;   //设置窗口居中显示
            aboutform.Show();              //显示关于窗口
        }

        /// <summary>
        /// 查看历史记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Doc_history_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"d:\a.txt");   //点击查看打开历史记录文件
        }

        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 撤销操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mune_return_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 本地文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// 批量重命名菜单栏操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Doc_PowerRename_Click(object sender, EventArgs e)
        {
            ToRenameForm();
        }

        private void Main_close_Click(object sender, EventArgs e)
        {
            this.Close();      //退出主窗口
        }
        /// <summary>
        /// 批量重命名确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_sure_Click(object sender, EventArgs e)
        {
            ToRenameForm();
        }

        private void directory_Tree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Expand();
        }

        private void directory_Tree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeViewItems.Add(e.Node);
        }

        /// <summary>
        /// 自定义类TreeViewItems 调用其Add(TreeNode e)方法加载子目录
        /// </summary>
        public static class TreeViewItems
        {
            public static void Add(TreeNode e)
            {
                //try..catch异常处理
                try
                {
                    //判断"我的电脑"Tag 上面加载的该结点没指定其路径
                    if (e.Tag.ToString() != "我的电脑")
                    {
                        e.Nodes.Clear();                               //清除空节点再加载子节点
                        TreeNode tNode = e;                            //获取选中\展开\折叠结点
                        string path = tNode.Name;                      //路径  

                        //获取"我的文档"路径
                        if (e.Tag.ToString() == "我的文档")
                        {
                            path = Environment.GetFolderPath           //获取计算机我的文档文件夹
                                (Environment.SpecialFolder.MyDocuments);
                        }

                        //获取指定目录中的子目录名称并加载结点
                        string[] dics = Directory.GetDirectories(path);
                        foreach (string dic in dics)
                        {
                            //隐藏文件夹系统文件夹不计数
                            if ((new DirectoryInfo(dic).Attributes & FileAttributes.Hidden) != FileAttributes.Hidden
                                && (new DirectoryInfo(dic).Attributes & FileAttributes.System) != FileAttributes.System)
                            {
                                TreeNode subNode = new TreeNode(new DirectoryInfo(dic).Name); //实例化
                                subNode.Name = new DirectoryInfo(dic).FullName;               //完整目录
                                subNode.Tag = subNode.Name;
                                subNode.ImageIndex = IconIndexes.ClosedFolder;       //获取节点显示图片
                                subNode.SelectedImageIndex = IconIndexes.OpenFolder; //选择节点显示图片
                                tNode.Nodes.Add(subNode);

                                //加号判断
                                string[] downdics = Directory.GetDirectories(subNode.Name);
                                //设置计数器判断下层是否有文件夹
                                int k = downdics.Length;
                                foreach (string downdic in downdics)
                                {
                                    if ((new DirectoryInfo(downdic).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
                                        || (new DirectoryInfo(downdic).Attributes & FileAttributes.System) == FileAttributes.System)
                                        k--;
                                }
                                if (k != 0)
                                    subNode.Nodes.Add("");                               //加载空节点 实现+号
                            }
                        }
                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message);                   //异常处理
                }
            }
        }

        private void files_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region ListView显示选中文件夹中文件内容
        /// <summary>
        /// 获取节点的路径:递归调用产生节点对应文件夹的路径
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private string GetPathFromNode(TreeNode node)
        {
            //注意:树形控件中我只赋值Tag\Name,使用Text时赋值即可使用
            if (node.Parent == null)
            {
                return node.Name;
            }
            //Path.Combine组合产生路径 如 Path.Combine("A","B")则生成"A\\B"
            return Path.Combine(GetPathFromNode(node.Parent), node.Name);
        }

        /// <summary>
        /// 更改选定内容后发生 后去当前节点名字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void directory_Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                //定义变量
                string path;                        //文件路径
                TreeNode clickedNode = e.Node;      //获取当前选中结点

                //获取路径赋值path
                if (clickedNode.Tag.ToString() == "我的文档")
                {
                    //获取计算机我的文档文件夹
                    path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
                else
                {
                    //通过自定义函数GetPathFromNode获取结点路径
                    path = GetPathFromNode(clickedNode);
                }

                //由于"我的电脑"为空结点,无需处理,否则会出现路径获取错误或没有找到"我的电脑"路径
                if (clickedNode.Tag.ToString() != "我的电脑")
                {
                    //实例目录与子目录
                    DirectoryInfo dir = new DirectoryInfo(path);
                    files_path = dir.ToString();
                    SetFileList(files_path);
                }
            }
            catch (Exception msg)  //异常处理
            {
                MessageBox.Show(msg.Message);
            }
        }
        #endregion

        /// <summary>
        /// 打开RenameForm
        /// </summary>
        private void ToRenameForm()
        {
            int count = files_List.SelectedItems.Count;
            if (count == 0) // 判断有没有选择文件
            {
                MessageBox.Show("没有选择要重命名的文件", "警告");
                return;
            }
            File_STRUCT[] file_STRUCT = new File_STRUCT[count];
            for (int i = 0; i < count; i++) // 构造结构体
            {
                file_STRUCT[i].Number = (i + 1).ToString(); // 重新从1开始
                file_STRUCT[i].fileName = files_List.SelectedItems[i].SubItems[1].Text;
                file_STRUCT[i].fileSize = files_List.SelectedItems[i].SubItems[2].Text;
                file_STRUCT[i].lastUseTime = files_List.SelectedItems[i].SubItems[3].Text;
                file_STRUCT[i].exName = files_List.SelectedItems[i].SubItems[4].Text;
            }
            RenameForm Rename_Form = new RenameForm(files_path, file_STRUCT)
            {
                StartPosition = FormStartPosition.CenterScreen // 设置窗口居中显示
            };
            // 模式窗口以使主窗体无法操作
            if (Rename_Form.ShowDialog() == DialogResult.OK)
            {
                SetFileList(files_path);
            }
        }
        /// <summary>
        /// 在FileList中显示path中所有文件
        /// </summary>
        /// <param name="path">文件夹路径</param>
        private void SetFileList(string path)
        {
            long length;                        //文件大小
            double dou;                            //大小转换

            //移除ListView所有项 
            this.files_List.Items.Clear();

            //数据更新 UI暂时挂起直到EndUpdate绘制控件,可以有效避免闪烁并大大提高加载速度
            this.files_List.BeginUpdate();
            //实例目录与子目录
            DirectoryInfo dir = new DirectoryInfo(path);
            //MessageBox.Show(files_path);
            //获取当前目录文件列表
            FileInfo[] fileInfo = dir.GetFiles();
            //MessageBox.Show(fileInfo.Length.ToString());
            //循环输出获取文件信息
            int k = 0;
            for (int i = 0; i < fileInfo.Length; i++)
            {
                if ((fileInfo[i].Attributes & FileAttributes.Hidden) != FileAttributes.Hidden
                    && (fileInfo[i].Attributes & FileAttributes.System) != FileAttributes.System) //去除隐藏文件和系统文件
                {
                    ListViewItem listItem = new ListViewItem
                    {
                        //listItem.SubItems[0].Text = fileInfo[i].Name;             //文件名(方法二)
                        Text = (k + 1).ToString(), // 添加序号
                        ForeColor = Color.Red                            //设置行颜色
                    };
                    listItem.SubItems.Add(Path.GetFileNameWithoutExtension(fileInfo[i].DirectoryName
                        + "\\" + fileInfo[i].ToString())); // 显示不带后缀的文件名

                    //length/1024转换为KB字节数整数值 Ceiling返回最小整数值 Divide除法
                    length = fileInfo[i].Length;                                //获取当前文件大小
                    if (length < 1024)
                        listItem.SubItems.Add(length + " B");
                    else if (length < 1024 * 1024)
                    {
                        //listItem.SubItems.Add(Math.Round(decimal.Divide(length, 1024)) + " KB");
                        dou = length / 1024.0;
                        int j_kit = (int)(dou * 100);
                        dou = j_kit / 100.0;
                        listItem.SubItems.Add(dou + " KB");
                    }
                    else if (length < 1024 * 1024 * 1024)
                    {
                        //listItem.SubItems.Add(Math.Round(decimal.Divide(length, 1024 * 1024)) + " MB");
                        dou = length / (1024.0 * 1024.0);
                        int j_kit = (int)(dou * 100);
                        dou = j_kit / 100.0;
                        listItem.SubItems.Add(dou + " MB");
                    }
                    else if (length > 1024 * 1024 * 1024)
                    {
                        dou = length / (1024.0 * 1024.0 * 1024.0);
                        int j_kit = (int)(dou * 100);
                        dou = j_kit / 100.0;
                        listItem.SubItems.Add(dou + " GB");
                    }

                    //获取文件最后访问时间
                    listItem.SubItems.Add(fileInfo[i].LastWriteTime.ToString());

                    //获取文件扩展名时可用Substring除去点 否则显示".txt"
                    if (fileInfo[i].Extension.Count() != 0)
                    {
                        listItem.SubItems.Add(fileInfo[i].Extension.Substring(1));
                    }
                    //加载数据至filesList
                    this.files_List.Items.Add(listItem);
                    k++;                                                           ///编号
                }

            }
            //结束数据处理,UI界面一次性绘制 否则可能出现闪动情况
            this.files_List.EndUpdate();
            // GC 收集清理垃圾 主要清理 FileInfo[] fileInfo 减小内存占用
            GC.Collect();
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;

namespace PowerRename
{
    public partial class RenameForm : Form
    {
        Rename rename;
        File_STRUCT[] file_STRUCT;

        public RenameForm(string filepath, File_STRUCT[] file_STRUCT)
        {
            this.rename = new Rename(filepath, file_STRUCT);
            rename.StrFormat = "[N]";
            this.file_STRUCT = file_STRUCT;
            InitializeComponent();
        }

        private void RenameForm_Shown(object sender, EventArgs e)
        {
            #region files_List设置及初始显示
            
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
            //其中设置标题头自动适应宽度,-1根据内容设置宽度,-2根据标题设置宽度
            this.files_List.Columns.Add("序号", 1 * files_List.ClientSize.Width / 17);
            this.files_List.Columns.Add("原名称", 5 * files_List.ClientSize.Width / 17);
            this.files_List.Columns.Add("新名称", 5 * files_List.ClientSize.Width / 17);
            this.files_List.Columns.Add("大小", 2 * files_List.ClientSize.Width / 17);
            this.files_List.Columns.Add("最后访问时间", 3 * files_List.ClientSize.Width / 17);

            this.files_List.BeginUpdate(); // 数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            for (int i = 0; i < file_STRUCT.Count(); i++)
            {
                ListViewItem lvi = new ListViewItem
                {
                    Text = file_STRUCT[i].Number
                };
                string tmp = file_STRUCT[i].fileName + "." + file_STRUCT[i].exName;
                lvi.SubItems.Add(tmp);
                lvi.SubItems.Add(tmp);
                lvi.SubItems.Add(file_STRUCT[i].fileSize);
                lvi.SubItems.Add(file_STRUCT[i].lastUseTime);
                this.files_List.Items.Add(lvi);
            }
            this.files_List.EndUpdate(); // 结束数据处理，UI界面一次性绘制。
            #endregion
            RebackButton.Enabled = false;
        }
        /// <summary>
        /// 向RenameFormattextBox添加[N]
        /// 原文件名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OldFileNamebutton_Click(object sender, EventArgs e)
        {
            this.RenameFormattextBox.Text += "[N]";
        }
        /// <summary>
        /// 向RenameFormattextBox添加[C]
        /// 计数器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Countbutton_Click(object sender, EventArgs e)
        {
            this.RenameFormattextBox.Text += "[C]";
        }
        /// <summary>
        /// 向RenameFormattextBox添加[D]
        /// 日期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Daybutton_Click(object sender, EventArgs e)
        {
            this.RenameFormattextBox.Text += "[D]";
        }
        /// <summary>
        /// 向RenameFormattextBox添加[T]
        /// 时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timebutton_Click(object sender, EventArgs e)
        {
            this.RenameFormattextBox.Text += "[T]";
        }
        /// <summary>
        /// 重命名格式str改变后操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenameFormattextBox_TextChanged(object sender, EventArgs e)
        {
            rename.StrFormat = RenameFormattextBox.Text; // 更新格式str
            rename.CalculateFileName(); // 计算新文件名
            AddCol2FileList(rename.NewFileName, 2); // 显示
        }
        /// <summary>
        /// 修改files_List中整列的信息
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="col">列号</param>
        private void AddCol2FileList(string[] data,int col)
        {
            files_List.BeginUpdate();
            for (int i = 0; i < data.Count(); i++)
            {
                // 第col列更改为新文件名
                files_List.Items[i].SubItems[col].Text = data[i];
            }
            files_List.EndUpdate();
        }
        /// <summary>
        /// 设置计数器起始位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownStart_ValueChanged(object sender, EventArgs e)
        {
            rename.Count = (int)this.numericUpDownStart.Value; // 设置计数器起始位置
            rename.CalculateFileName(); // 计算新文件名
            AddCol2FileList(rename.NewFileName, 2); // 显示
        }
        /// <summary>
        /// 设置计数器步长
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownStep_ValueChanged(object sender, EventArgs e)
        {
            rename.Step = (int)this.numericUpDownStep.Value; // 设置计数器步长
            rename.CalculateFileName(); // 计算新文件名
            AddCol2FileList(rename.NewFileName, 2); // 显示
        }
        /// <summary>
        /// 设置计数器总位数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownDigit_ValueChanged(object sender, EventArgs e)
        {
            rename.Digit = (int)this.numericUpDownDigit.Value; // 设置计数器总位数
            rename.CalculateFileName(); // 计算新文件名
            AddCol2FileList(rename.NewFileName, 2); // 显示
        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CallOffButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SureButton_Click(object sender, EventArgs e)
        {
            if(rename.JudgeSame)
            {
                MessageBox.Show("新文件名全相同", "警告");
                return;
            }
            try
            {
                rename.RenameFileName();
                MessageBox.Show("成功修改文件信息!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddCol2FileList(rename.NewFileName, 1);
                RebackButton.Enabled = true;
                RenameFormattextBox.Text = "[N]";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("修改文件发生异常!\n" + ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 撤销按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RebackButton_Click(object sender, EventArgs e)
        {
            try
            {
                rename.ReBack();
                MessageBox.Show("成功撤销修改文件信息!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddCol2FileList(rename.NewFileName, 1);
                AddCol2FileList(rename.NewFileName, 2);
                RebackButton.Enabled = false;
                RenameFormattextBox.Text = "[N]";

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("撤销修改文件发生异常!\n" + ex.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RenameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.DialogResult = DialogResult.OK;
        }
    }
}

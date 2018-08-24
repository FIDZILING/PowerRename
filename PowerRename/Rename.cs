using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PowerRename
{
    class Rename
    {
        #region 数据定义

        /// <summary>
        /// 判断文件名是否相同(true为相同)
        /// </summary>
        private bool judgesame = true;
        /// <summary>
        /// 判断文件名是否相同
        /// </summary>
        public bool JudgeSame { get { return judgesame; } }
        /// <summary>
        /// 重命名string规则
        /// </summary>
        private string strFormat;
        /// <summary>
        /// 重命名string规则
        /// </summary>
        public string StrFormat { set { strFormat = value; } }
        /// <summary>
        /// 当前路径
        /// </summary>
        private string pathNow;
        /// <summary>
        /// 旧文件名(不加后缀)
        /// </summary>
        private string[] oldFileName;
        /// <summary>
        /// 后缀名
        /// </summary>
        private string[] FileExName;
        /// <summary>
        /// 为撤销准备
        /// </summary>
        private string[] oldoldfilename;
        /// <summary>
        /// 新不带后缀文件名文件名
        /// </summary>
        private string[] newfilenamewithoutExt;
        /// <summary>
        /// 新文件名(加后缀)
        /// </summary>
        private string[] newFileName;
        /// <summary>
        /// 新文件名
        /// </summary>
        public string[] NewFileName { get { return newFileName; } }
        /// <summary>
        /// 计数器起始位置
        /// </summary>
        private int count = 1;
        /// <summary>
        /// 设置计数器起始位置
        /// </summary>
        public int Count { set { count = value; } }
        /// <summary>
        /// 计数器步长
        /// </summary>
        private int step = 1;
        /// <summary>
        /// 设置计数器步长
        /// </summary>
        public int Step { set { step = value; } }
        /// <summary>
        /// 计数器总位数
        /// </summary>
        private int digit = 1;
        /// <summary>
        /// 设置计数器总位数
        /// </summary>
        public int Digit { set { digit = value; } }

        #endregion

        /// <summary>
        /// 重载构造函数
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <param name="FileList">旧文件结构体</param>
        public Rename(string path, File_STRUCT[] FileList)
        {
            pathNow = path;
            oldFileName = new string[FileList.Count()];
            FileExName = new string[FileList.Count()];
            for (int i = 0; i < FileList.Count(); i++)
            {
                oldFileName[i] = FileList[i].fileName;
                FileExName[i] = FileList[i].exName;
            }
        }
        /// <summary>
        /// 根据规则、旧文件名计算新文件名列表
        /// </summary>
        public void CalculateFileName()
        {
            // 分割属性字段
            char[] separator = { '[', ']' };
            List<string> splitResult = new List<string>(strFormat.Split(separator));
            newFileName = new string[oldFileName.Count()];
            newfilenamewithoutExt = new string[oldFileName.Count()];
            judgesame = true;
            bool tempjudge1 = false; // 判断有无N
            bool tempjudge2 = false; // 判断有无C
            // 生成新文件名
            for (int i = 0; i < splitResult.Count; i++)
            {
                // 添加原文件名
                if (splitResult[i].Equals("N"))
                {
                    tempjudge1 = true;
                    for (int j = 0; j < oldFileName.Count(); j++)
                    {
                        newfilenamewithoutExt[j] += oldFileName[j];
                    }
                }
                // 添加日期
                else if (splitResult[i].Equals("D"))
                {
                    // yyyy年mm月dd日
                    string day = DateTime.Now.ToLongDateString();
                    for (int j = 0; j < oldFileName.Count(); j++)
                    {
                        newfilenamewithoutExt[j] += day;
                    }
                }
                // 添加时间
                else if (splitResult[i].Equals("T"))
                {
                    // hhmmss
                    string[] times = DateTime.Now.ToLongTimeString().Split(':');
                    string time = times[0] + times[1] + times[2];
                    for (int j = 0; j < oldFileName.Count(); j++)
                    {
                        newfilenamewithoutExt[j] += time;
                    }
                }
                // 添加计数器
                else if (splitResult[i].Equals("C"))
                {
                    tempjudge2 = true;
                    int c = count;
                    for (int j = 0; j < oldFileName.Count(); j++, c += step)
                    {
                        string tmp = c.ToString();
                        while (tmp.Length < digit)
                            tmp = "0" + tmp;
                        newfilenamewithoutExt[j] += tmp;
                    }
                }
                // 其他字符
                else
                {
                    for (int j = 0; j < oldFileName.Count(); j++)
                    {
                        newfilenamewithoutExt[j] += splitResult[i];
                    }
                }
                GC.Collect();
            }
            // 判断新文件名是否全相同
            if (tempjudge1 || tempjudge2 || newFileName.Count() == 1)
                judgesame = false;
            // 加后缀
            for (int i = 0; i < newFileName.Count(); i++)
            {
                newFileName[i] = newfilenamewithoutExt[i] + "." + FileExName[i];
            }
            GC.Collect();
        }
        /// <summary>
        /// 重命名文件
        /// </summary>
        public void RenameFileName()
        {
            for (int i = 0; i < oldFileName.Count(); i++)
                File.Move(pathNow + "\\" + oldFileName[i] + "." + FileExName[i],
                    pathNow + "\\" + newFileName[i]);
            oldoldfilename = new string[oldFileName.Count()];
            for (int i = 0; i < oldFileName.Count(); i++)
            {
                oldoldfilename[i] = oldFileName[i];
                oldFileName[i] = newfilenamewithoutExt[i];
            }
        }
        /// <summary>
        /// 撤销
        /// </summary>
        public void ReBack()
        {
            for (int i = 0; i < oldFileName.Count(); i++)
                File.Move(pathNow + "\\" + oldFileName[i] + "." + FileExName[i],
                    pathNow + "\\" + oldoldfilename[i] + "." + FileExName[i]);
            for (int i = 0; i < oldFileName.Count(); i++)
            {
                oldFileName[i] = oldoldfilename[i];
                newFileName[i] = oldoldfilename[i];
            }
        }
    }
}

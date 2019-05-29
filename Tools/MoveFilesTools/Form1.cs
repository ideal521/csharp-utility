using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DirectoryInfo dir = new DirectoryInfo(txtPath.Text.Replace("\\", "/"));
            DirectoryInfo[] DirSub = dir.GetDirectories();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (DirectoryInfo item in DirSub)
            {
                Console.WriteLine(item.Name);

                string name = String.IsNullOrEmpty(txtFind.Text) ? item.Name : item.Name.Replace(txtFind.Text, txtReplace.Text);

                string url = $"{txtOutPath.Text}\\{name}";
                if (url != item.Name)
                {
                    item.MoveTo(url);
                    stringBuilder.Append(url + Environment.NewLine);
                }
            }
            MessageBox.Show(stringBuilder.ToString());


        }

        private void txtPath_Click(object sender, EventArgs e)
        {
            //folder控件描述Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.Description = "请选择一个文件夹：";
            //指定folder根=桌面
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            //是否添加新建文件夹的按钮
            folderBrowserDialog1.ShowNewFolderButton = true;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void txtOutPath_Click(object sender, EventArgs e)
        {
            //folder控件描述Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.Description = "请选择一个文件夹：";
            //指定folder根=桌面
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            //是否添加新建文件夹的按钮
            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}

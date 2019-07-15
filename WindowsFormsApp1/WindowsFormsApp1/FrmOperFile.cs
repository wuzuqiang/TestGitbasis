using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public partial class FrmOperFile : Form
    {
        public FrmOperFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            string defaultfilePath = "";
            //首次defaultfilePath为空，按FolderBrowserDialog默认设置（即桌面）选择
            if (defaultfilePath != "")
            {
                //设置此次默认目录为上一次选中目录
                dlg.SelectedPath = defaultfilePath;
            }
            if (DialogResult.OK == dlg.ShowDialog())
            {
                defaultfilePath = dlg.SelectedPath;
                txtFolder.Text = dlg.SelectedPath;
            }
            if(string.IsNullOrEmpty(txtFileNameNeedContain.Text))
            {
                if(DialogResult.OK == MessageBox.Show("查找文本为空，确定是否停止？？？"))
                {
                    return;
                }
            }
            //foreach(FileInfo info in (new DirUtil()).getAllFile(txtFolder.Text))
            //{
            //    txtFiles.Text += info.FullName + ";\n";
            //}
            foreach (FileInfo info in (new DirUtil()).getAllFile(txtFolder.Text, txtFileNameNeedContain.Text))
            {
                if ((new StringUtils()).isMatch(Path.GetExtension(info.FullName), ".cs|.js"))
                {
                    txtFiles.Text += info.FullName + ";\n";
                }
            }
            //foreach(DirectoryInfo info in (new DirUtil()).getAllDir(txtFolder.Text))
            //{
            //    txtFiles.Text += info.FullName + ";\n";
            //}
            //(new DirUtil()).recycleChangeDir(txtFolder.Text.Trim(), "23", "wu");
            //foreach (string info in (new DirUtil()).get第二级别下各自的一行目录或者文件(txtFolder.Text))
            //{
            //    txtFiles.Text += info + ";\n";
            //}
        }

        private void FrmOperFile_Load(object sender, EventArgs e)
        {
        }

        private void btnCopyFile_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtProduct.Text) || string.IsNullOrEmpty(txtBrand1.Text))
            {
                MessageBox.Show("Product或者Brand1不能为空！");
                txtProduct.Focus();
                return;
            }
            foreach(string str in Regex.Split(txtFiles.Text, ";\\n"))
            {
                if(string.IsNullOrEmpty(str))
                {
                    return;
                }
                (new FileUtils()).copyFile(str, txtProduct.Text, txtBrand1.Text);
            }
            //Do Something to reset;
            //SmartGit reset之后，现在再次提交
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProduct.Text) || string.IsNullOrEmpty(txtBrand1.Text))
            {
                MessageBox.Show("Product或者Brand1不能为空！");
                txtProduct.Focus();
                return;
            }
            foreach (string str in Regex.Split(txtFiles.Text, ";\\n"))
            {
                (new FileUtils()).openFile(str, txtProduct.Text, txtBrand1.Text);
            }
        }
    }
}

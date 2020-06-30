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

namespace T批量修改文件名
{
    public partial class newFileName : Form
    {
        public newFileName()
        {
            InitializeComponent();
        }

        //新文件夹名称
        private void newFileName_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 转换文件名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //判断更换文件名的数量是否相等
            if (listPash.Count==newName.Length)
            {
                Directory.CreateDirectory(listPash[0] + "\\NEW\\");              
                for (int i = 0; i < listPash.Count; i++)
                {
                    
                    //组合成新的文件路径
                    string newPath = listPash[i]+"\\NEW\\"+newName[i];


                   File.Copy(listFileName[i],newPath);

                   MessageBox.Show("文件名替换成功");
                }
            }
            else
                MessageBox.Show("文件名数量不相等，请检查");
        }


        //保存路径的列表
        List<string> listPash = new List<string>();
        //保存路径和文件名的列表
        List<string> listFileName = new List<string>();


        /// <summary>
        /// 打开文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //创建打开对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //打开目录
            ofd.InitialDirectory = @"D:";
            //设置打开的文件类型
            ofd.Filter = "所有文件|*.*";
            //是否多选
            ofd.Multiselect = true;
            ofd.Title = "请选择需要打开的文件";
            ofd.ShowDialog();
            //获得打开文件的全路径
            string[] path = ofd.FileNames;           
            //循环存到集合中
            for (int i = 0; i < path.Length; i++)
            {
                //把路径存在集合中，不含文件名
                listPash.Add(Path.GetDirectoryName(path[i]));
                listFileName.Add(path[i]);
                //把文件名放到列表中
                listBox1.Items.Add(Path.GetFileName(path[i]));
                //listBox2.Items.Add(Path.GetDirectoryName(path[i]));
            }
          
        }
      
        /// <summary>
        /// 保存文件名到文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileName_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfo = new SaveFileDialog();
            sfo.InitialDirectory = @"D:";//默认路径
            sfo.Title = "请选择保存路径";//对话框标题
            sfo.Filter = "文本文件|*.txt";//保存的文件名
            sfo.FileName = "新建文件";//默认保存的文件名

            string path = ""; //保存的文件名及路径
            //如果按下保存键，把文件路径与文件名保存到path中
            if (sfo.ShowDialog() == DialogResult.OK)
                path = sfo.FileName;

            //获得文件名
            string[] oldFileName = new string[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                oldFileName[i] = listBox1.Items[i].ToString();
            }

            //写入
            File.WriteAllLines(path, oldFileName);

            MessageBox.Show("保存文件成功");
        }

        //新文件名变量
        string[] newName = null;

        /// <summary>
        /// 打开新文件名的文本文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //创建打开对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //打开目录
            ofd.InitialDirectory = @"D:";
            //设置打开的文件类型
            ofd.Filter = "所有文件|*.*";
            //是否多选
            ofd.Multiselect = true;
            ofd.Title = "请选择需要打开的文件";
            ofd.ShowDialog();
            //获得打开文件的全路径
            string path = ofd.FileName;
           //按行读取文件，并把文件名保存下来
            newName =File.ReadAllLines(path,Encoding.UTF8);
            if(newName!=null)
            { 
            for (int i = 0; i < newName.Length; i++)
            {
                listBox2.Items.Add(newName[i]);
            }
            }
        }

        /// <summary>
        /// 复位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reesut_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listFileName.Clear();
            listPash.Clear();
            newName = null;
        }
    }
}

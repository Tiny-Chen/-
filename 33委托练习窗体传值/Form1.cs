using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33委托练习窗体传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //调用窗体2，需要传个方法过去
            Form2 form2 = new Form2(ShowMes);
            form2.Show();
        }

        //主窗体有方法，但没有值 ，需要把方法传到窗体2中
        void ShowMes(string str)
        {
            label1.Text = str;
        }
    }
}

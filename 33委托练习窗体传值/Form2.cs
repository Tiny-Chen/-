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
    //建立委托
    public delegate void DelMsg(string str);
    public partial class Form2 : Form
    {
        private DelMsg _del;
        //打开窗体时，会调用构造函数，那么我们把值通过委托传到主窗体中
        public Form2(DelMsg del)
        {
            this._del = del;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_del保存的是主窗体中的方法，那么把这个值传过去
            _del (textBox1.Text);
        }
    }
}

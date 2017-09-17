using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象模拟打开文件
{
    /// <summary>
    /// 打开类型是Txt
    /// </summary>
    class TextFile : FileFather
    {
        /// <summary>
        /// 重写打开文件方法，打开文件
        /// </summary>
        public override void OpenFlie()
        {
            //传入属性,打开文件的路径
            ProcessStartInfo psi = new ProcessStartInfo(this.fileName);
            //创建进程
            Process p = new Process();
            p.StartInfo = psi;
            //打开进程
            p.Start();
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fileName"></param>
        public TextFile(string fileName) : base(fileName)
        {
            this.fileName = fileName;
        }
    }
}

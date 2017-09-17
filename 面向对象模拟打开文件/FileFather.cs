using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象模拟打开文件
{
    /// <summary>
    /// 打开文件父类
    /// </summary>
    public abstract class FileFather
    {
        /// <summary>
        /// 文件类型属性，用来记录要打开文件的全路径
        /// </summary>
        public string fileName
        {
            get;
            set;
        }

        /// <summary>
        /// 构造涵数，用来构造对象时外部传入路径参数
        /// </summary>
        /// <param name="fileName"></param>
        public FileFather(string fileName)
        {
            this.fileName = fileName;
        }
        //抽象打开方法
       // public abstract void OpenFlie();

        //可以是虚方法
        public virtual void OpenFlie()
        {
            //传入属性,打开文件的路径
            ProcessStartInfo psi = new ProcessStartInfo(this.fileName);
            //创建进程
            Process p = new Process();
            p.StartInfo = psi;
            //打开进程
            p.Start();
        }

        //普通方法，但不能用于抽象
        //public static void OpenFlie()
        //{
        //    //传入属性,打开文件的路径
        //    ProcessStartInfo psi = new ProcessStartInfo(this.fileName);
        //    //创建进程
        //    Process p = new Process();
        //    p.StartInfo = psi;
        //    //打开进程
        //    p.Start();
        //}
    }
}

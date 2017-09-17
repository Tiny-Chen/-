using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07移动存储练习
{
    public class Computer
    {
        /// <summary>
        /// 拿到插到电脑上存储设备的父类,用属性来保存父类的类型
        /// </summary>
        public UsbContorl usb
        {
            get;
            set;
        }

        public void CpuRead()
        {
            //调用父类中的方法
            usb.Read();
        }

        public void CpuWrite()
        {
            //调用父类中的方法
            usb.Write();
        }
    }
}

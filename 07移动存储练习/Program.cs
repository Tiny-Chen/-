using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07移动存储练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化对象
            MobileDisk md = new MobileDisk();
            UDisk ud = new UDisk();
            MP3 mp3 = new MP3();
            Computer cp = new Computer();

            //调用电脑中的父类的属性，并把子类赋值给父类
            cp.usb = md;
            //调用方法，看似调用父类的方法，但实际调用的方法已被父类中装的子类进行了改写。
            cp.CpuRead();
            cp.CpuWrite();
            Console.ReadKey();

        }
    }
}

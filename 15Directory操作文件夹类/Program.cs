using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _15Directory操作文件夹类
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建文件夹
            Directory.CreateDirectory(@"C:\Users\Tiny\Desktop\Music");
            Console.ReadKey();

            //Delete//删除文件夹,如果不是空目录，加TRUE

            //返回文件夹中所有文件及其全路径
            string [] path =Directory.GetFiles(@"C:\Users\Tiny\Desktop\Music");

            //Directory.GetDirectories,返回目录中所有子目录
        }
    }
}

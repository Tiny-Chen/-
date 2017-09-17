using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _13Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Tiny\Desktop\VS快捷键.txt";
            //Combine两个路径连接，自动处理分隔线连接
            string s = Path.Combine(@"C: \Users\Tiny\Desktop", "VS快捷键.txt");
            //获取文件全路径
            string s1 = Path.GetDirectoryName(path);
            //获取文件扩展名
            string s2 = Path.GetExtension(path);
            //获取文件名，带扩展名的
            string s3 = Path.GetFileName(path);
            //获取文件名，不带扩展名的
            string s4 = Path.GetFileNameWithoutExtension(path);
            //获取文件路径
            string s5 = Path.GetFullPath(path);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _17文件流Filetream
{
    class Program
    {
        //主要用来操作大文件，通过分割进行读写

        static void Main(string[] args)
        {
            //因为GC是不主动回收文件流的，所以写在 using里头
            //1、读取文件
            //FileMode:读取模式：追加、打开、打开或创建，打开并清空
            //FileAccese
            //using (FileStream fs = new FileStream(@"C:\Users\Tiny\Desktop\职工工资.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    //创建读取字节大小
            //    byte[] buffer = new byte[1024 * 1024 * 5];
            //    //读取实际有效的大小
            //    int r = fs.Read(buffer, 0, buffer.Length);
            //    //编码转换
            //    string s = Encoding.UTF8.GetString(buffer,0,r);
            //    Console.WriteLine(s);
            //}
            //Console.ReadKey();

            //2、写入文件
            //using (FileStream fs = new FileStream(@"C:\Users\Tiny\Desktop\职工工资.txt", FileMode.Append, FileAccess.Write))
            //{
            //    string s = "今天天气好好呀";
            //    //编码转换
            //    byte[] buffer = Encoding.UTF8.GetBytes(s);
            //    fs.Write(buffer, 0, buffer.Length);
            //}

            //StreamRead  ---------流的读取与写入，与FileStream一样
            //using (StreamReader sr = new StreamReader(@"C:\Users\Tiny\Desktop\职工工资.txt", Encoding.UTF8))
            //{
            //    string str =sr.ReadToEnd();
            //    Console.WriteLine(str);                
            //}
            //Console.ReadKey();

            //StreamWrite
            byte[] buffer = new byte[1024 * 1024 * 5];
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Tiny\Desktop\职工工资.txt",true,Encoding.UTF8, buffer.Length))
            {
                sw.WriteLine("1234567890123");
            }
            Console.ReadKey();
        }
    }
}

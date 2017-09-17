using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _14File类
{
    class Program
    {
        //File类，主要是用来操作文件的，如复制，剪切，移除，读取数据
        static void Main(string[] args)
        {
            //操作文件
            //Create创建文件
            //File.CreateText(@"C:\Users\Tiny\Desktop\new.txt");
            // Console.WriteLine("创建成功 ");
            //复制Copy
            // File.Copy(@"C:\Users\Tiny\Desktop\new.txt", @"C:\Users\Tiny\Desktop\new1.txt");
            /*
             * Move:剪切
             * delete：删除
             * */

            //-----------------------------------------------------------------------------------------------------------------

            //读取数据（读小文件）
            //1、File.ReadAllBytes，以字节形式读取，返回的是字节数组.
            //byte[]buffer =File.ReadAllBytes(@"C:\Users\Tiny\Desktop\VS快捷键.txt");
            //编码:把字符串以怎样的形式存储为二进制：ASCII   GBK  GBK2312   UTF-8
            //string str = Encoding.UTF8.GetString(buffer, 0, buffer.Length);

            //2、File.ReadAllLines,每行读取，返回的是字符串数组，每一行是一个元素，需要操作内容的时候使用该方法
            //string[] str =File.ReadAllLines(@"C:\Users\Tiny\Desktop\VS快捷键.txt",Encoding.UTF8);
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}

            //3、File.ReadAllText,整版读取，返回字符串
            //string str = File.ReadAllText(@"C:\Users\Tiny\Desktop\VS快捷键.txt",Encoding.UTF8);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //-----------------------------------------------------------------------------------------------------------------
            //写入操作,写入是覆盖的

            //1、File.WriteAllBytes以字节形式写入,需要字节数据或字符串
            //string str = "File类的写入方式";
            //编码转换
            //byte[] buffre = Encoding.UTF8.GetBytes(str);
            //File.WriteAllBytes(@"C:\Users\Tiny\Desktop\new", buffre);

            //2、以行的方式写入,需要字符串数组，1个元素为1行
            //string[] str = { "123", "456", "789", "111213" };
            //File.WriteAllLines(@"C:\Users\Tiny\Desktop\new.txt", str);

            //3、以字符串的形式写入，需要字符串
            //string str = "123455677890123145342362465456436346";
            //File.WriteAllText(@"C:\Users\Tiny\Desktop\new.txt", str);
            //Console.ReadKey();

            //向文件追加字节
            //1、以行的形式追加，需要字符串数组
            string[] str = { "1", "2" };
            File.AppendAllLines(@"C:\Users\Tiny\Desktop\new.txt", str);

            //File.AppendAllText, 以字符串string的形式进行追加
            
            //File.AppendText(),以字节数组的形式追加，需要转换编码byte[]



        }
    }
}

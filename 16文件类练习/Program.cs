using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16文件类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //对职工工资文件进行处理，所有人工资加倍然后输出到新文件，放到新文件夹中 
            //读取职工工资文件
            string path = @"C:\Users\Tiny\Desktop\职工工资.txt";
            string[] mon = File.ReadAllLines(path);           
            //循环对每个元素进行再分割  张三|5000 splict
            for (int i = 0; i < mon.Length; i++)
            {
                //分割数组元素 去掉|，"张三","5000"
                string[ ] str =mon[i].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                //把第2位数*2
                int num = Convert.ToInt32(str[1]) * 2;
                //再组合
                mon[i] = str[0] + "|" + num.ToString();
                     
            }
            //创建文件夹
            Directory.CreateDirectory(@"C: \Users\Tiny\Desktop\职工工资");

            //写入文件夹
            File.WriteAllLines(@"C: \Users\Tiny\Desktop\职工工资\.职工工资.txt", mon, Encoding.UTF8);
            Console.WriteLine("写 入成功");
            Console.ReadKey();
        }
    }
}

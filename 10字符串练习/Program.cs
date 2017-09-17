using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _10字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //把123---456-----789，变成123-456-789
            //string str = "123---456-----789";
            //string[] strs = str.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
            //string newStr = string.Join("-", strs);
            //Console.WriteLine(newStr);
            //Console.ReadKey();
            /*
             * 张三，100
             * 李四，200
             * 王五，20
             * 赵六，190
             * 田七，980
             * 读取文件txt：求员工的最高工资、最低工资、平均工资
             */
            string[] Fstr = File.ReadAllLines(@"C:\Users\Tiny\Desktop\工资.txt");
            int max =int.MinValue;//把最小的给最大的
            int min = int.MaxValue;//把int 最大值 给最小的
            int pingju = 0;

            for (int i = 0; i < Fstr.Length; i++)
            {
                string[] str = Fstr[i].Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
                if (int.Parse(str[1]) > max)
                {
                    max = int.Parse(str[1]);
                }
                if (int.Parse(str[1]) < min)
                {
                    min = int.Parse(str[1]);
                }
                pingju += int.Parse(str[1]);

            }
            pingju = pingju / Fstr.Length;
            Console.WriteLine("最高工资是{0}，最低工资是{1}，平均工资是{2}",max,min,pingju);
            Console.ReadKey();
        }

       
    }
}

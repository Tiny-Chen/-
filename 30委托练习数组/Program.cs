using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30委托练习数组
{
    public delegate int Delgeat(object o1, object o2);
    class Program
    {
        //通过委托求数组的最大值 
        static void Main(string[] args)
        {
            string[] names = {"asdfasdf", "dfdf", "sdfsfdsfdfsdf"};
            //匿名委托方法实现---根据比较方法
            object resut = GetResut(names, delegate(object o1, object o2)
            {
                string A1 = (string) o1;
                string A2 = (string) o2;
                return A1.Length - A2.Length;
            });
            //LAMDE表达式
            object resut1 = GetResut(names, (object o1, object o2) =>
            {
                string A1 = (string) o1;
                string A2 = (string) o2;
                return A1.Length - A2.Length;
            });
            Console.WriteLine(resut1);
            Console.ReadKey();
        }

        public static object GetResut(object [ ]num, Delgeat del)
        {
            object max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                //传入比较的方法----要求得到的一个值与这个0进行比较
                if (del(max,num[i])<0)
                {
                    max = num[i];
                }
            }
            return max;
        }
    }
}

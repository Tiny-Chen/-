using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31泛型委托
{
    class Program
    {
        public delegate int DelResuse<T>(T t1, T t2);
        //泛型，就是类型不确定，用T(类型英文的缩写)表示<T>
        static void Main(string[] args)
        {
            //求一个数组的最大值 ，现在不确定是什么数组，那么就定义一个泛型的数组 方法
            //int数组 
            int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int num =GetReuse(nums, (t1, t2) =>
            {
                return t1 - t2;
            });
            Console.WriteLine(num);
            //string数组
            string[] str = {"1", "123123", "2312313", "1293940294720"};
            string s1 = GetReuse(str, ((t1, t2) =>
            {
                return t1.Length - t2.Length;
            } ));
            Console.WriteLine(s1);
            Console.ReadKey();

        }
        //定义泛型求最大值的方法
        public static T GetReuse<T>(T[] name, DelResuse<T> del)
        {
            T max = name[0];
            for (int i = 0; i < name.Length; i++)
            {
                //怎么比较不知道，传入一个比较方法，用委托
                if (del(max, name[i]) < 0)
                {
                    max = name[i];
                }
            }
            return max;
        }
    }
}

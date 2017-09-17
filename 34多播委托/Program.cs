using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34多播委托
{
    public delegate void DelTest();
    class Program
    {
        //委托不仅仅指向1个函数（方法），可以指向多个；用+，-；注意如果用=号那么就只指向1个了
        static void Main(string[] args)
        {
            DelTest del =T1;
            del += T2;
            del += T3;
            del += T4;
            del -= T2;
            del -= T3;
            //---
            //del = T3;
            del();
            Console.ReadKey();
        }

        public static void T1()
        {
            Console.WriteLine("我是1");
        }
        public static void T2()
        {
            Console.WriteLine("我是2");
        }
        public static void T3()
        {
            Console.WriteLine("我是3");
        }
        public static void T4()
        {
            Console.WriteLine("我是4");
        }

    }
}

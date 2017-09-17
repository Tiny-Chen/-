using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第1个数");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入第2个数");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入运算符");
            string cal = Console.ReadLine();

            CalFather ft = GetResart(numberOne, numberTwo, cal);
            double resut =ft.GetResut();
            Console.WriteLine(resut);
            Console.ReadKey();
        }

        /// <summary>
        /// 根据用户输入，里氏转换方法，装载不同的子类
        /// 简单工厂，根据用户对象返回一个父类
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <param name="cal"></param>
        /// <returns></returns>
        public static CalFather GetResart(int numberOne, int numberTwo,string cal)
        {
            CalFather ft = null;
            switch (cal)
            {
                case "+":
                    ft = new Sum(numberOne,numberTwo);
                    break;
                case "-":
                    ft = new Sub(numberOne,numberTwo);
                    break;
            }
            return ft;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1、单例模式只能创建1个对象，不像QQ能打开这么多
             * 2、Preson构造函数初始化
             * 3、提供1个静态方法，返回1个对象
             * 4、创建单例（全局的），赋值为null
             */

            Preson.GetSingle().Name="张三";
            Preson.GetSingle().Age = 18;

            Console.WriteLine(Preson.GetSingle().Name+"---"+Preson.GetSingle().Age);
            Console.ReadKey();
        }
    }
}

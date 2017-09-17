using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象复习
{
    class Program
    {
        //面向对向：封装、继承、多态
        static void Main(string[] args)
        {
            //创建类的对象，注意抽象类这些是不能new的，但可以通进里氏转换的方法
            Preson p = new Preson('男');
            p.Name = "张三";
            p.Age = 15;
           // p.Gender = '女';
            p.SaHi();
            Console.ReadKey();
        }
    }
}

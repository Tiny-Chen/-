using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28委托定义
{
    //3、声明委托类型，指向一个方法
    //声明的委托必须要与指向的方法具有相同的返回值类型和参数类型，使用delegate关键字
    public delegate void DelSayHi(string name);

    class Program
    {
        static void Main(string[] args)
        {
            //4、使用的时候不是调用两个打招呼的方法，而是通过委托来实现
            //参数为：委托的参数名称，指向的方法名称
            
            //第一种方法
            //DelSayHi del = new DelSayHi(ChinaSayHi);//--类似于进程
            //del("张三");
            
            //第二种方法,直接把指向的方法给委托，把函数赋值给委托，前提是函数与委托签名是一样的
            //DelSayHi del = ChinaSayHi;
            //del("张三");
             
            //第三种方法
            Test("张三",ChinaSayHi);
            Console.ReadKey();
        }
        //1、中国与英国的打招呼方式--=------以前实现是调用这两个方法
        public static void ChinaSayHi(string name)
        {
            Console.WriteLine("你好"+name);
        }

        public static void EnglishSayHi(string name)
        {
            Console.WriteLine("Hello"+name);
        }

        //2、通过这个函数来调用打招呼的方式,那么调用方法要使用委托类型
        //把委托的名称作为参数传进去--------使用委托只需要调用这一个方法，根据需求去实现功能
        public static void Test(string name, DelSayHi del)
        {
            del(name);
        }
    }
}

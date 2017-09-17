using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _08接口
{
    class Program
    {
        /*
         * 1、接口实现多态
         * 
         */
        static void Main(string[] args)
        {
        }
    }

    /// <summary>
    /// 我会飞接口
    /// </summary>
    interface IFlyable
    {
        //接口可以有方法，字段，属性，但方法不能有方法体，不能有修饰，因为默认是public
        void Fly();
    }

    class bord : IFlyable
    {
        void IFlyable.Fly()
        {
            Console.WriteLine("显示实现接口，辟免了方法重名，隐藏自己或父类的函数");
        }
    }

    class Paln : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("普通实现接口");
        }
    }
}

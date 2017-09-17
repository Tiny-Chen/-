using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27委托
{
    class Program
    {
        /*1、为什么使用委托
         * 把方法做为参数传给另1个方法，参数都有类型，那么方法的类型叫委托类型
         * 2、委托定义
         * 声明一个委托类型，指向的方法必须跟委托有相同的签名（即参数和返回值是与指向方法相同的）
         * 写在命名空间下
         */

         //声明委托
        //public delegate void DelProSt(string[] name);
        //改进的
        //public delegate string DelProSt(string name);

        public delegate string DelProSt(string name);

        static void Main(string[] args)
        {
            //需求
            //1、字符串数组中每个元素都转换大写
            //2、数组 中每个元素转换成小写
            //3、数组中每个元素两边加上双引号
            string[] names = {"aBcdEf", "GhiJk", "LmnoPQ"};

            //通过观察，三个方法只有一个地方不一样，就是里面实现的内容不一样，能不能把这个扣出来呢
            //把外面相同的扣出来，传一个条件（方法）进去，即把方法做为参数传进去给另一个方法

            //通过委托实现转换大写
            //Text(names,ProStToUpper);

            //改进的
            // ProSt(names,StrToUpper);

            //把具体实现的功能在调用的时候传进去---------------匿名函数-----函数没有名字，只有委托关键字代替delegate(string name){return name.ToLower();}
            ProSt(names, delegate(string name)
           {
               return name.ToLower();
           });

           Console.ReadKey();

        }

        #region 初始的委托

        /*旧的功能写法-----------------------------------------------
        //转换大写
        public static void ProStToUpper(string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = name[i].ToUpper();
            }
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }
        //转换小写
        public static void ProStTolower(string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = name[i].ToLower();
            }
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }

        //添加双引号
        public static void ProStSdting(string[] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = "\"" + name[i] + "\"";
            }
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }

         /// <summary>
        /// 委托实现数组功能的方法
        /// </summary>
        /// <param name="name">数组类型参数</param>
        /// <param name="del">委托名</param>
        public static void Text(string[]name,DelProSt del)
        {
            del(name);
        }

        */
        #endregion

        #region 改进后的，但方法还是在
        /*
        //提取出来后的-------------------------
        //因为不知道用户需要实现大写还是小写，那么我们给个委托，需要什么传什么
        public static void ProSt(string[]names,DelProSt del)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = del(names[i]);
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        //实现的功能大写
        public static string StrToUpper(string names)
        {
            return names.ToUpper();
        }
        //小写
        public static string StrToLower(string names)
        {
            return names.ToLower();
        }
        */
        #endregion
        //委托方法实现某种功能
        public static void ProSt(string[] names, DelProSt del)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = del(names[i]);
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}

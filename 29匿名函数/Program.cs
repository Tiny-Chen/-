using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29匿名函数
{
    class Program
    {
        //匿名函数
        //满足某一功能，只调用一次的情况下使用匿名函数
        //匿名函数没有方法名，使用委托关键代替
        //声明的委托 = delegate (参数名){方法体}；    声明的委托（"参数"）；
        //匿名函数的签名要与委托一样
        
        //声明委托
        public delegate void DelSay(string name);
        static void Main(string[] args)
        {
            /*第一种方法实现
            //声明的委托------delegate (参数名)
            DelSay del = delegate(string name)
            {
                //实现的功能（方法体）----------功能单一，只调用一次
                Console.WriteLine("你好" + name);
            };
            */

            //第二种lamda表达式----------匿名函数的简洁写法-----
            //声明的委托 = （参数类型（如果是VOID则不写））=> { 方法体 }；
            DelSay del = (string name) => { Console.WriteLine("你好" + name); };
            
            //调用
            del("张三");
        }
    }
}

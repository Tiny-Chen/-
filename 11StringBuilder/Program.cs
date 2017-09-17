using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11StringBuilder
{
    class Program
    {
        //StringBuilder用于string修改字符使用，比较高效，因为string 会开辟新的空间，而stringbuilder不会，性能较高
        //可以添加任何字符类型进行连接，插入，更改等
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("张三");
            sb.Append("李四");
            sb.Insert(3, "12313");
            sb.Replace("张三", "ggg");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();

        }
    }
}

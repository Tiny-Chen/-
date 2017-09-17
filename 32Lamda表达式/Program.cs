using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32Lamda表达式
{
    class Program
    {
        public delegate void DelOne();

        public delegate void DelTwo(int num);

        public delegate string DelThree(string name);

        static void Main(string[] args)
        {

            DelOne del = () => { }; //delegate() { };

            DelTwo del2 = (int num) => { }; //delegate(int num) { };

            DelThree del3 = (string name) => { return name; }; //delegate(string name) { return name; };

            //例如数组中的条件也可以用表达式表示
            List<int> nums =new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //表达式 n => n>3
            nums.RemoveAll(n => n > 3);

        }
    }
}

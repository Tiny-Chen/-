using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04继承
{
    class Program
    {
        /*
         * 1、解决代码冗余，实现多态，增加代码扩展性，便于维护
         * 2、单根性，一个类只有1个父类
         * 3、传递性，子类的子类也可以继承总的父类的属性和方法
         * 4、子类没有继承父类的构造函数，而是调用父类的无参构造函数
         * 5、父类中如果有带参的构造函数，一是再写一个无参的构造函数，二是在子类用调用父类的构造函数BASE
         */
        static void Main(string[] args)
        {

        }
    }

    //父类
    class Preson
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public char Gender
        {
            get;
            set;
        }

        public void CHLSS()
        {
            Console.WriteLine("吃喝拉菜的");
        }

        /// <summary>
        /// 带参构造函数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Preson(string name,int age,char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }

    class Student:Preson
    {
        //因为父类中有带参构造函数，所以需要调用父类的构造函数
        public Student(string name, int age, char gender, int id) : base(name, age, gender)
        {
            this.ID = id;
        }

        public int ID
        {
            get;
            set;
        }
    }

    class Teach:Preson
    {
        public Teach(string name, int age, char gender, double salary) : base(name, age, gender)
        {
            this.Salary = salary;
        }
        public double Salary
        {
            get;
            set;
        }
    }
}

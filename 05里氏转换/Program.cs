using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05里氏转换
{
    class Program
    {
        /*
         * 1、子类可以赋值给父类
         * 2、如果父类中装的是子类（子类赋值给父类），那么可以将这个父类转换成子类对象，但调用，只能调用父类中的属性和方法、接口
         * 3、as   is  父类转换子类； as转换成功返回对象，失败返回null   子类对象 = 父类 as 子类对象; is转换成功返回true
         * 
         */
        static void Main(string[] args)
        {
            /*
            //子类赋值给父类，父类装的是子类，但调用的属性和方法只能是父类自己的
            Preson preson = new Student("男",15,'女',12345);
            preson.Age = 11;
            //子类创建对象，调用的可以是自己的，也可以是继承父类的
            Student s = new Student("男", 15, '女', 12345);
            s.ID = 1231313;
            */

            //转换
            Preson preson = new Student("男", 15, '女', 12345);
            //父类强转为子类，注意一开始的时候父类装的子对象是谁，那么强转的时候，也是该子类像强转，不能是其他的（teach是转不了的）
            //Student s = (Student) preson;

            //AS转换
            //Student s = preson as Student;

            //is转换
            if (preson is Student)
            {
                Console.WriteLine("OK");
            }
            Console.ReadKey();
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
        public Preson(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }

    class Student : Preson
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

    class Teach : Preson
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象复习
{
    /// <summary>
    /// 类的复习
    /// </summary>
    class Preson
    {
        //字段、属性、构造涵数、方法、接口

        //字段，私有，保护的,外界访问不到的
        private string _name;
        private int _age;
        private char _gender;

        //通过属性访问字段，可以获取和设置属性值，也可以只设置一个值；通过对get或set 的限定可以对字段进行保护
        public string Name
        {
            //get限定
            get
            {
                if (_name != "王五")
                {
                    _name = "王五";
                }
                return _name;
            }
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set
            {
                //set进行限定
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        public char Gender { get => _gender; set => _gender = value; }

        public Preson() { }

        /// <summary>
        /// 有参构造涵数，要注意，除一些特例外，必须要使用public ，因为外部要new对象时，需要构造涵数
        /// 作用是初始化对象
        /// 也可以对字段进行保护（带参）
        /// </summary>
        public Preson(string name,int age,char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        /// <summary>
        /// 带参构造函数,利用构造涵数进行限定
        /// </summary>
        public Preson(char gender):this("",0,gender)
        {
            if (gender != '男')
            {
                this.Gender = '男';
            }
        }
        public void SaHi()
        {
            string Name = "xt";
            //this---代表的是当前对象，this.Name代表就是当前对象的属性，如果不加的话就是字段Name(有多个字段的情况下，一般都加,因为调用的是当前对象的属性)
            Console.WriteLine(this.Name+"----"+Age+ "----" + Gender);
        }
    }
}

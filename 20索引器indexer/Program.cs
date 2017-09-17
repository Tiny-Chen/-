using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20索引器indexer
{
    class Program
    {
        //索引器是一种特殊的属性，可以把对象当做数组来使用，使用[ ]来访问他的成员：例如把班级作为对象C，其中第1个学生C[0]
        //索引器是针对对象（类）来创建的
        //使用索引器方便直接访问数组或集合内的元素，以前P.arr[0],索引器p[0],绕开了中间多余的部分
         
        //索引器定义-------
        // [修饰符] 数据类型 this[索引类型 index] { get{//根据index返回对应的元素}set{//根据index赋值对应的元素}}
        //数据类型(string\int\double....)---就是将要存取的数组或集合的类型
        //索引类型（int\string\...）---就是使用哪种类型的索引来存取数组或集合
        //this索引器的名字，因为索引器不能具有自定义的名字
        //索引使用-----对象名[索引]

         //索引与数组比较
         /*1、索引器的索引值index不受限制，可以是int 可以是string 等
          * 2、索引器可以重载
          * 3、索引器不是变量*/

        //索引器与属性
        /*1、属性以名字来标识，索引器以函数的形式标识
         * 2、索引器可以重载
         * 3、索引器不能是静态的 static*/

        static void Main(string[] args)
        {
            //创建对象
            Preson p = new Preson();
            Student s = new Student();
            //索引使用-------对象名[索引]
            
            //通过索引器给数组赋值set
            p[0] = 10;
            p[1] = 9;
            p[2] = 9;

            s["A001"] = "张三";
            s["A002"] = "李四";
            //通过索引器访问get
            Console.WriteLine(p[0]);
            Console.WriteLine(s["A001"]);
            Console.ReadKey();
        }
    }
    //以整数为下标，对索引器进行存取
    class Preson
    {
        //声明1个整数数组
        private long[] arr = new long[100];
        
        //根据整数数组的类型来声明索引器
        public long this[int index]
        {
            get//获取，返回对应索引值的数组元素
            {
                //设定索引的范围
                if (index < 0 || index > 100)
                {
                    return 0;
                }
                else
                {
                    //如果在索引范围内，返回所取的值
                    return arr[index];
                }
            }
            set//给对应索引值的对象进行赋值
            {
                //在索引范围内赋值
                if (!(index < 0 || index > 100))
                {
                    arr[index]=value;
                }
            }
        }
    }
    //以字符串为下标，对索引器进行存取
    class Student
    {
        //注意----用字符串作下标时，要用Hashtable
        private Hashtable name = new Hashtable();

        //以this关键字定义，这个this就是实例化后的对象
        public string this[string index]
        {
            //get 获取属性，因为索引器获取是对象名[索引值]来获取的，那么对应的索引值要进行转换
            get { return name[index].ToString(); }
            //SET设置值
            set { name.Add(index,value); }
        }
    }
}

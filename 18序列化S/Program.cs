using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _18序列化S
{
    class Program
    {
        //序列化Serializable就是将一个对象的状态（各个属性量）保存起来，然后在适当的时候再获得
        //序列化是这个过程的第一部分，将数据分解成字节流，以便存储在文件中或在网络上传输
        //反序列化就是打开字节流并重构对象。对象序列化不仅要将基本数据类型转换成字节表示，有时还要恢复数据。恢复数据要求有恢复数据的对象实例
        //如果某个类能够被序列化，其子类也可以被序列化。声明为static和transient类型的成员数据不能被序列化。因为static代表类的状态， transient代表对象的临时数据。
        /*一：对象序列化可以实现分布式对象。主要应用例如：RMI要利用对象序列化运行远程主机上的服务，就像在本地机上运行对象时一样。
          二：对象序列化不仅保留一个对象的数据，而且递归保存对象引用的每个对象的数据。
          可以将整个对象层次写入字节流中，可以保存在文件中或在网络连接上传递。利用对象序列化可以进行对象的"深复制"，即复制对象本身及引用的对象本身。
          序列化一个对象可能得到整个对象序列。
         */
        static void Main(string[] args)
        {
            #region 序列化

            //创建对象
            Preson p = new Preson();
            p.Name = "张三";
            p.Age = 20;
            p.Gender = '男';
            //序列化，并通过文件流来保存到文件
            using (FileStream fs = new FileStream(@"C:\Users\Tiny\Desktop\news.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                //使用二进制流进行序列化
                BinaryFormatter bf = new BinaryFormatter();
                //序列化（流，对象）
                bf.Serialize(fs, p);
            }
            #endregion

            #region 反序列化
            //读取序列化后的文件
            //创建接收对象
            Preson ps;
            using (FileStream fs = new FileStream(@"C:\Users\Tiny\Desktop\news.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                //使用二进制流进行反序列化
                BinaryFormatter bf = new BinaryFormatter();
                //反序列化二进制流，并返回对象
                ps = (Preson)bf.Deserialize(fs);
            }
            Console.WriteLine(ps.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
            Console.ReadKey(); 
            #endregion
        }
    }
    /// <summary>
    /// 创建对象（类），标记可以序列化
    /// </summary>
    [Serializable]
    public class Preson
    {
        private string _name;
        private int _age;
        private char _gender;
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public char Gender { get => _gender; set => _gender = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _26删除节点
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建文档
            XmlDocument doc = new XmlDocument();
            //加载文档 
            doc.Load("Preans.xml");
            //获得单个节点Items
            XmlNode xn = doc.SelectSingleNode("/Order/Items");
            //删除节点Items下的元素
            xn.RemoveAll();
            
            doc.Save("Preans.xml");

            Console.WriteLine("删除成功");
            Console.ReadKey();


        }
    }
}

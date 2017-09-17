using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _24读取XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建对象
            XmlDocument doc = new XmlDocument();
            //加载读取的XML文档
            doc.Load("XMLFile1.xml");
            //忽略注释
            XmlReaderSettings rsettings = new XmlReaderSettings();
            rsettings.IgnoreComments = true;
            //获的根节点
            XmlElement root = doc.DocumentElement;
            //获的子节点
            XmlNodeList xnl = root.ChildNodes;

            //打印
            foreach (XmlNode item in xnl)
            {
                Console.WriteLine(item.InnerText);
            }
            
            Console.ReadKey();
        }
    }
}

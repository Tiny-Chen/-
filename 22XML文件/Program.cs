using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _22XML文件
{
    class Program
    {
        //XML主要用来存储数据用，小形的数据库
        //区分大小写，成对出现，类似于html，但不限制标签
        //只能有一个根节点
        static void Main(string[] args)
        {
            //通过代码来创建XML文档
            //1、引用命名空间xml;
            //2、创建XML文档对象
            XmlDocument doc = new XmlDocument();
           
            // XML中  < !--所有的内容都是元素-- >
            //XML中 < !--每一个元素都是节点-- >
            //创建节点信息：第一行，瞄述信息,用来瞄述文档版本，编码等，并保存到文档中
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            //创建根节点---必须要创建根节点，没有根节点不能保存，报错<books></books>
            XmlElement books = doc.CreateElement("books");
            //保存根节点
            doc.AppendChild(books);

            //给根节点创建第1个子节点
            XmlElement book1 = doc.CreateElement("book");
            //添加到根节点
            books.AppendChild(book1);

            //给子节点添加元素内容
            XmlElement name1 = doc.CreateElement("name");
            //给元素标签添加内容
            name1.InnerText = "三国演义";
            //保存到子节点
            book1.AppendChild(name1);

            XmlElement preal1 = doc.CreateElement("preal");
            preal1.InnerText = "80.00";
            book1.AppendChild(preal1);

            XmlElement drc1 = doc.CreateElement("drc");
            drc1.InnerText = "一群人争夺地盘的故事";
            book1.AppendChild(drc1);

            //--------------------------------------------------------
            //创建第2个子节点
            XmlElement book2 = doc.CreateElement("book");
            books.AppendChild(book2);

            XmlElement name2 = doc.CreateElement("name");
            name2.InnerText = "西游记";
            book2.AppendChild(name2);

            XmlElement preal2 = doc.CreateElement("preal");
            preal2.InnerText = "85.00";
            book2.AppendChild(preal2);

            XmlElement drc2 = doc.CreateElement("drc");
            drc2.InnerText = "一个团伙去浪的故事";
            book2.AppendChild(drc2);

            doc.Save("XMLFile1.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();
        }
    }
}

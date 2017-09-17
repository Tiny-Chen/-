using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _23带属性的XML
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 带属性的写法
            /*
            //在元素内容中需要添加标签时使用InnerXml,如在内容前面加<p></p>标签
            //创建XML文档对象
            XmlDocument doc = new XmlDocument();
            //创建节点信息
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            //创建根节点
            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);
            //创建子节点1
            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerText = "刘洋";
            order.AppendChild(customerName);
            //创建子节点2
            XmlElement orderNumber = doc.CreateElement("OrderNumber");
            //在内容前面加<p></p>标签----------InnerXml，如果添加标签使用text的话，会变成转义符
            orderNumber.InnerXml = "<p>bj0000001</p>";
            order.AppendChild(orderNumber);
            //创建子节点3
            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);

            //创建子节点3下的属性节点1
            XmlElement orderItem1 = doc.CreateElement("orderItem");
            orderItem1.SetAttribute("Name", "码表");
            orderItem1.SetAttribute("Count", "10");
            items.AppendChild(orderItem1);

            XmlElement orderlItem2 = doc.CreateElement("orderItem");
            orderlItem2.SetAttribute("Name", "雨衣");
            orderlItem2.SetAttribute("Count", "40");
            items.AppendChild(orderlItem2);

            XmlElement orderlItem3 = doc.CreateElement("OrderItem");
            orderlItem3.SetAttribute("Name", "手套");
            orderlItem3.SetAttribute("Count", "30");
            items.AppendChild(orderlItem3);
            //保存XML文件
            doc.Save("Preans.xml");
            Console.WriteLine("保存成功"); 
            */
            #endregion

            //-----------------------------------------------------------------------------

            //追加XML文档内容
            //建立文档对象
            XmlDocument doc = new XmlDocument();
            //创建根节点
            XmlElement order;
            //判断是否存在文档
            if (File.Exists("Preans.xml"))
            {
                //如果存在,加载XML文件
                doc.Load("Preans.xml");
                //获得根节点
                order = doc.DocumentElement;
            }
            else
            {
               //如果文件不存
               //创建第一行节点信息
                XmlDeclaration xdec = doc.CreateXmlDeclaration("1.0","utf-8",null);
                //创建根节点
                order = doc.CreateElement("Order");
            }

            //追加内容
            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerText = "我是追加的内容";
            order.AppendChild(customerName);

            doc.Save("Preans.xml");
            Console.WriteLine("追加成功");
            Console.ReadKey();
        }
    }
}

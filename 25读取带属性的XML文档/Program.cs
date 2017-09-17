 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Xml;
 using System.Xml.Linq;

namespace _25读取带属性的XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建文档
            XmlDocument doc = new XmlDocument();
            //加载文档
            doc.Load("Preans.xml");
            //XPATH---方法去找到Items下的的节点列表属性orderItem
            XmlNodeList xnl = doc.SelectNodes("/Order/Items/orderItem");

            foreach (XmlNode node in xnl)
            {
                //获的节点属性
                Console.WriteLine(node.Attributes["Name"].Value);
                Console.WriteLine(node.Attributes["Count"].Value);
            }

            Console.ReadKey();
        }
    }
}

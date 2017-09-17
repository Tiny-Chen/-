using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _09字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string s1 = "1234";
            //string.IsNullOrEmpty();判断字符串是否为空或null,返回布尔值
            if (string.IsNullOrEmpty(s1))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            //length//字符长度
            int n1 = s1.Length;
            //拿到第1个值，注意string是只读的，不能改变,要转成字符串数组
            char c1 = s1[0];
            //改变字符，通过转换实现，ToCharArray()转换成字符数组
            char[] c2 = s1.ToCharArray();
            c2[0] ='q';
            string s = new string(c2);

            //转换小写：ToLower(),大写ToUpper()

            //Equals(),比较字符串是否相同,StringComparison.OrdinalIgnoreCase忽略大小写
            string s2 = "CCC";
            String s3 = "ccc";
            if (s2.Equals(s3,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("相同");
            }
            else
            {
                Console.WriteLine("不相同");
            }
            //Contains,是否包含

            //IndexOf()从前查找对应的数据，如果没有返回-1

            //LasindexOf()从后往 前找数据，如果没有返回-1

            //Substring()//d截取字符串
            string s4 = "123456";
            string ss4 = s4.Substring(0,1);//从0位开始截取1个
            //Split()//分割字符串,返回字符串数组，StringSplitOptions.RemoveEmptyEntries移除空字符
            string s5 = "123,,,    ,,,abc,,,,,345------";
            string[] new5 =s5.Split(new char[] {',', ' ', '-'},StringSplitOptions.RemoveEmptyEntries);
            //Join()   //插入字符
            string[] names = {"1", "2", "2", "asdasd"};
            string new4 = string.Join("|", names);
            string new3 = string.Join("|",1,'c',true,33,3.33);
            //Replace()      替换
            string str1 = "12345";
            string news1 = str1.Replace("1", "**");
            //Trim();      移除两端空格

             */

            //反转 abc  def  ghi      -----  cba   fed  ihg

            string str = "abc  def  ghi";
            string[] newStr = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(newStr[2]);
            string strs1 = null;
            for (int i = 0; i <= newStr.Length-1; i++)
            {
                string ss = GetStr(newStr[i]);
                strs1 += ss + " ";
            }
            Console.Write(strs1);
            Console.ReadKey();
        }

        public static string GetStr(string str)
        {
            char[] chs = str.ToCharArray();
            for (int i = 0; i < chs.Length/2; i++)
            {
                char temp = chs[i];
                chs[i] = chs[chs.Length - i - 1];
                chs[chs.Length - i - 1] = temp;
            }
            return new string(chs);
        }
    }
}

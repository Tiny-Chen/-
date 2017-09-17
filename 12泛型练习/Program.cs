using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12泛型练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1

            //分出奇偶数,取出奇数放到新数组中，然后再做一个奇数在左偶数在右的集合
            //int[] num = {1, 2, 3, 4, 5, 6, 7, 8, 9};

            //List<int> n1 = new List<int>();
            //List<int >n2 = new List<int>();
            //List<int >n3 = new List<int>();
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] % 2 != 0)
            //    {
            //        n1.Add(num[i]);
            //    }
            //    else
            //    {
            //        n2.Add(num[i]);
            //    }
            //}
            //int[] newNum = n1.ToArray();
            //for (int i = 0; i < newNum.Length; i++)
            //{
            //    Console.WriteLine(newNum[i]);
            //}
            //n1.AddRange(n2);
            //foreach (var va in n1)
            //{
            //    Console.WriteLine(va);
            //}

            //Console.ReadKey();
            #endregion

            #region 练习2
            //练习2
            //从一个整数LIST中找出最大数
            //List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int max = num[0];
            //for (int i = 0; i < num.Count; i++)
            //{
            //    if (num[i] > max)
            //    {
            //        max = num[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.ReadKey(); 
            #endregion

            #region 练习3
            ////练习3
            ////按用户输入123，打印出一二三，
            //string str = "1一 2二 3三 4四 5五 6六 7七 8八 9九";
            //Dictionary<char,char> dic = new Dictionary<char, char>();
            //string[] newStr =str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            ////"1一"需再分开,得到键和值
            //for (int i = 0; i <newStr.Length; i++)
            //{
            //   dic.Add(newStr[i][0],newStr[i][1]);
            //}
            ////测试是否有数据
            //foreach (KeyValuePair<char,char> kv in dic)
            //{
            //    Console.WriteLine("{0}-----{1}",kv.Key,kv.Value);
            //}
            //Console.WriteLine("请输入1-9的数字");
            //string s1 =Console.ReadLine();
            //for (int i = 0; i < s1.Length; i++)
            //{
            //    if (dic.ContainsKey(s1[i]))//ContainsKey是否包含
            //    {
            //        Console.WriteLine(dic[s1[i]]+" ");
            //    }
            //    else
            //    {
            //        Console.WriteLine(s1[i]);
            //    }
            //}

            //Console.ReadKey(); 
            #endregion

            #region 练习4
            ////计算字符串中每种字符出现的次数,不区分大小写ContainsKey,是否包含
            //string str = "Welcome to Chinaworld";
            //str =str.ToLower();
            //Dictionary<char,int> dic = new Dictionary<char, int>();

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == ' ')
            //    {
            //        continue;
            //    }
            //    if (dic.ContainsKey(str[i]))
            //    {
            //        //如果包含这个键，那么值++
            //        dic[str[i]]++;
            //    }
            //    else
            //    {
            //        //没有包含这个键，添加值
            //        dic[str[i]] = 1;
            //    }
            //}
            //foreach (KeyValuePair<char,int> kv in dic)
            //{
            //    Console.WriteLine("字母{0}，次数{1}",kv.Key,kv.Value);
            //}
            //Console.ReadKey(); 
            #endregion

            #region 练习5
            //实现两个集合合并，去掉重复项
            //List<int> listOne =new List<int>() {1, 2, 3, 4, 5, 6, 7, 8};
            //List<int> listTwo = new List<int>() { 3,6,8,9,10,1,4,11 };
            ////使用包含字段来判断
            //for (int i = 0; i < listTwo.Count; i++)
            //{
            //    if (!listOne.Contains(listTwo[i]))
            //    {
            //        listOne.Add(listTwo[i]);
            //    }
            //}
            //foreach (var item in listOne)
            //{
            //    Console.Write(item+"  ");
            //}
            //Console.ReadKey(); 
            #endregion
        }
    }
}

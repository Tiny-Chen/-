using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象模拟打开文件
{
    /// <summary>
    /// 简单工厂
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 简单工厂抽象模式，不知道客户需要什么，所以把父类给对象，父类里头装的是子类，根据客户的需求给出子类，表面调的是父类，实际已被子类重写
             */
            Console.WriteLine("请选择要进入的磁盘");
            string path = Console.ReadLine();
            Console.WriteLine("请选要打开的文件");
            string fileName = Console.ReadLine();
            //全路径=path+fileName
            string fullPath = path + fileName;

            //创建实例
            FileFather ff = GitFile(fileName, fullPath);
            ff.OpenFlie();
            Console.ReadKey();
        }

        /// <summary>
        /// 打开文件的方法
        /// </summary>
        /// <param name="fileName">打开的文件名</param>
        /// <param name="fullPath">全路径</param>
        /// <returns></returns>
        public static FileFather GitFile(string fileName,string fullPath)
        {
            //根据文件名获取扩展名，使用path.GetExtension(文件名)
            string extension = Path.GetExtension(fileName);
            //创建父类对象
            FileFather ff = null;
            //根据扩展名去把父类转换子类对象
            switch (extension)
            {
                case ".txt":ff = new TextFile(fullPath);
                    break;
                case ".jpg":ff = new JpgFile(fullPath);
                    break;
            }
            return ff;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21单例模式
{
    class Preson
    {
        //创建单例字段，必须是静态的，因为外部是通过静态的属性来访问的，静态属性只能访问静态的字段；
        //全局维一的代表对象
        private static Preson presonSingle=null;
        /// <summary>
        /// 私有化构造函数
        /// </summary>
        private Preson()
        {
            
        }
        //提供1个静态方法，返回1个对象
        public static Preson GetSingle()
        {
            //判断是否为空，即是否第1次，如果第1次则创建对象，如果有了，返回创建过的对象
            if (presonSingle == null)
            {
                presonSingle = new Preson();
            }
            return presonSingle;
        }

        private string _name;
        private int _age;
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

     
    }
}

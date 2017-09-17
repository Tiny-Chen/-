using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07移动存储练习
{
    /// <summary>
    /// 移动设备父类
    /// </summary>
   public abstract class UsbContorl
    {
        public abstract void Read();

        public abstract void Write();

       
    }
}

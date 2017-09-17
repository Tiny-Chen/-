using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07移动存储练习
{
    class MP3 : UsbContorl
    {
        public override void Read()
        {
            Console.WriteLine("Mp3在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3在写入数据");
        }
        public void Play()
        {
            Console.WriteLine("Play");
        }
    }
}

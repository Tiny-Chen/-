using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象模拟打开文件
{
    /// <summary>
    /// 打开类型为图片文件
    /// </summary>
    class JpgFile:FileFather
    {
        public JpgFile(string fileName) : base(fileName)
        {
            
        }
        public override void OpenFlie()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.fileName);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06多态
{
    /// <summary>
    /// 减法
    /// </summary>
    class Sub : CalFather
    {
        public Sub(int numberOne, int numberTwo) : base(numberOne, numberTwo)
        {
        }

        public override double GetResut()
        {
            return NumberOne - NumberTwo;
        }
    }
}

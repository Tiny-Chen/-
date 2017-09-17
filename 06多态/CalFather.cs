using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06多态
{
    /// <summary>
    /// 运算父类
    /// </summary>
    abstract class CalFather
    {
        //传入的参数字段
        private int _numberOne;
        private int _numberTwo;

        //属性
        public int NumberOne { get => _numberOne; set => _numberOne = value; }
        public int NumberTwo { get => _numberTwo; set => _numberTwo = value; }

        //构造方法
        public CalFather(int numberOne, int numberTwo)
        {
            this.NumberOne = numberOne;
            this.NumberTwo = numberTwo;
        }

        public abstract double GetResut();
    }
}

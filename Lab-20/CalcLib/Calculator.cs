using CalcLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    public class Calculator : ICalculator
    {

        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public int Sub(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
    }
}


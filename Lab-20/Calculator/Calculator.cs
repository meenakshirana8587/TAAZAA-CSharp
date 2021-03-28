using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator : ICalculator
    {

        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public int Sum(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }
}


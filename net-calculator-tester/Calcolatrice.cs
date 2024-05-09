using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public class Calcolatrice
    {
        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float Substract(float num1, float num2)
        {
            return num1 - num2;
        }

        public static float Divide(float num1, float num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
            {
                throw new Exception("Non puoi dividere per zero");
            }
        }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}

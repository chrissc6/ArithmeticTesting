using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticTesting
{
    public class Arithmetic
    {
        public static int Sqr(int nbr)
        {
            if(nbr < 10 || nbr > 100)
            {
                throw new Exception("Number not valid, or out of range");
            }

            return (nbr * nbr);
        }

        //Range for add, sub, mul, div
        //is -51< x <51

        public static int Add(int op1, int op2)
        {
            CheckRange(op1, op2);
            return op1 + op2;
        }

        public static int Sub(int op1, int op2)
        {
            CheckRange(op1, op2);
            return op1 - op2;
        }

        public static int Mul(int op1, int op2)
        {
            CheckRange(op1, op2);
            return op1 * op2;
        }

        public static int Div(int op1, int op2)
        {
            if ((op1 < -50 || op1 > 50) || (op2 < -50 || op2 > 50) ||  op2 == 0)
            {
                throw new Exception("Number not valid, or out of range");
            }
            return op1 / op2;
        }

        public static void CheckRange(int op1, int op2)
        {
            if ((op1 < -50 || op1 > 50) || (op2 < -50 || op2 > 50))
            {
                throw new Exception("Number not valid, or out of range");
            }
        }
    }
}

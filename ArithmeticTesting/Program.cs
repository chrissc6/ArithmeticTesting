using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            TestInvalid(1, -127);
            TestInvalid(2, 9);
            TestValid(3, 10, 100);
            TestValid(4, 11, 121);
            TestValid(5, 53, 2809);
            TestValid(6, 99, 9801);
            //TestValid(7, 100, 100 * 100); different way
            TestValid(7, 100, 10000);
            TestInvalid(8, 101);
            TestInvalid(9, 1347);

        }

        static void TestInvalid(int id, int nbr)
        {
            //test -127
            try
            {
                var result = Arithmetic.Sqr(nbr);
                Console.WriteLine($"Test #{id} fail-1");
            }
            catch (Exception)
            {
                Console.WriteLine($"Test #{id} pass");
            }
        }

        static void TestValid(int id, int nbr, int expected)
        {
            try
            {
                var actual = Arithmetic.Sqr(nbr);
                if(actual == expected)
                {
                    Console.WriteLine($"Test #{id} pass");
                }
                else
                {
                    Console.WriteLine($"Test #{id} fail-2");
                    //Console.WriteLine($"Test #{id} fail-2. Expected {nbr*nbr} - Actual {result}");
                }
            }
            catch(Exception)
            {
                Console.WriteLine($"Test #{id} fail-1");
            }
        }
    }
}
/*
 * static void Main(string[] args)
        {
            //TestInvalid(-127);
            Console.WriteLine($"Test #1 { TestInvalid(-127)}");
            
        }

        static string TestInvalid(int nbr)
        {
            string x;
            //test -127
            try
            {
                var result = Arithmetic.Sqr(nbr);
                return x = "Failed";
                //Console.WriteLine("Test #1 fail");
            }
            catch (Exception)
            {
                return x = "Pass";
                //Console.WriteLine("Test #1 pass");
            }
        }
*/
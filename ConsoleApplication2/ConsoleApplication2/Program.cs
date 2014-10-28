using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAgeDoubled = Doubleit(25);
            Console.WriteLine(Doubleit(myAgeDoubled));
            HelloWorld();
            Console.ReadKey();
        }
        static void HelloWorld()
        {
            //write Hello World to console
            Console.WriteLine("Hello World");

        }
        static int Doubleit(int someNumber)
        {
            return someNumber * 2;
        }

        static void LoopSomeNum(int startNum, int endNum)
        {for (int i = startNum; i <= endNum; i++);
            
                Console.WriteLine(i);
        }
            
            }
        }
        static void LoopTests()
        {
            LoopSomeNum(5, 10);
            LoopSomeNum(1253, 12315);
        }


    }
    
    
}

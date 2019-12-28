using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = 0;
            int x = 50;
            int y = 40;
            result = addXandY(x, y);
            Console.WriteLine(result);
            Console.WriteLine( );
            addYtoX(ref x, ref y);
            Console.WriteLine(x);
        }
       public static int addXandY(int firstNumber,int secondNumber)
       {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;
       }
        /// <summary>
        /// Simple method to demonstrate pass by reference with ref keyword
        /// 
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        public static int addYtoX(ref int X, ref int Y)
        {
            X += Y;
            return X;
        }
    }
}

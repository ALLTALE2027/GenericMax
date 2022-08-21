using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaximum
{
    internal class MaxNormal
    {
        public static void PrintMax(params int[] array)
        {
            int maxNum = array[0];
            foreach (int number in array)
            {
                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
            Console.WriteLine("max number is: " + maxNum);
            Console.WriteLine("---------------------------------");

        }

        public static void PrintMax(params float[] array)
        {
            float maxNum = array[0];
            foreach (float number in array)
            {
                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
            Console.WriteLine("max number is: " + maxNum);
            Console.WriteLine("---------------------------------");


        }

        public static void PrintMax(params string[] array)
        {
            string maxString = array[0];
            int maxLength = maxString.Length;

            foreach (string element in array)
            {
                if (element.Length > maxLength)
                {
                    maxLength = element.Length;
                    maxString = element;
                }

            }
            Console.WriteLine("Max string: " + maxString);
            Console.WriteLine("---------------------------------");

        }
    }
}

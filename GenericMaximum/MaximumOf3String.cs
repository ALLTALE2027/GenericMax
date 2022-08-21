using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaximum
{
    internal class MaximumOf3String
    { 
        internal static void PrintMax(string[] array)
        {
            string max;
            max = array[0].Length > array[1].Length ? (array[0].Length > array[2].Length ? array[0] : array[2]) : (array[1].Length > array[2].Length ? array[1] : array[2]);
            Console.WriteLine("Largest strings from {0}, {1}, {2} is: {3}", array[0], array[1], array[2], max);
        }
    }
}

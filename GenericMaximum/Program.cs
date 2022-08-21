namespace GenericMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Maximum program!!!");

            //UC1
            //Console.WriteLine("Find Maximum of 3 float numbers");
            //int input;
            //int[] intArray = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter {0} number", i + 1);
            //    input = int.Parse(Console.ReadLine());
            //    intArray[i] = input;
            //}
            //IntMax3.PrintMax(intArray);


            //UC2
            //Console.WriteLine("Find Maximum of 3 float numbers");
            //float input;
            //float[] floatArray = new float[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter {0} number", i + 1);
            //    input = float.Parse(Console.ReadLine());
            //    floatArray[i] = input;
            //}
            //MaximumOfFloat.PrintMax(floatArray);


            // UC3
            Console.WriteLine("Find Maximum of String");
            string input;
            string[] stringArray = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter {0} string", i + 1);
                input = Console.ReadLine();
                stringArray[i] = input;
            }
            MaximumOf3String.PrintMax(stringArray);



        }
    }
}
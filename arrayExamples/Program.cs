using System;
using System.Linq;

namespace arrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //първи начин за четене и печатане на масив
            /*int[] intArray = new int[5];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + ", ");
            }*/

            // !! втори начин за четене и печатане на масив !!!
            int[] intArray2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(", ", intArray2));

            double[] doubleArray = Console.ReadLine().Split(',').Select(double.Parse).ToArray();

            string[] stringArray = Console.ReadLine().Split().ToArray();
            Console.WriteLine(string.Join(" - ", stringArray));
        }
    }
}

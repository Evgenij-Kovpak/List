using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    

    class LargestX
    {
        static void Main(string[] args)
        {

            int[] input = { 12, 9, 5, 4, 3, 2, 0};
            List<int> numbers = new List<int>(input);
            
            foreach (int number in numbers)
            {

                Console.WriteLine(number);
            }

            Console.WriteLine("\n удаляем элементы(3, 4)");

            numbers.RemoveRange(3, 4);

            Console.WriteLine();

            foreach (int number in numbers)

            {

                Console.WriteLine(number);

            }

            Console.WriteLine("\n Сортируем список");
            numbers.Sort();
            Console.WriteLine();
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

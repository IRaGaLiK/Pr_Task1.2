using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr_Task1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> a = new List<int>() { 1, 4, 6 };
            List<int> b = new List<int>() { 11, 33, 22 };


            List<Tuple<int, int>> tuples = a.Zip(b, (x, y) => Tuple.Create(x, y)).ToList();


            tuples.Sort((x, y) => y.Item2.CompareTo(x.Item2));


            a = tuples.Select(x => x.Item1).ToList();

            Console.WriteLine("Отсортированный список a:");
            foreach (int element in a)
            {
                Console.WriteLine(element);


            }
            Console.ReadKey();

        }
    }
}

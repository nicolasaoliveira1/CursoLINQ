using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class5
{
    public static class LinqAverage
    {
        public static void ExampleAverageInt(int[] array)
        {
            if (array.IsNullOrEmpty())
                return;

            double average = array.Average();
            Console.WriteLine($"Média da coleção de inteiros: {average}");
        }
        public static void ExampleAveragePerson(Person[] people)
        {
            if (people.IsNullOrEmpty())
                return;

            double average = people.Average(a => a.Id);
            Console.WriteLine($"Média da coleção de inteiros: {average}");
        }
    }
}
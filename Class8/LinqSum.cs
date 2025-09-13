using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class8
{
    public static class LinqSum
    {
        public static void ExampleSumInt(int[] array)
        {
            int sum = array.Sum();
            Console.WriteLine($"Soma de todos os registro da coleção de inteiros: {sum}");
        }
        public static void ExampleSumPerson(Person[] people)
        {
            int sum = people.Sum(a => a.Id);
            Console.WriteLine($"Soma de todos ids da coleção de pessoas: {sum}");
        }
    }
}
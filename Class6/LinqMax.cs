using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class6
{
    public static class LinqMax
    {
        public static void ExampleMaxInt(int[] array)
        {
            int max = array.Max();
            Console.WriteLine($"Maior registro da coleção de inteiros: {max}");
        }
        public static void ExampleMaxPerson(Person[] people)
        {
            int max = people.Max(a => a.Id);
            Console.WriteLine($"Maior identificador da coleção de pessoas: {max}");
        }
    }
}
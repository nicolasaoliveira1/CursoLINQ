using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class7
{
    public static class LinqMin
    {
        public static void ExampleMinInt(int[] array)
        {
            int min = array.Min();
            Console.WriteLine($"Menor registro da coleção de inteiros: {min}");
        }
        public static void ExampleMinPerson(Person[] people)
        {
            int min = people.Min(a => a.Id);
            Console.WriteLine($"Maior identificador da coleção de pessoas: {min}");
        }
    }
}
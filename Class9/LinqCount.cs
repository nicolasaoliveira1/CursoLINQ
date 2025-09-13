using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class9
{
    public static class LinqCount
    {
        public static void ExampleCount(Person[] people)
        {
            int count = people.Count();
            Console.WriteLine($"Quantidade de registros da coleção de pessoas: {count}");
        }
        public static void ExampleCountIdsGreaterThanValue(Person[] people, int value)
        {
            int count = people.Count(c => c.Id > value);
            Console.WriteLine($"Quantidade de ids maiores que {value} da coleção de pessoas: {count}");
        }
    }
}
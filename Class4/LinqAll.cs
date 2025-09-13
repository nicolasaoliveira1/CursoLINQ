using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;

namespace LINQ.Class4
{
    public static class LinqAll
    {
        public static void ExampleAllIdsGreaterThanValue(Person[] people, int value)
        {
            if (people.All(a => a.Id > value))
            {
                Console.WriteLine($"Todos os ids na coleção são maiores que {value}");
            }

        }
         public static void ExampleAllNamesIsNotNullOrWhiteSpace(Person[] people)
        {
            if (people.All(a => !string.IsNullOrWhiteSpace(a.Name)))
            {
                Console.WriteLine($"Todos os names na coleção estão preenchidos");
            }

        }
    }
}
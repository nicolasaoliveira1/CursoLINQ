using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class16
{
    public static class LinqContains
    {
        public static void ExampleContainsInt(int[] array, int value)
        {
            if (array.Contains(value))
            {
                Console.WriteLine($"O valor {value} foi encontrado na coleção de inteiros");

            }
            else
            {
                Console.WriteLine($"O valor {value} NÃO foi encontrado na coleção de inteiros");
            }
        }

        public static void ExampleContainsPeople(Person[] people, int[] ids)
        {
            bool exists = people.Any(a => ids.Contains(a.Id));
            if (exists)
                Console.WriteLine("A coleção de pessoas possui ao menos 1 registro dentro dos ids informados");
            else
                Console.WriteLine("A coleção de pessoas NÃO possui nenhum registro dentros dos ids informados");
        }

        public static void ExampleContainsPeopleWithIds(Person[] people, int[] ids)
        {
            IEnumerable<Person> filteredPeople = people.Where(w => ids.Contains(w.Id));
            Console.WriteLine($"Nova coleção de pessoas pelos ids informados:\n{string.Join("\n", filteredPeople.Select(s => s.Name))}");
        }
    }
}
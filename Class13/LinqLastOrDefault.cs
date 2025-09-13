using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class13
{
    public static class LinqLastOrDefault
    {
        public static void ExampleLastOrDefault(Person[] people)
        {
            Person person = people.LastOrDefault();

            if (person == null)
                Console.WriteLine("Não foi encontrada nenhuma pessoa");
            else
                Console.WriteLine($"Último registro da coleção de pessoas: {person.Name}");
        }

        public static void ExampleLastOrDefaultIdGreaterThanValue(Person[] people, int value)
        {
            Person person = people.LastOrDefault(f => f.Id > value);

            if (person == null)
                Console.WriteLine("Não foi encontrada nenhuma pessoa");
            else
                Console.WriteLine($"Último registro da coleção de pessoas maior que {value}: {person.Name}");
        }

        public static void ExampleLastOrDefaultWithoutError(Person[] people)
        {
            Person person = people.LastOrDefault(f => f.Id > 20);
            if (person == null)
            {
                Console.WriteLine("Não foi encontrada nenhuma pessoa com id maior que 20");
            }
        }

    }
}
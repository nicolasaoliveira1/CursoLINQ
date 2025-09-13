using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class11
{
    public static class LinqFirstOrDefault
    {
        public static void ExampleFirstOrDefault(Person[] people)
        {
            Person person = people.FirstOrDefault();

            if (person == null)
                Console.WriteLine("Não foi encontrada nenhuma pessoa");
            else
                Console.WriteLine($"Primeiro registro da coleção de pessoas: {person.Name}");
        }

        public static void ExampleFirstOrDefaultIdGreaterThanValue(Person[] people, int value)
        {
            Person person = people.FirstOrDefault(f => f.Id > value);

            if (person == null)
                Console.WriteLine("Não foi encontrada nenhuma pessoa");
            else
                Console.WriteLine($"Primeiro registro da coleção de pessoas maior que {value}: {person.Name}");
        }

        public static void ExampleFirstOrDefaultWithoutError(Person[] people)
        {
            Person person = people.FirstOrDefault(f => f.Id > 20);

            if (person == null)
            {
                Console.WriteLine("Não foi encontrada nenhuma pessoa com id maior que 20");
            }
        }
    }
}
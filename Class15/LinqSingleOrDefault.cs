using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class15
{
    public static class LinqSingleOrDefault
    {
        public static void ExampleSingleOrDefault(Person[] people)
        {
            if (people.Length == 1)
            {
                Person person = people.SingleOrDefault();
                Console.WriteLine($"único elemento da coleção de pessoas: {person.Name}");
            }
        }

        public static void ExampleSingleOrDefaultWithIdEqualsToValue(Person[] people, int value)
        {
            Person person = people.SingleOrDefault(s => s.Id == value);

            if (person == null)
                Console.WriteLine("Não foi encontrado nenhum registro em pessoas");
            else
                Console.WriteLine($"Único elemento da coleção de pessoas com id {value}: {person.Name}");
        }
    }
}
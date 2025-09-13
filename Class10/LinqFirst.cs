using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class10
{
    public static class LinqFirst
    {
        public static void ExampleFirst(Person[] people)
        {
            if (people.IsNullOrEmpty())
                return;

            Person person = people.First();
            Console.WriteLine($"Primeiro registro da coleção de pessoas: {person.Name}");
        }
        public static void ExampleFirstIdGreaterThanValue(Person[] people, int value)
        {
            Person person = people.First(f => f.Id > value);
            Console.WriteLine($"Primeiro registro da coleção de pessoas maior que {value}: {person.Name}");
        }
        public static void ExampleFirstWithError(Person[] people)
        {
            Person person = people.First(f => f.Id > 20);
        }
    }
}
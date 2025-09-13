using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class12
{
    public static class LinqLast
    {
        public static void ExampleLast(Person[] people)
        {
            if (people.IsNullOrEmpty())
                return;

            Person person = people.Last();
            Console.WriteLine($"Último registro da coleção de pessoas: {person.Name}");
        }

        public static void ExampleLastIdGreaterThanValue(Person[] people, int value)
        {
            if (people.IsNullOrEmpty())
                return;

            Person person = people.Last(l => l.Id > value);
            Console.WriteLine($"Último registro da coleção de pessoas maior que {value}: {person.Name}");
        }
    }
}
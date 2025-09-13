using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class14
{
    public static class LinqSingle
    {
        public static void ExampleSingle(Person[] people)
        {
            if (people.Length == 1)
            {
            Person person = people.Single();
            Console.WriteLine($"Único elemento da coleção de pessoas: {person.Name}");
            }
        }
        public static void ExampleSingleWithIdEqualsToValue(Person[] people, int value)
        {
            Person person = people.Single(s => s.Id == value);
            Console.WriteLine($"Único elemento da coleção de pessoas com id {value}: {person.Name}");
        }
    }
}
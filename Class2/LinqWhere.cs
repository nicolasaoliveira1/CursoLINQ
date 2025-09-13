using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;

namespace LINQ.Class2
{
    public static class LinqWhere
    {
        public static void ExampleWhereIdsGreaterThanValue(Person[] people, int value)
        {
            IEnumerable<Person> newPeople = people.Where(w => w.Id > value);

            Console.WriteLine($"Ids maiores do que {value}: {string.Join(", ", newPeople.Select( s => s.Id)) }");
        }
        public static void ExampleWhereNameContainsValue(Person[] people, string value)
        {
            var names = people.Where(w => w.Name.Contains(value)).Select(s => s.Name);
            Console.WriteLine($"Nomes que contém {value}: { string.Join(", ", names) }");
        }
    }
}
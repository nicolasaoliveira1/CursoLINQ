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

            Console.WriteLine($"Ids maiores do que {value}: {string.Join(", ", newPeople.Select(s => s.Id))}");
        }
        public static void ExampleWhereNameContainsValue(Person[] people, string value)
        {
            var names = people.Where(w => w.Name.Contains(value)).Select(s => s.Name);
            Console.WriteLine($"Nomes que contém {value}: {string.Join(", ", names)}");
        }

        public static void ExampleWhereFilterWithWhereSelect(Person[] people, int value)
        {
            // usa 3 loops -> performance pior  - 255.10 ns

            foreach (var Person in people.Where(w => w.Id > value).Select(s => s.Id))
            {
                // Lógica
            }
        }

        public static void ExampleWhereFilterWithLoop(Person[] people, int value)
        {
            //performance melhor! - 37.97 ns

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Id > value)
                {
                    // Lógica
    
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class19
{
    public static class LinqGroupBy
    {
        public static void ExampleGroupByOneKey(Person[] people)
        {
            var groupedPeople = people.OrderBy(o => o.Course).GroupBy(g => g.Course);

            Console.WriteLine($"Total de grupos: {groupedPeople.Count()}\n");

            foreach (var group in groupedPeople)
            {
                Console.WriteLine($"Curso de {group.Key} - Total de pessoas: {group.Count()}");
                foreach (var person in group)
                {
                    Console.WriteLine($"\tId: {person.Id} - Nome: {person.Name} - Sexo: {person.Gender} - Curso: {person.Course}");

                }
            }
        }
        public static void ExampleGroupByComposedKey(Person[] people)
        {
            var groupedPeople = people.OrderBy(o => o.Course).ThenBy(o => o.Gender).GroupBy(g => new
            {
                g.Course,
                g.Gender
            });

            Console.WriteLine($"Total de grupos: {groupedPeople.Count()}\n");

            foreach (var group in groupedPeople)
            {
                Console.WriteLine($"Curso de {group.Key.Course} - Sexo: {group.Key.Gender} - Total de pessoas: {group.Count()}");
                foreach (var person in group)
                {
                    Console.WriteLine($"\tId: {person.Id} - Nome: {person.Name} - Sexo: {person.Gender}");

                }
            }
        }
    }
}
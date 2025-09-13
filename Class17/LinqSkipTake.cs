using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class17
{
    public static class LinqSkipTake
    {
        public static void ExampleSkip(Person[] people, int count)
        {
            var nextPeople = people.Skip(count);
            Console.WriteLine($"Pessoas pulando {count} registros: {string.Join(", ", nextPeople.Select(s => s.Name))}");
        }

        public static void ExampleTake(Person[] people, int count)
        {
            var nextPeople = people.Take(count);
            Console.WriteLine($"{count} pessoas selecionadas: {string.Join(", ", nextPeople.Select(s => s.Name))}");
        }

        public static void ExamplePagination(Person[] people, int currentPage, int pageSize)
        {
            var paginatedPeople = people.Skip(currentPage * pageSize).Take(pageSize);
            Console.WriteLine($"Página {currentPage + 1}: {string.Join(", ", paginatedPeople.Select(s => s.Name))}");
        }

    }
}
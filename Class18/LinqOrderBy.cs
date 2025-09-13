using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class18
{
    public static class LinqOrderBy
    {
        public static void ExampleOrderBy(int[] array)
        {
            var orderedArrayDesc = array.OrderByDescending(o => o);
            Console.WriteLine($"Coleção de inteiros ordenada decrescente: {string.Join(", ", orderedArrayDesc)}");
            var orderedArray = orderedArrayDesc.OrderBy(o => o);
            Console.WriteLine($"Coleção de inteiros ordenada crescente: {string.Join(", ", orderedArray)}");
        }
        public static void ExampleOrderByRandomPerson(Person[] people)
        {
            Console.WriteLine($"Coleção de pessoas desordenada: {string.Join(", ", people.Select(s => s.Name))}");
            var orderedPeople = people.OrderBy(o => o.Id);
            Console.WriteLine($"Coleção de pessoas ordenada: {string.Join(", ", orderedPeople.Select(s => s.Name))}");
        }
    }
}
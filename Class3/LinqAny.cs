using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;

namespace LINQ.Class3
{
    public static class LinqAny
    {
        public static void ExampleAnyIdEven(Person[] people)
        {
            if (people.Any(a => a.Id % 2 == 0))
            {
                Console.WriteLine("Existem identificadores pares na coleção");
            }

        }
        public static void ExampleAnyEmptyName(Person[] people)
        {
            if (people.Any(a => string.IsNullOrWhiteSpace(a.Name)))
            {
                Console.WriteLine("Existem nomes vazios na nossa coleção");
            }

        }
        public static void ExampleAnyCollectionIsEmpty(Person[] people)
        {
            if (people == null || !people.Any())
            {
                Console.WriteLine("A coleção está vazia");
            }
        }
    }
}
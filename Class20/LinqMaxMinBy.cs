using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class20
{
    public static class LinqMaxMinBy
    {
        public static void ExampleOldSmallestId(Person[] people)
        {
            Person smallest = people.OrderBy(o => o.Id).First();
            // Console.WriteLine($"Menor id da forma antiga: {smallest.Id}");
        }
        public static void ExampleOldBiggestId(Person[] people)
        {
            Person biggest = people.OrderByDescending(o => o.Id).First();
            // Console.WriteLine($"Maior id da forma antiga: {biggest.Id}");
        }

        public static void ExampleNewSmallestId(Person[] people)
        {
            Person smallest = people.MinBy(m => m.Id);
            // Console.WriteLine($"Menor id da forma nova: {smallest.Id}");
        }
        public static void ExampleNewBiggestId(Person[] people)
        {
            Person biggest = people.MaxBy(m => m.Id);
            // Console.WriteLine($"Maior id da forma nova: {biggest.Id}");
        }
        
    }
}
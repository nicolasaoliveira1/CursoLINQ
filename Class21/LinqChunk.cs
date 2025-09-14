using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class21
{
    public static class LinqChunk
    {
        public static void ExampleOldChunk(Person[] people, int chunkSize)
        {
            var chunks = people.Select((person, index) => new
            {
                Index = index,
                Person = person
            })
                    .GroupBy(g => g.Index / chunkSize)
                    .Select(s => s.Select(p => p.Person));

        }
        public static void ExampleNewChunk(Person[] people, int chunkSize)
        {
            var chunks = people.Chunk(chunkSize);

        }
    }
}
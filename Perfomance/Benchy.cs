using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using LINQ.Class11;
using LINQ.Class2;
using LINQ.Class20;
using LINQ.Class21;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Performance
{
    public class Benchy
    {
        const int _size = 100;
        static readonly Person[] _people = new Person[_size];

        public Benchy()
        {
            for (int i = 0; i < _people.Length; i++)
            {
                int id = i + 1;

                _people[i] = new Person
                {
                    Id = id,
                    Name = $"Pessoa {id}"
                };
            }
        }

        // [Benchmark]
        // public void OldGetSmallestAndBiggestId()
        // {
        //     LinqMaxMinBy.ExampleOldSmallestId(_people);
        //     LinqMaxMinBy.ExampleOldBiggestId(_people);
        // }

        // [Benchmark]
        // public void NewGetSmallestAndBiggestId()
        // {
        //     LinqMaxMinBy.ExampleNewSmallestId(_people);
        //     LinqMaxMinBy.ExampleNewBiggestId(_people);
        // }

        // [Benchmark]
        // public void OldChunk()
        // {
        //     LinqChunk.ExampleOldChunk(_people, 10);
        // }
        // [Benchmark]
        // public void NewChunk()
        // {
        //     LinqChunk.ExampleNewChunk(_people, 10);
        // }
        // [Benchmark]
        // public void WhereFilterWithWhereSelect()
        // {
        //     LinqWhere.ExampleWhereFilterWithWhereSelect(_people, 8);
        // }

        // [Benchmark]
        // public void WhereFilterWithLoop()
        // {
        //     LinqWhere.ExampleWhereFilterWithLoop(_people, 8);
        // }

        // [Benchmark]
        // public void FindManyPeopleWithFirst()
        // {
        //     LinqFirstOrDefault.ExampleFindManyPeopleWithFirst(_people);
        // }

        // [Benchmark]
        // public void FindManyPeopleWithLoop()
        // {
        //     LinqFirstOrDefault.ExampleFindManyPeopleWithLoop(_people);
        // }

        // [Benchmark]
        // public void FindPersonWithAny()
        // {
        //     if (_people.Any(a => a.Id == 30))
        //     {
        //         Person person = _people.First(f => f.Id == 30);
        //         // Lógica...
        //     }
        // }

        // [Benchmark]
        // public void FindPersonWithFirstOrDefault()
        // {
        //     Person person = _people.FirstOrDefault(f => f.Id == 30);

        //     if (person != null)
        //     {
        //         // Lógica..
        //     }       
        // }

    }
}
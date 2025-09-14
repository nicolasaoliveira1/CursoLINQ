using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;
using LINQ.Utils;

namespace LINQ.Class11
{
    public static class LinqFirstOrDefault
    {
        public static void ExampleFirstOrDefault(Person[] people)
        {
            Person person = people.FirstOrDefault();

            if (person == null)
                Console.WriteLine("Não foi encontrada nenhuma pessoa");
            else
                Console.WriteLine($"Primeiro registro da coleção de pessoas: {person.Name}");
        }

        public static void ExampleFirstOrDefaultIdGreaterThanValue(Person[] people, int value)
        {
            Person person = people.FirstOrDefault(f => f.Id > value);

            if (person == null)
                Console.WriteLine("Não foi encontrada nenhuma pessoa");
            else
                Console.WriteLine($"Primeiro registro da coleção de pessoas maior que {value}: {person.Name}");
        }

        public static void ExampleFirstOrDefaultWithoutError(Person[] people)
        {
            Person person = people.FirstOrDefault(f => f.Id > 20);

            if (person == null)
            {
                Console.WriteLine("Não foi encontrada nenhuma pessoa com id maior que 20");
            }
        }

        public static void ExampleFindManyPeopleWithFirst(Person[] people)
        {
            Person person10 = people.FirstOrDefault(f => f.Id == 10);
            Person person20 = people.FirstOrDefault(f => f.Id == 20);
            Person person30 = people.FirstOrDefault(f => f.Id == 30);
            Person person40 = people.FirstOrDefault(f => f.Id == 40);
            Person person50 = people.FirstOrDefault(f => f.Id == 50);
        }

        public static void ExampleFindManyPeopleWithLoop(Person[] people)
        {
            Person person10 = null, person20 = null, person30 = null, person40 = null, person50 = null;

            for (int i = 0; i < people.Length; i++)
            {
                Person currentPerson = people[i];

                if (currentPerson.Id == 10)
                {
                    person10 = currentPerson;
                }
                else if (currentPerson.Id == 20)
                {
                    person20 = currentPerson;
                }
                else if (currentPerson.Id == 30)
                {
                    person30 = currentPerson;
                }
                else if (currentPerson.Id == 40)
                {
                    person40 = currentPerson;
                }
                else if (currentPerson.Id == 50)
                {
                    person50 = currentPerson;
                }
                if (person10 != null && person20 != null && person30 != null && person40 != null && person50 != null)
                    break;
            }
        }
    }
}
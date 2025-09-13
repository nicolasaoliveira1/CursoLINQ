using System;
using LINQ.Class1;
using LINQ.Class10;
using LINQ.Class11;
using LINQ.Class12;
using LINQ.Class13;
using LINQ.Class14;
using LINQ.Class15;
using LINQ.Class16;
using LINQ.Class17;
using LINQ.Class18;
using LINQ.Class19;
using LINQ.Class2;
using LINQ.Class3;
using LINQ.Class4;
using LINQ.Class5;
using LINQ.Class6;
using LINQ.Class7;
using LINQ.Class8;
using LINQ.Class9;
using LINQ.Models;

namespace LINQ
{
    class Program
    {
        private static readonly Random _random = new Random();
        private static readonly string[] _courses = new string[3] { "TI", "Direito", "Medicina" };
        private static readonly string[] _genders = new string[2] { "Masculino", "Feminino" };

        static void Main(string[] args)
        {
            const int size = 10;
            int[] array = new int[4] { 1, 2, 3, 4 };
            int[] emptyArray = Array.Empty<int>();
            Person[] emptyPeople = Array.Empty<Person>();
            Person[] people = new Person[size];
            Person[] randomPeople = new Person[size];

            FillPersonArray(people);
            FillRandomPersonArray(randomPeople);

            #region [+] LINQ Select

            // LinqSelect.ExampleSelectIdsWithFor(people)
            // LinqSelect.ExampleSelectIdLinq(people);
            // LinqSelect.ExampleSelectNameLinq(people);
            // LinqSelect.ExampleSelectAnonymousType(people);
            // LinqSelect.ExampleCreateNewType(people);
            // LinqSelect.ExampleSelectTuple(people);

            #endregion

            #region [+] LINQ Where
            // LinqWhere.ExampleWhereIdsGreaterThanValue(people, 5); ;
            // LinqWhere.ExampleWhereNameContainsValue(people, "1");

            #endregion

            #region [+] LINQ Any

            // LinqAny.ExampleAnyIdEven(people);
            // LinqAny.ExampleAnyEmptyName(people);
            // LinqAny.ExampleAnyCollectionIsEmpty(people);

            #endregion

            #region [+] LINQ All

            // LinqAll.ExampleAllIdsGreaterThanValue(people, 0);
            // LinqAll.ExampleAllIdsGreaterThanValue(people, 1);
            // LinqAll.ExampleAllNamesIsNotNullOrWhiteSpace(people);

            #endregion

            #region [+] LINQ Average

            // LinqAverage.ExampleAverageInt(emptyArray);
            // LinqAverage.ExampleAverageInt(array);
            // LinqAverage.ExampleAveragePerson(people);

            #endregion

            #region [+] LINQ Max

            // LinqMax.ExampleMaxInt(array);
            // LinqMax.ExampleMaxPerson(people);

            #endregion

            #region [+] LINQ Min

            // LinqMin.ExampleMinInt(array);
            // LinqMin.ExampleMinPerson(people);

            #endregion

            #region [+] LINQ Sum

            // LinqSum.ExampleSumInt(array);
            // LinqSum.ExampleSumPerson(people);

            #endregion

            #region [+] LINQ Count

            // LinqCount.ExampleCount(people);
            // LinqCount.ExampleCountIdsGreaterThanValue(people, 8);

            #endregion

            #region [+] LINQ First

            // LinqFirst.ExampleFirst(people);
            // LinqFirst.ExampleFirst(emptyPeople);
            // LinqFirst.ExampleFirstIdGreaterThanValue(people, 4);
            // LinqFirst.ExampleFirstWithError(people);

            #endregion

            #region [+] LINQ FirstOrDefault

            // LinqFirstOrDefault.ExampleFirstOrDefault(people);
            // LinqFirstOrDefault.ExampleFirstOrDefault(emptyPeople);
            // LinqFirstOrDefault.ExampleFirstOrDefaultIdGreaterThanValue(people, 2);
            // LinqFirstOrDefault.ExampleFirstOrDefaultWithoutError(people);


            #endregion

            #region [+] LINQ Last

            // LinqLast.ExampleLast(people);
            // LinqLast.ExampleLastIdGreaterThanValue(people, 5);

            #endregion

            #region [+] LINQ LastOrDefault

            // LinqLastOrDefault.ExampleLastOrDefault(people);
            // LinqLastOrDefault.ExampleLastOrDefault(emptyPeople);
            // LinqLastOrDefault.ExampleLastOrDefaultIdGreaterThanValue(people, 4);
            // LinqLastOrDefault.ExampleLastOrDefaultWithoutError(people);


            #endregion

            #region [+] LINQ Single

            // LinqSingle.ExampleSingle(people);
            // LinqSingle.ExampleSingleWithIdEqualsToValue(people, 5);

            #endregion

            #region [+] LINQ SingleOrDefault

            // LinqSingleOrDefault.ExampleSingleOrDefault(people);
            // LinqSingleOrDefault.ExampleSingleOrDefaultWithIdEqualsToValue(people, 5);

            #endregion

            #region [+] LINQ Contains

            // LinqContains.ExampleContainsInt(array, 3);
            // LinqContains.ExampleContainsInt(array, 30);
            // LinqContains.ExampleContainsPeople(people, array);
            // LinqContains.ExampleContainsPeopleWithIds(people, array);

            #endregion

            #region [+] LINQ Skip and Take

            // LinqSkipTake.ExampleSkip(people, 5);
            // LinqSkipTake.ExampleSkip(people, 8);
            // LinqSkipTake.ExampleTake(people, 1);
            // LinqSkipTake.ExampleTake(people, 5);
            // LinqSkipTake.ExamplePagination(people, 0, 2);
            // LinqSkipTake.ExamplePagination(people, 1, 2);
            // LinqSkipTake.ExamplePagination(people, 2, 2);
            // LinqSkipTake.ExamplePagination(people, 3, 2);
            // LinqSkipTake.ExamplePagination(people, 4, 2);
            // LinqSkipTake.ExamplePagination(people, 5, 2);

            #endregion

            #region [+] LINQ OrderBy

            // LinqOrderBy.ExampleOrderBy(array);
            // LinqOrderBy.ExampleOrderByRandomPerson(randomPeople);

            #endregion

            #region [+] LINQ GroupBy

            Console.WriteLine("---------------> Pessoas desagrupadas <---------------\n");

            var peopleToShow = people.Select(s => $"Id: {s.Id} - Nome: {s.Name} - Sexo: {s.Gender} - Curso: {s.Course}");

            Console.WriteLine(string.Join("\n", peopleToShow));
            Console.WriteLine("\n\n");
            LinqGroupBy.ExampleGroupByOneKey(people);
            Console.WriteLine("\n\n");
            LinqGroupBy.ExampleGroupByComposedKey(people);

            #endregion

            Console.ReadKey();
        }
        static void FillPersonArray(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                int id = i + 1;
                int courseIndex = _random.Next(0, 3);
                int genderIndex = _random.Next(0, 2);

                people[i] = new Person
                {
                    Id = id,
                    Name = $"Pessoa {id}",
                    Course = _courses[courseIndex],
                    Gender = _genders[genderIndex] 
                };
            }
        }

        static void FillRandomPersonArray(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                int id = _random.Next(0, 100);

                people[i] = new Person
                {
                    Id = id,
                    Name = $"Pessoa {id}"
                };
            }
        }
    }
}
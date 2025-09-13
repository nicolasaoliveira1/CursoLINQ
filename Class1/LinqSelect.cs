using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Models;

namespace LINQ.Class1
{
    public static class LinqSelect
    {
        public static void ExampleSelectIdsWithFor(Person[] people)
        {
            int[] ids = new int[people.Length];

            for (int i = 0; i < people.Length; i++)
            {
                ids[i] = people[i].Id;
            }

            Console.WriteLine($"Ids selecionados com for: {string.Join(", ", ids)}");
        }

        public static void ExampleSelectIdLinq(Person[] people)
        {
            var ids = people.Select(s => s.Id);
            Console.WriteLine($"Ids selecionados com select: {string.Join(", ", ids)}");
        }

        public static void ExampleSelectNameLinq(Person[] people)
        {
            var names = people.Select(s => s.Name);
            Console.WriteLine($"Names selecionados com select: {string.Join(", ", names)}");
        }

        public static void ExampleSelectAnonymousType(Person[] people)
        {
            var anonymous = people.Select(s => new
            {
                NewId = s.Id,
                NewName = s.Name
            });
            Console.WriteLine($"Ids selecionados com tipo anônimo: {string.Join(", ", anonymous.Select(s => s.NewId))}");
            Console.WriteLine($"Names selecionados com tipo anônimo: {string.Join(", ", anonymous.Select(s => s.NewName))}");
        }

        public static void ExampleSelectTuple(Person[] people)
        {
            var tuples = people.Select(s =>
            (
                NewId: s.Id,
                NewName: s.Name
            ));
            Console.WriteLine($"Ids selecionados com tupla: {string.Join(", ", tuples.Select(s => s.NewId))}");
            Console.WriteLine($"Names selecionados com tupla: {string.Join(", ", tuples.Select(s => s.NewName))}");
        }
        public static void ExampleCreateNewType(Person[] people)
        {
            var texts = people.Select(s => new TextField
            {
                Id = s.Id,
                Text = s.Name
            });

            Console.WriteLine($"Textos: {string.Join(", ", texts.Select(s => s.Text))}");
        }

    }
}
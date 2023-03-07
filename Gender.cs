using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");

            WhereLINQ();
            ThenByLINQ();
            ThenByDescendingLINQ();
            ToLookUpLINQ();
        }

        public static void WhereLINQ()
        {
            var peopleAge = PeopleList.peoples
                .Where(x => x.Age > 20 && x.Age < 23);

                foreach (var item in peopleAge)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void ThenByLINQ()
        {
            Console.WriteLine("ThenBy järgi reastamine");

            var thenByResult = PeopleList.peoples
                .OrderBy(x => x.Name)
                .ThenBy(x => x.Age);

            foreach (var people in thenByResult)
            {
                Console.WriteLine(people.Name + " " + people.Age );
            }
        }

        public static void ThenByDescendingLINQ()
        {
            Console.WriteLine("ThenByDescending");

            var thenByDescending = PeopleList.peoples
                .OrderBy(x => x.Name)
                .OrderByDescending(x => x.Age);

            foreach (var people in thenByDescending)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }

        public static void ToLookUpLINQ()
        {
            Console.WriteLine("ToLookUp järgi reastamine");

            var toLookUp = PeopleList.peoples
                .ToLookup(x => x.Age);

            foreach (var people in toLookUp)
            {
                Console.WriteLine("age group" + people.Key);

                foreach (People p in people)
                {
                    Console.WriteLine("person name" + p.Name);
                }
            }
        }

        public static void JoinLINQ()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("innerJoin in LINQ");

            var innerJoin = PeopleList.peoples
                .Join(GenderList.genderList,
                humans => humans.GenderId,
                Gender => Gender.Id,
                (humans, gender) => new
                {
                    name = humans.Name,
                    age = humans.Age,

        }
    }
}

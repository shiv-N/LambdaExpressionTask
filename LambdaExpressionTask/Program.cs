using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // UC 1: Create list and insert records.
            List<Person> listPersonsInCity = new List<Person>();
            AddRecords(listPersonsInCity);

            // UC 2: Retrieving Top 2 aged persons from the list who are older than 60 years.
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("Retrieving Top 2 aged persons from the list who are older than 60 years\n");
            Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(listPersonsInCity);

            // UC 3: Checks any person's age that is between 13 and 19 years.
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("\nChecking whether any person is teen-ager or not...");
            CheckingForTeenagerPerson(listPersonsInCity);
        }

        // UC 3
        private static void CheckingForTeenagerPerson(List<Person> listPersonsInCity)
        {
            if (listPersonsInCity.Any(e => (e.Age >= 13 && e.Age <= 19)))
            {
                Console.WriteLine("Yes, we have some teen-agers in the list");
            }
        }

        // UC 2
        private static void Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }
        }

        // UC 1
        private static void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork, NY", 15));
            listPersonsInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork, NY", 25));
            listPersonsInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork, NY", 35));
            listPersonsInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork, NY", 45));
            listPersonsInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton, OH", 55));
            listPersonsInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456882", "Winston", "1208 Alex St, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore, NY", 85));
            listPersonsInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore, NY", 95));
        }
    }
}

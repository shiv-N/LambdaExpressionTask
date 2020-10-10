using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpressionTask
{
    class AgeOperation
    {
        List<Person> listPersonsInCity = null;

        public AgeOperation(List<Person> listPersonsInCity)
        {
            this.listPersonsInCity = listPersonsInCity;
        }

        public void AllAgeOperations()
        {
            // UC 2: Retrieving Top 2 aged persons from the list who are older than 60 years.
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("Retrieving Top 2 aged persons from the list who are older than 60 years\n");
            Retrieving_TopTwoRecord_ForAgeIs_LessThanSixty(listPersonsInCity);

            // UC 3: Checks any person's age that is between 13 and 19 years.
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("\nChecking whether any person is teen-ager or not...");
            CheckingForTeenagerPerson(listPersonsInCity);

            // UC 4: Check average of all the person's age
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("\nGetting Average of all the person's age...");
            AllPersonsAverageAge(listPersonsInCity);
        }


        // UC 4
        private static void AllPersonsAverageAge(List<Person> listPersonsInCity)
        {
            double avgAge = listPersonsInCity.Average(e => e.Age);
            Console.WriteLine("The average of all the person's age is: " + avgAge);
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
    }
}

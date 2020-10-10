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

            Console.WriteLine("##Age");
            AgeOperation age = new AgeOperation(listPersonsInCity);
            age.AllAgeOperations();

            // UC 6: skips each person whose age is less than 60.
            Console.WriteLine("\nSkipping every person whose age is less than 60 years...");
            SkipRecordLessThanSixtyAge(listPersonsInCity);

            Console.WriteLine("\n## Name");
            // UC 5:Checking whether a person having name 'SAM' exists or not.
            Console.WriteLine("\nChecking whether a person having name 'SAM' exists or not...");
            CheckNameExistOrNot(listPersonsInCity);

            // UC 7 :Removing all the persons record from list that have "SAM" name.
            Console.WriteLine("\nRemoving all the persons record from list that have 'SAM' name");
            RemoveRecord(listPersonsInCity);


            // UC 8: Finding the person whose SSN = 203456876 in the list
            Console.WriteLine("\nFinding the person whose SSN = 203456876 in the list");
            FindRecordBySSN(listPersonsInCity);

        }

        // UC 8
        private static void FindRecordBySSN(List<Person> listPersonsInCity)
        {
            Person oPerson = listPersonsInCity.Find(e => (e.SSN == "203456876"));
            Console.WriteLine("The person having SSN '203456876' is : " + oPerson.Name + " \t\tAge: " + oPerson.Age);
        }

        // UC 7
        private static void RemoveRecord(List<Person> listPersonsInCity)
        {
            listPersonsInCity.RemoveAll(e => (e.Name == "SAM"));
            if (listPersonsInCity.TrueForAll(e => e.Name != "SAM"))
            {
                Console.WriteLine("No person is found with 'SAM' name in current list");
            }
        }


        // UC 6
        private static void SkipRecordLessThanSixtyAge(List<Person> listPersonsInCity)
        {
            foreach (Person pers in listPersonsInCity.SkipWhile(e => e.Age < 60))
            {
                Console.WriteLine("Name : " + pers.Name + " \t\tAge: " + pers.Age);
            }
        }

        // UC 5
        private static void CheckNameExistOrNot(List<Person> listPersonsInCity)
        {
            if (listPersonsInCity.Exists(e => e.Name == "SAM"))
            {
                Console.WriteLine("Yes, A person having name  'SAM' exists in our list");
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

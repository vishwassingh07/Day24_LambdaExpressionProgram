using System;
namespace LambdaExpressionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lambda Expression Program\n========================================");

            List<Person> personlist = new List<Person>();
            personlist.Add(new Person("123654", "Vishwas", "Jabalpur", 28));
            personlist.Add(new Person("123656", "Vivek", "Mumbai", 15));
            personlist.Add(new Person("123657", "Siddhant", "Pune", 62));
            personlist.Add(new Person("123659", "Shobhit", "Indore", 20));
            personlist.Add(new Person("123658", "Avinash", "Bhopal", 60));
            personlist.Add(new Person("123678", "Sagar", "Patna", 78));
            personlist.Add(new Person("129668", "Priyanshu", "Noida", 58));
            personlist.Add(new Person("126662", "Ankit", "Bhoma", 48));
            
            
            Console.WriteLine("Retrieving Top 2 aged person from the list less than 60 years");
            foreach (Person person in personlist.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }

        }
    }
}
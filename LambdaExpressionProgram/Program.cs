using System;
namespace LambdaExpressionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lambda Expression Program\n========================================");

            List<Person> personlist = new List<Person>();
            personlist.Add(new Person("123654", "Vishwas", "Jabalpur", 18));
            personlist.Add(new Person("123656", "Vivek", "Mumbai", 65));
            personlist.Add(new Person("123657", "Siddhant", "Pune", 22));
            personlist.Add(new Person("123659", "Shobhit", "Indore", 16));
            personlist.Add(new Person("123658", "Avinash", "Bhopal", 60));
            personlist.Add(new Person("123678", "Sagar", "Patna", 68));
            personlist.Add(new Person("129668", "Priyanshu", "Noida", 58));
            personlist.Add(new Person("126662", "Ankit", "Bhoma", 14));
            
            
            Console.WriteLine("Retrieving Top 2 aged person from the list less than 60 years");
            foreach (Person person in personlist.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }

            Console.WriteLine("\n Checking whether any one of them teenager or not");
            foreach (Person person in personlist.FindAll(e => (e.Age >= 13 && e.Age <= 18)))
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
    }
}
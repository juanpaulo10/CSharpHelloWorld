using System;

namespace CSharpHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // String name = Console.ReadLine();
            // Console.WriteLine("Hello: " + name);

            var newName = "myString";
            Console.WriteLine("newName is a {0}", newName.GetType());

            //arithmethics
            int i = 0;
            Console.WriteLine("i++ : " + i++);
            Console.WriteLine("i++ : " + ++i);

            Random rand = new Random();
            Console.WriteLine("Random num between 0 - 3 = " + (rand.Next(0,4)));

            //Relation Operators: > < <= >= == !=
            //Logical Operators : && || !

            int age = 17;

            if ( (age >= 5) && (age <= 7) )
            {
                Console.WriteLine("Elementary School");
            } else if ( (age > 7) && (age < 13) )
            {
                Console.WriteLine("Middle school");
            } else{
                Console.WriteLine("High school");
            }

            bool canDrive = age >= 16 ? true : false;

            switch (age)
            {
                case 0: 
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                    goto Cute; //goto statements can cause NIGHTMARES @_@

                default:
                    Console.WriteLine("LOL");
                    break;
            }
            Cute:
            Console.WriteLine("Toddlers are Cute");
        }
    }
}

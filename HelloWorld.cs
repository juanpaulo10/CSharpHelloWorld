using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpHelloWorld
{
    //CLASSES AND OBJECTS
    class Animal
    {
        // properties and their automatic getters and setters
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        //creating own getters and setters
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //constructor
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++;
        }

        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;

        static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        public string introduce()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height, weight, sound);
        }

        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            //for classes examples
            /*Animal Sando = new Animal (15, 10, "Sando", "woof");
            Animal Tim = new Animal(5, 3, "Tim", "arf");

            Console.WriteLine("{0} says {1}", Sando.name, Sando.sound);
            Console.WriteLine("{0} says {1}", Tim.name, Tim.sound);

            Console.WriteLine("Number of animals created:" + Animal.getNumOfAnimals());

            Console.WriteLine(Sando.introduce());
            Console.WriteLine(Tim.introduce());

            Console.WriteLine(Sando.getSum(num2: 1.3, num1: 2.6));

            Animal pichi = new Animal
            {
                name = "pichi",
                height = 16,
                weight = 18,
                sound = "ror"
            };

            Dog spike = new Dog();
            Console.WriteLine(spike.introduce());

            spike = new Dog(20, 15, "Spike", "arfu arf", "burger");
            Console.WriteLine(spike.introduce());*/

            

            //for polymorphism/inheritance - abstract/interfaces
            /*Shape rect = new Rectangle(5, 5);
            Shape tri = new Triangle(5, 5);

            Console.WriteLine("Rect Area " + rect.area());
            Console.WriteLine("Tri Area " + tri.area());

            Rectangle combineRect = new Rectangle(5, 6) + new Rectangle(5, 8);
            Console.WriteLine("combineRect Area " + combineRect.area());*/



            //for Generics
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");
            superman.key = "Superman";
            superman.value = "Clark Kent";

            KeyValue<int, string> samsungTV = new KeyValue<int, string>(0, "");
            samsungTV.key = 11134771;
            samsungTV.value = "a 50 inch Samsung TV";

            superman.showData();
            samsungTV.showData();
        }
    }

    class Dog : Animal
    {
        //properties
        public string favFood { get; set; }

        //calls super class 
        public Dog() : base()
        {
            this.favFood = "No Fave Food";
        }

        public Dog (double height, double weight, string name, string sound, string favFood) : base(height, weight, name, sound)
        {
            this.favFood = favFood;
        }

        //overriding in c# has keyword "new"
        new public string introduce()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}", name, height, weight, sound, favFood);
        }
    }

    //abstract methods are methods that should be defined by a class
    //ONE abstract class can only be inherited by a class
    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    }

    //every method of an interface is an abstract method
    public interface ShapeItem
    {
        double area();
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        //constructor
        public Rectangle(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        public override double area()
        {
            return length * width;
        }

        //operator overloading - example: adding rectangle together
        public static Rectangle operator+ (Rectangle rect1, Rectangle rect2)
        {
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;

            return new Rectangle(rectLength, rectWidth);
        }
    }

    class Triangle : Shape
    {
        private double triangleBase;
        private double height;

        //constructor
        public Triangle(double num1, double num2)
        {
            triangleBase = num1;
            height = num2;
        }

        public override double area()
        {
            return .5 * (triangleBase * height);
        }
    }

    //Generic
    class KeyValue<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }

        public void showData()
        {
            Console.WriteLine("{0} is {1} ", this.key, this.value);
        }
    }

}

using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

delegate double GetSum(double num1, double num2);

namespace CSharpHelloWorld
{
    public enum Temperature
    {
        Freeze,
        Low,
        Warm,
        Boil
    }

    struct Customers
    {
        private string name;
        private double balance;
        private int id;

        public void createCust(string name, double bal, int id)
        {
            this.name = name;
            this.balance = bal;
            this.id = id;
        }

        public void showCustInfo()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Balance " + balance);
            Console.WriteLine("Id " + id);
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            /*Temperature micTemp = Temperature.Warm;

            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;
                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;
                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;
                case Temperature.Boil:
                    Console.WriteLine("Temp on Boiling");
                    break;
            }*/

            /*Customers bob = new Customers();
            bob.createCust("Bob", 15.50 ,111345);
            bob.showCustInfo();*/

            //anonymous method/function. SEE delegate on top
            /*GetSum sum = delegate(double num1, double num2)
            {
                return num1 + num2;
            };

            Console.WriteLine("5 + 10 =" +sum(5, 10));*/

            //lambda expression, 3 params -- 2 for args, 1 for result
            /*Func<int, int, int> getSum = (x, y) => x + y;

            Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));

            List<int> numList = new List<int> { 5, 10 , 20, 15, 25};
            //Where(Lamba Expression as argument)
            List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();*/

            //FILE I/O
            /*string[] custs = new string[] { "Tom", "Paul", "Greg" };
            FileStream SourceStream = new FileStream("custs.txt", FileMode.Create);
            using (StreamWriter sw = new StreamWriter(SourceStream))
            {
                foreach (string cust in custs)
                {
                    sw.WriteLine(cust);
                }
            }
            SourceStream.Dispose();
            
            string custName = "";

            FileStream SourceStream2 = new FileStream("custs.txt", FileMode.Open);
            // Read the file and display it line by line.
            using (System.IO.StreamReader sr = new System.IO.StreamReader(SourceStream2))
            {
                while((custName = sr.ReadLine()) != null)
                {
                    Console.WriteLine(custName);
                }
            }

            SourceStream2.Dispose();*/
            
            /*Employee e1 = new Employee("Bob", "120 k-j street", 12345);
            e1.introduce();*/
        }
    }

    /*class Company
    {
        private string name { get; set; }
        private string addr { get; set; }
        static public int numEmployees;

        public Company()
        {
            this.name = "No Name";
            this.addr = "No Address";
        }

        public Company(string name, string addr)
        {
            this.name = name;
            this.addr = addr;
        }

        public static int getNumEmployees()
        {
            return numEmployees;
        }
    }

    class Employee : Company
    {
        private string name { get; set; }
        private string addr { get; set; }
        private int id { get; set; }

        public Employee(string name, string addr, int id)
        {
            this.name = name;
            this.addr = addr;
            this.id = id;
            numEmployees++;
        }
        
        public string getName()
        {
            return name;
        }

        public string getAddr()
        {
            return addr;
        }

        public int getId()
        {
            return id;
        }

        public void introduce()
        {
            Console.WriteLine("{0}-ID{1} is added to the company, he lives in {2}.\nTotal Num Employees: {3}", this.getName(), this.getId(), this.getAddr(), Company.getNumEmployees());
        }
    }*/
}

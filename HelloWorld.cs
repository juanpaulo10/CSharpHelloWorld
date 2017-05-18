using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            String name = Console.ReadLine();
            Console.WriteLine("Hello: " + name);

            var newName = "myString";
            Console.WriteLine("newName is a {0}", newName.GetType());*/

            //arithmethics
            /*int i = 0;
            Console.WriteLine("i++ : " + i++);
            Console.WriteLine("i++ : " + ++i);

            Random rand = new Random();
            Console.WriteLine("Random num between 0 - 3 = " + (rand.Next(0,4)));*/

            //Relation Operators: > < <= >= == !=
            //Logical Operators : && || !

            /*int age = 17;

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
                    break;

                default:
                    Console.WriteLine("LOL");
                    break;
            }*/

            // looping - while loop
            /*int b = 0;

            while ( b < 10 )
            {
                if ( b == 7 )
                {
                    b++;
                    continue;
                }

                if ( b == 9 )
                {
                    break;
                }

                if ( (b % 2) > 0 )
                {
                    Console.WriteLine(b);
                }

                b++;
            }*/

            // looping - do while
            /*string guess;

            do
            {
                Console.WriteLine("Guess a Number: ");
                guess = Console.ReadLine();

            } while (! guess.Equals("15") );*/

            // looping - for loop
            /*for (int i = 0; i < 10; i++)
            {
                if ( (i % 2) == 0 )
                {
                    Console.WriteLine(i);
                }
            }*/

            // looping - foreach
            /*string randStr = "Here are dandom";

            foreach (char c in randStr)
            {
                Console.WriteLine(c);
            }*/

            //string functions
            /*string sampString = "A bunch of random words";

            Console.WriteLine("is empty " + String.IsNullOrEmpty(sampString));
            
            Console.WriteLine("is empty " + String.IsNullOrWhiteSpace(sampString));

            Console.WriteLine("String Length: " + sampString.Length);

            Console.WriteLine("Index of bunch: " + sampString.IndexOf("bunch"));
            int bunchStart = sampString.IndexOf("bunch");
            int bunchEnd = sampString.IndexOf("bunch") + 4;
            Console.WriteLine("2nd Word: " + sampString.Substring(bunchStart, bunchEnd));
            string sampString2 = "Helloworld";

            bool bStrEqual = sampString.Equals(sampString2);
            Console.WriteLine("Strings Equal: " + bStrEqual);

            Console.WriteLine("Starts with \"A bunch\": " + sampString.StartsWith("A bunch"));
            
            Console.WriteLine("Ends with words: " + sampString.EndsWith("words"));

            //sampString = sampString.Trim(); //TrimEnd //TrimStart
            sampString = sampString.Replace("words", "characters");
            sampString = sampString.Remove(0, 2);

            string[] names = new string[3] {"Paulo", "Daryl", "Joey"};

            Console.WriteLine("Name List " + String.Join(", ", names));

            //format string
            string fmtString = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.568, .56, 1000);
            Console.WriteLine(fmtString);*/

            // string builder
            /*StringBuilder sb = new StringBuilder();
            sb.Append("This is the first sentence. ");
            sb.AppendFormat("My name is {0} and I live in {1}", "Derek", "Pennsylvania");
            //sb.Clear();
            sb.Replace("a", "e");

            sb.Remove(5, 7);

            Console.WriteLine(sb.ToString());*/

            //Arrays
            /*int[] randNumArray;

            int[] randArray = new int[5];

            int[] randArray2 = { 1, 2, 3, 4, 5};

            Console.WriteLine("Array length: " + randArray2.Length);
            Console.WriteLine("Item 0: " + randArray2[0]);

            for (int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("Item [{0}] is: {1}" ,i, randArray2[i]);
            }

            foreach (int num in randArray2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Where is 1: randArray2[{0}]", Array.IndexOf(randArray2, 1));

            string[] names = {"Tom", "Paulo", "Sally"};

            string nameStr = string.Join(",", names);

            string[] nameArray = nameStr.Split(',');*/
            
            //multidimensional arrays
            /*int[,] multiArray = new int[5, 3];
            int[,] multArray2 = { {0, 7}, {2, 3}, {4, 5} };

            foreach (int num in multArray2)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Here----");
            Console.WriteLine("{0} by {1} Array" , multArray2.GetLength(0), multArray2.GetLength(1));
            for (int x = 0; x < multArray2.GetLength(0); x++)
            {
                for (int y = 0; y < multArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0} | {1}: {2}", x, y, multArray2[x, y]);
                }
            }*/

            //List = similar to array but you can dynamically add elements.
            /*List<int> numList = new List<int>();
            numList.Add(5);
            numList.Add(15);
            numList.Add(25);

            int[] randArray = {1, 2, 3, 4, 5};
            numList.AddRange(randArray);

            List<int> numList2 = new List<int>(randArray);
            List<int> numList3 = new List<int>(new int[] {1, 2, 3, 4, 5});

            numList.Insert(0, 10);
            Console.WriteLine("Size is: " + numList.Count);
            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine("Index[{0}] has value of: {1}", i, numList[i]);
            }
            numList.Remove(15); // Remove element which has 15(int value)
            numList.RemoveAt(1); // Remove element at index 1

            Console.WriteLine("numlist3 value:4 is at index:" + numList3.IndexOf(4));
            Console.WriteLine("numlist3 has 5? " + numList3.Contains(5));
            
            List<string> strList = new List<string>(new string[] {"Tom", "Paul"});

            Console.WriteLine("Tom in strList " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));

            strList.Sort();
            Console.WriteLine(strList.ToString());
            foreach (String str in strList)
            {
                Console.WriteLine(str);
            }*/

            // Exceptions

            /*try
            {
                Console.Write("Divide 10 by 0");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10 / {0} = {1}", num, (10/num));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                //throw ex;
                //throw new InvalidOperationException("Operation Failed", ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }*/

            
        }
    }
}

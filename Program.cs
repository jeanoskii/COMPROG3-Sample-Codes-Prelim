using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//take note the naming convention of the namespace: Capitalize every word
namespace ConsoleApplication1
{
    //take note the naming convention of the class: Capitalize every word
    class Program
    {
        
        //take note the naming convention of the Main method: Capitalize every word
        static void Main(string[] args)
        {
            #region DataTypesAndConversion
            //C# is case sensitive; naming convention for variable uses camelCase
            int myagenextyear = 24;
            int myAgeNextYear = 25;

            //constant values; take note of naming convention ALL CAPS
            const float VALUE_OF_PI = 3.1417f;
            const double GRAVITY_OF_EARTH = 9.807;
            Console.WriteLine("Value of Pi is " + VALUE_OF_PI);
            Console.WriteLine("Gravity of Earth is " + GRAVITY_OF_EARTH + "m/s");

            //implicit casting i.e only widening
            short a = 10000;
            long b = a;
            Console.WriteLine("Implicit casting: " + b);

            //explicit casting i.e widening AND narrowing
            long c = 32000;
            short d = (short)c;
            Console.WriteLine("Explicit casting: " + d);

            //byte to char conversion; converts to ASCII value;
            byte e = 101;
            char f = (char)e;
            Console.WriteLine("Explicit casting from numeric to char: " + f);

            #endregion

            #region Operators

            //Logical XOR operator
            bool isTodaySunny = true;
            bool isTodayRainy = false;
            bool isTodayCloudy = true;
            bool returnValue = isTodaySunny ^ isTodayRainy ^ isTodayCloudy;
            Console.WriteLine("\n" + returnValue);

            /*PEMDAS;
             * 1 * 2 = 2
             * 2 / 3 = 0 no decimal because int data type
             * 0 + 4 = 4
             * 4 - 5 = -1
             * anwer = -1
             */
            int precedenceAnswer = 1 * 2 / 3 + 4 - 5;
            Console.WriteLine(precedenceAnswer);


            //System.Math is automatically imported
            double answer = Math.Pow(2, 3);
            Console.WriteLine("2 to the power of 3 is: " + answer);

            double sineAnswer = Math.Sin(90);
            Console.WriteLine("Sine of 90 is " + sineAnswer);


            #endregion

            #region DecisionMakingIfElseSwitch

            //take note of naming convention; Boolean must have 'is' in front of the identifier
            bool isTodaySaturday = true;

            if (isTodaySaturday == true)
            {
                Console.WriteLine("\nToday is Saturday");
            }
            else
            {
                Console.WriteLine("Today is NOT Saturday");
            }

            int z = 12;
            int y = 11;
            int x = 9;

            //nested if..else statement with one expression
            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine("x is the biggest number: " + x);
                }
                else
                {
                    Console.WriteLine("z is the biggest number: " + z);
                }
            }
            else
            {
                if (y > z)
                {
                    Console.WriteLine("y is the biggest number: " + y);
                }
                else
                {
                    Console.WriteLine("z is the biggest number: " + z);
                }
            }

            //if..else statement with multiple expressions
            if (x > y && x > z)
            {
                Console.WriteLine("x is the biggest number: " + x);
            }
            else if (y > x && y > z)
            {
                Console.WriteLine("y is the biggest number: " + y);
            }
            else //z > x && z > y
            {
                Console.WriteLine("z is the biggest number: " + z);
            }



            string name = "Jeano";

            //if if if statements
            Console.WriteLine("if if if statements");
            if (name.Contains('e'))
            {
                Console.WriteLine(name + " contains 'e'");
            }
            if (name.Contains('a'))
            {
                Console.WriteLine(name + " contains 'a'");
            }

            //vs if..else if..else statement
            Console.WriteLine("\nvs if..else if..else statement");
            if (name.Contains('e'))
            {
                Console.WriteLine(name + " contains 'e'");
            }
            else if (name.Contains('a'))
            {
                Console.WriteLine(name + " contains 'a'");
            }


            switch (name)
            {
                case "jeano":
                    Console.WriteLine("jeano");
                    break;
                case "Jeano":
                    Console.WriteLine("Jeano");
                    break;
                case "JeanO":
                    Console.WriteLine("JeanO");
                    break;
            }
            

            //ternary or conditional operator denoted by ? and :
            int exam_score = 75;
            string result = exam_score >= 60 ? "Student passed the exam." : "Student failed the exam.";
            Console.WriteLine(result);



            #endregion

            #region ArraysAndLooping
            byte[] helloWorld = { 72, 69, 76, 76, 79, 32, 119, 111, 114, 108, 100, 33 };
            Console.Write("\n");
            //take note of syntax of for loop; for loop can increment (++) and decrement (--)
            //incrementing for loop
            for (int i = 0; i < helloWorld.Length; i++)
            {
                Console.Write((char)helloWorld[i]);
            }

            Console.WriteLine("\n");

            //decrementing for loop; result will be the reversed hello world
            for (int i1 = (helloWorld.Length - 1); i1 >= 0; i1--)
            {
                Console.Write((char)helloWorld[i1]);
            }
            #endregion

            #region StringsAndStringBuilder
            //Strings are immutable, while StringBuilder is mutable
            //immutablility allocates new memory address for each string modification
            //mutability only uses one memory address; erases the previous value and replaces the modified value

            //initialization of strings and string builder
            string mySecondName = "Frederick";
            Console.WriteLine("\n" + mySecondName);
            StringBuilder myLastName = new StringBuilder("Ermitano");
            Console.WriteLine(myLastName);

            //concatenating strings and string builder
            mySecondName = "Kevin " + mySecondName + " John";
            Console.WriteLine(mySecondName);
            myLastName.Insert(0, "De La ");
            myLastName.Insert(myLastName.Length, " Cuesta"); //same as Append
            //myLastName.Append(" Cuesta");
            Console.WriteLine(myLastName);

            //converting to string and string builder and vice versa
            myLastName = new StringBuilder(mySecondName); //string to string builder
            mySecondName = myLastName.ToString(); //string builder to string

            #endregion
            Console.ReadKey();
        }
    }
}

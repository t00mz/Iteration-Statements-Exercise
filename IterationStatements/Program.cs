using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            Range(1000, -1000);
            ByThree();

            FallsBetween(); 

        }

        //            LukeWarm Section:

        //    Write a method that will print to the console all numbers 1000 through - 1000

        public static void Range(int High, int Low)
        //why cant i replace int High w 1000 and int Low w -1000?
        {
            for (int i = High; i >= Low; i--)
            {
                Console.WriteLine(i);
            }
        }

        //    Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void ByThree()
        {
            for (int a = 3; a <= 999; a += 3)
            {
                Console.WriteLine(a);
            }
        }
        //    Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool EqualTo(int b, int c)
        {
            if (b == c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //    Write a method to check whether a given number is even or odd

        public static bool ItsEven(int d)
        {
            if (d % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }

            // scope could be: return (d % 2 == 0);
        }

        //    Write a method to check whether a given number is positive or negative

        public static string PositiveOrNeg(int e)
        {
            if (e > 0)
            {
                return "positive";
            }
            else if (e < 0)
            {
                return "negative";
            }
            else
            {
                return "neither";
            }

        }
        //    Write a method to read the age of a candidate and determine whether they can vote.

        public static void CanYouVote(int f)
        {
            var response = (f >= 18) ? "you can vote!" : "you cannot vote";
            Console.WriteLine(response);
        }

        //    Hint: Use Parse or the safer TryParse() for an extra challenge

        //    Parse()

        //    TryParse()


        //Heatin Up Section:

        //    Write a method to check if an integer(from the user) is in the range -10 to 10

        public static string FallsBetween()
        {

            Console.WriteLine("Input a number in the range of -10 to 10");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput >= -10 && userInput <=10)
            {
                 return $"Yes, {userInput} is in the range of -10 to 10";
            }
            else
            {
                 return $"No, {userInput} is not in the range of -10 to 10";
            }
             
        }


        //    Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiTable(int p)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {p} = {i * p}");
            }


        }




    }
}

using System;
using System.Security.Cryptography.X509Certificates;

namespace FBuzzExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(5));
        }

        public static string FizzBuzz(int num)
        {
            //if (num % 5 == 0 && num % 3 == 0)
            //    return "fizzbuzz";
            //else if (num % 5 == 0)
            //    return "buzz";
            //else if (num % 3 == 0)
            //    return "fizz";
            //else
            //    return "Not divisible by 3 or 5.";

            //ternary refactor

            var divisible = num % 3 == 0 && num % 5 == 0 ? "fizzbuzz" : num % 3 == 0 ? "fizz" : num % 5 == 0 ? "buzz" : "Not divisible by 3 or 5";
            return divisible;
        }
    }

}
using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int x = 0;
            foreach(int num in numbers)
            {
                if (num % 2 == 0)
                    x += num;
                else
                    x -= num;
            }
            return x;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return Math.Min(Math.Min(Math.Min(str1.Length, str2.Length), str3.Length), str4.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(Math.Min(number1, number2), number3), number4);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool tri = sideLength1 + sideLength2 > sideLength3;
            bool an = sideLength2 + sideLength3 > sideLength1;
            bool gle = sideLength3 + sideLength1 > sideLength2;
            
            return tri && an && gle;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Count(x => x == null) > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Count() == 0)
                return 0;
            
            double add = 0;
            double counter = 0;
            
            foreach(int num in numbers)
            {
                if (num % 2 == 0)
                {
                    add += num;
                    counter++;
                }
            }

            if (counter == 0)
                return 0;
            return add / counter;
        }

        public int Factorial(int number) 
        {
                if (number == 0)
                    return 1;
                else if(number < 0)
                    throw new ArgumentOutOfRangeException();

                return number * Factorial(number - 1);
        }
    }
}

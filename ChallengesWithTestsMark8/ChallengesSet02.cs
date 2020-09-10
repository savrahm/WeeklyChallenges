using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Count() % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers != null && numbers.Any() ? numbers.Min() + numbers.Max() : 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers != null ? numbers.Sum() : 0;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers != null)
            {
                int evens = 0;
                foreach (int num in numbers)
                    if (num % 2 == 0)
                        evens += num;
                    else
                        continue;
                return evens;
            }
          
            return 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers != null)
                return (numbers.Sum() % 2 != 0);
            else
                return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int x = 0;
            for (int i = 1; i < number; i += 2)
                x++;
            return x;
        }
    }
}

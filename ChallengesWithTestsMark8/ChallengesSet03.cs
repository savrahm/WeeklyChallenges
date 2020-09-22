using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return Array.Exists(vals, element => element == false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers != null)
                return numbers.Sum() % 2 == 0 ? false : true;
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {


            bool lower = password.Any(character => Char.IsLower(character));
            bool upper = password.Any(character => Char.IsUpper(character));
            bool number = password.Any(character => Char.IsDigit(character));
            return lower && upper && number;

            // return password.Any(character => Char.IsLower(character)) && password.Any(character => Char.IsUpper(character)) && password.Any(character => Char.IsDigit(character));
        }

        public char GetFirstLetterOfString(string val)
        {
            //return val[0];
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            //return val[val.Count() - 1];
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;  
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        { 
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}

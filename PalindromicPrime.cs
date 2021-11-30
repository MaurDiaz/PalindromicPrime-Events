using System;

namespace ActivityE5
{
    class PalindromicPrime
    {
        public bool IsPrime(int number)
        {
            bool isPrime = true;
            for(int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    isPrime = false;
                    return isPrime;
                }
            }
            return isPrime;
        }
        public bool IsPalindrome(string input)
        {
            bool isPalindrome;
            string[] arrayChars = new string[input.Length];
            string[] reverseArrayChars = new string[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                arrayChars[i] = input.Substring(i,1);
            }
            int j = 0;
            for(int i = arrayChars.Length-1; i >= 0; i--)
            {
                reverseArrayChars[j] = arrayChars[i];
                j++;
            }
            
        }
    }
}
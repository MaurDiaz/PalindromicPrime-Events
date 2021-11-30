using System;

namespace ActivityE5
{
    class PrimePalindrome
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
            
            string[] arrayChars = new string[input.Length];
            

        }
    }
}
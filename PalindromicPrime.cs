using System;

namespace ActivityE5
{
    static class PalindromicPrime
    {
        static public bool IsPrime(int number)
        {
            bool isPrime = true;
            if(number == 0 || number == 1)
            {
                isPrime = false;
                return isPrime;
            }
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
        static public bool IsPalindrome(int number)
        {
            string input = number.ToString();
            bool isPalindrome = true;
            string[] arrayChars = new string[input.Length];
            string[] reversedArrayChars = new string[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                arrayChars[i] = input.Substring(i,1);
            }
            int j = 0;
            for(int i = arrayChars.Length-1; i >= 0; i--)
            {
                reversedArrayChars[j] = arrayChars[i];
                j++;
            }
            for(int i = 0; i < arrayChars.Length; i++)
            {
                if(arrayChars[i] != reversedArrayChars[i])
                {
                    isPalindrome = false;
                    return isPalindrome;
                }
            }
            return isPalindrome;
        }
    }
}
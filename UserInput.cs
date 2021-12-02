using System;

namespace ActivityE5
{
    class UserInput
    {
        public event Action<string> PrimeEvent;
        public event Action<string> PalindromeEvent;

        private int _number;

        public UserInput()
        {

        }
        public UserInput(string input)
        {
            this.Number = input;
        }
        public string Number
        {
            get
            {
                return this.Number;
            }
            set{
                int input = ValidateInput(value);
                _number = input;
                if(PalindromicPrime.IsPrime(_number) && PalindromicPrime.IsPalindrome(_number))
                {
                    PrimeEvent(String.Format("This is a prime number..."));
                    PalindromeEvent(String.Format("and a palindrome!"));
                }
            }
        }
        private int ValidateInput(string input)
        {
            if(input == "exit")
            {
                Console.WriteLine("Program ended");
                return -1;
            }
            try{
            int number = int.Parse(input);
            if(number < 0)
            {
                throw new Exception();
            }
            return number;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Try again.");
            }
            return -1;
        }
    }
}
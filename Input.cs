using System;

namespace ActivityE5
{
    class Input
    {
        public event Action<string> IsPrime;
        public event Action<string> IsPalindrome;

        private int _number;

        public Input(string input)
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
                if(ValidateInput(value) >= 2)
                {
                    _number = input;
                }
            }
        }
        private int ValidateInput(string input)
        {
            try{
            int number = int.Parse(input);
            if(number < 2)
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
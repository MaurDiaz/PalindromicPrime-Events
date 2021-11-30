using System;

namespace ActivityE5
{
    public class Events
    {
        public event Action<string> IsPrime;
        public event Action<string> IsPalindrome;
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class NumbersToFizzBuzz
    {

        public string ConvertToFizz(int number)
        {
            if (number >0)
            {
                if (number % 3 == 0 && number % 5 == 0)
                    return "FizzBuzz";
                else if
                  (number % 3 == 0 && number % 5 != 0)
                    return "Fizz";
                else if (number % 5 == 0)
                    return "Buzz";
                else
                    return number.ToString();
            }
            throw new ArgumentException();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnX.Bank.API.Repository.Cards.Validation
{
    public class LuhnValidator : ICardValidator
    {
        public bool IsValid(string cardNumber)
        {
            // Convert the card number to a list of digits
            var numbers = cardNumber.Select(c => int.Parse(c.ToString())).ToList();

            // Start with the second to last digit and continue with every other digit going back to the beginning of the card
            for (int i = numbers.Count - 2; i >= 0; i -= 2)
            {

                Console.WriteLine(numbers[i].ToString());
                // Double the digit
                numbers[i] = numbers[i] * 2;

                // If the doubled digit is greater than 9, then split it and sum the independently (i.e. if 10, 1 + 0)
                if (numbers[i] > 9)
                {
                    numbers[i] = numbers[i] / 10 + numbers[i] % 10;
                }
            }

            // Sum all doubled and untouched digits in the number
            var sum = numbers.Sum();

            // If the total is a multiple of 10, the number is valid
            return sum % 10 == 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnX.Bank.API.Repository.Cards.Validation
{
    // define an interface called ICardValidator that defines a method for validating a card type:
    // Since currently application support only Luhn algorithm, We can move with a different validation algorithm in the future if needed

    public interface ICardValidator
    {
        bool IsValid(string cardNumber);
    }
}

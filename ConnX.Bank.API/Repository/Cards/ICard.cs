using ConnX.Bank.API.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnX.Bank.API.Repository.Cards
{
    public interface ICard
    {
        CardDetailsResponse CardValidationDetails(string cardNumber);
    }
}

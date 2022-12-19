using ConnX.Bank.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnX.Bank.API.Repository.Cards.Type
{
    public interface ICardTypeDetector
    {
        CardType GetCardType(string cardNumber);
    }
}

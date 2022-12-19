using ConnX.Bank.API.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnX.Bank.API.Repository.Cards.Type
{
    public class CardTypeDetector : ICardTypeDetector
    {
        public CardType GetCardType(string cardNumber)
        {
            if (cardNumber.StartsWith("34") || cardNumber.StartsWith("37"))
            {
                // AMEX
                if (cardNumber.Length == 15)
                {
                    return CardType.AMEX;
                }
            }
            else if (cardNumber.StartsWith("6011"))
            {
                // Discover
                if (cardNumber.Length == 16)
                {
                    return CardType.Discover;
                }
            }
            else if (cardNumber.StartsWith("51") || cardNumber.StartsWith("52") ||
                     cardNumber.StartsWith("53") || cardNumber.StartsWith("54") ||
                     cardNumber.StartsWith("55"))
            {
                // MasterCard
                if (cardNumber.Length == 16)
                {
                    return CardType.MasterCard;
                }
            }
            else if (cardNumber.StartsWith("4"))
            {
                // Visa
                if (cardNumber.Length == 13 || cardNumber.Length == 16)
                {
                    return CardType.Visa;
                }
            }

            return CardType.Unknown;
        }
    }
}

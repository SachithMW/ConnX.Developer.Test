using ConnX.Bank.API.Models.Cards;
using ConnX.Bank.API.Models.Enums;
using ConnX.Bank.API.Repository.Cards.Type;
using ConnX.Bank.API.Repository.Cards.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnX.Bank.API.Repository.Cards
{
    public class Card : ICard
    {
        private ICardValidator _cardNumberValidator;
        private ICardTypeDetector _cardTypeDetector;

        public Card(ICardValidator cardNumberValidator, ICardTypeDetector cardTypeDetector)
        {
            _cardNumberValidator = cardNumberValidator;
            _cardTypeDetector = cardTypeDetector;
        }
        public CardDetailsResponse CardValidationDetails(string cardNumber)
        {
            var cardType = _cardTypeDetector.GetCardType(cardNumber);
            return new CardDetailsResponse
            {
                CardNumber = cardNumber,
                CardType = Enum.GetName(typeof(CardType), cardType),
                isValid = cardType != CardType.Unknown && _cardNumberValidator.IsValid(cardNumber)
            };
        }
    }
}

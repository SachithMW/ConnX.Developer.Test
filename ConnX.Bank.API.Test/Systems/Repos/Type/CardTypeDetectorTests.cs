using ConnX.Bank.API.Models.Enums;
using ConnX.Bank.API.Repository.Cards.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConnX.Bank.API.Test.Systems.Repos.Type
{
    public class CardTypeDetectorTests
    {
        [Fact]
        public void GetCardType_WithValidCardNumbers_ReturnsCorrectCardType()
        {
            // Arrange
            var cardTypeDetector = new CardTypeDetector();
            var testCases = new Dictionary<string, CardType>
            {
                { "4111111111111111", CardType.Visa },
                { "4111111111111", CardType.Visa },
                { "4012888888881881", CardType.Visa },
                { "378282246310005", CardType.AMEX },
                { "6011111111111117", CardType.Discover },
                { "5105105105105100", CardType.MasterCard },
                { "5105105105105106", CardType.MasterCard },
                { "9111111111111111", CardType.Unknown }
            };

            // Act and Assert
            foreach (var testCase in testCases)
            {
                var cardNumber = testCase.Key;
                var expectedCardType = testCase.Value;

                var actualCardType = cardTypeDetector.GetCardType(cardNumber);

                Assert.Equal(expectedCardType, actualCardType);
            }
        }
    }
}

using ConnX.Bank.API.Controllers;
using ConnX.Bank.API.Models.Cards;
using ConnX.Bank.API.Repository.Cards;
using Moq;
using System;
using Xunit;

namespace ConnX.Bank.API.Test.Systems.Controllers
{
    public class TestCardController
    {
        [Fact]
        public void TestGetCardDetails()
        {
            // Arrange
            var mockCard = new Mock<ICard>();
            mockCard.Setup(c => c.CardValidationDetails("378282246310005"))
                .Returns(new CardDetailsResponse
                {
                    CardNumber = "378282246310005",
                    isValid = true,
                    CardType = "VISA"
                });

            var controller = new CardController(mockCard.Object);

            // Act
            var result = controller.GetCardDetails(new CardDetailsRequest
            {
                CardNumber = "378282246310005"
            });

            // Assert
            //Assert.NotNull(result);
            Assert.Equal("378282246310005", result.CardNumber);
            Assert.True(result.isValid);
            Assert.Equal("VISA", result.CardType);
        }
    }
}

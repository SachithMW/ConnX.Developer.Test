using ConnX.Bank.API.Repository.Cards.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConnX.Bank.API.Test.Systems.Repos.Validation
{
    public class LuhnValidatorTests
    {
            [Theory]
            [InlineData("4111111111111111", true)]
            [InlineData("4111111111111", false)]
            [InlineData("4012888888881881", true)]
            [InlineData("378282246310005", true)]
            [InlineData("6011111111111117", true)]
            [InlineData("5105105105105100", true)]
            [InlineData("5105105105105106", false)]
            [InlineData("9111111111111111", false)]
            public void TestIsValid(string cardNumber, bool expected)
            {
                // Arrange
                var validator = new LuhnValidator();

                // Act
                var result = validator.IsValid(cardNumber);

                // Assert
                Assert.Equal(expected, result);
           }
    }
}

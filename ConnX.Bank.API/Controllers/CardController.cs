using ConnX.Bank.API.Models.Cards;
using ConnX.Bank.API.Repository.Cards;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnX.Bank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private ICard _card;


        public CardController(ICard card)
        {
            _card = card;
        }

        [HttpPost]
        [Route("cardData")]
        public CardDetailsResponse GetCardDetails([FromBody] CardDetailsRequest detailsRequest)
        {

            try
            {
                var cardDetails = _card.CardValidationDetails(detailsRequest.CardNumber);
                return cardDetails;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}

using ConnX.Bank.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnX.Bank.Web.Controllers
{
    public class CardController : Controller
    {
        private readonly CardDataService _cardDataService;

        public CardController(CardDataService cardDataService)
        {
            _cardDataService = cardDataService;
        }

        // GET: CardController
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(string cardNumber)
        {
            var cardData = await _cardDataService.GetCardData(cardNumber);
            return View(cardData);
        }
    }
}

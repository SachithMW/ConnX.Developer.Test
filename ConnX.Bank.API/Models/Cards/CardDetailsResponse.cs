using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnX.Bank.API.Models.Cards
{
    public class CardDetailsResponse
    {
        public string CardNumber { get; set; }
        public bool isValid { get; set; }
        public string CardType { get; set; }
    }
}

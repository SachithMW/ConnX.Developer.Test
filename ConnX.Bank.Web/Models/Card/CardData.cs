using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnX.Bank.Web.Models.Card
{
    public class CardData
    {
        public string CardNumber { get; set; }
        public bool IsValid { get; set; }
        public string CardType { get; set; }
    }
}

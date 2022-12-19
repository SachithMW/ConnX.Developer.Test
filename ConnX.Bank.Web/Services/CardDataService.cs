using ConnX.Bank.Web.Models.Card;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConnX.Bank.Web.Services
{
    public class CardDataService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;

        public CardDataService(HttpClient httpClient , IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<CardData> GetCardData(string cardNumber)
        {
            try
            {
                var requestBody = new { cardNumber };
                var requestJson = JsonConvert.SerializeObject(requestBody);
                var URL = _configuration.GetValue<string>("CardAPI") + "Card/cardData";
                var response = await _httpClient.PostAsync(URL , new StringContent(requestJson, Encoding.UTF8, "application/json"));
                var responseJson = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<CardData>(responseJson);
            }
            catch (Exception ex)
            {
                //logging
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

using Cocktail_Api.Models;
using System.Text.Json;

namespace Cocktail_Api.Services
{
    public class Cocktail_Service  
    {   
        private readonly CocktailDbContext _db;
        private readonly HttpClient _http;

        public Cocktail_Service(CocktailDbContext db, HttpClient http)
        {
            _db = db;
            _http = http;
        }

        public async Task<List<Drink>> GetRandomCocktail()
        {
            var result = JsonSerializer.Deserialize<DrinkListModel>(await _http.GetStringAsync("random.php"));
            var drinkTitle = result.drinks[0].strDrink;
            return result.drinks;
        }

    }
}

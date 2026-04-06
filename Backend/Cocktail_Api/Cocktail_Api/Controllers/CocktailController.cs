using Cocktail_Api.Models;
using Cocktail_Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cocktail_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocktailController : ControllerBase
    {
        private readonly CocktailDbContext _context;
        private readonly Cocktail_Service _service;
        public CocktailController(CocktailDbContext context, Cocktail_Service service)
        {
            _context = context;
            _service = service;
        }

        [HttpGet]
        [Route("GetCocktails")]
        public async Task<ActionResult> GetCocktails()
        {
            return Ok(await _service.GetRandomCocktail());
        }
    }
}

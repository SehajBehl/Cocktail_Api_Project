using Microsoft.EntityFrameworkCore;

namespace Cocktail_Api.Models
{
    public class CocktailDbContext: DbContext
    {
        public CocktailDbContext(DbContextOptions<CocktailDbContext> options) : base(options)
        {
        }

        public DbSet<DrinkListModel> Cocktails { get; set; }
    }
}

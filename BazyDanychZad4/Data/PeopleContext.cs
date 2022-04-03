using BazyDanychZad4.Models;
using Microsoft.EntityFrameworkCore;

namespace BazyDanychZad4.Data
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public PeopleContext(DbContextOptions options) : base(options) { }
    }

}

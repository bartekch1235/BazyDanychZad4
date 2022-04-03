using BazyDanychZad4.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BazyDanychZad4.Models;

namespace BazyDanychZad4.Pages
{
    public class bazaModel : PageModel
    {
        private readonly PeopleContext _context;
        public Person Person { get; set; }
        public bazaModel( PeopleContext context)
        {
            
            _context = context;
        }

        public IList<Person> People { get; set; }
        public void OnGet()
        {
            People = _context.Person.ToList();
        }

    }
}

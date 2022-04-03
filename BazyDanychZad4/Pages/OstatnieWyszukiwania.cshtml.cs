using BazyDanychZad4.Data;
using BazyDanychZad4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BazyDanychZad4.Pages
{
    public class OstatnieWyszukiwaniaModel : PageModel
    {
        private readonly PeopleContext _context;
        public Person Person { get; set; }
        public int counter;
        public OstatnieWyszukiwaniaModel(PeopleContext context)
        {

            _context = context;
        }

        public IList<Person> People { get; set; }
        public void OnGet()
        {
            counter = 0;
            People = _context.Person.ToList();
            People=People.OrderBy(p => p.Year).ToList();
        }
    }
}

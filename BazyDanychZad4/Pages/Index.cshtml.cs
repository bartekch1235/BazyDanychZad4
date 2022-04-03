using BazyDanychZad4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BazyDanychZad4.Data;

namespace BazyDanychZad4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext _context;
        public IList<Person> People { get; set; }
        public IndexModel(ILogger<IndexModel> logger, PeopleContext context)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {

        }
        [BindProperty]
        public Person Person { get; set; }
        public IActionResult OnPost()
        {
            Person.CzyPrzestepca();
            Person.PostDate = DateTime.Now.ToString();
            People = _context.Person.ToList();
            if (Person.FirstName!=null&&Person.Year>1950&&Person.Year<2022)
            {
                _context.Person.Add(Person);
                _context.SaveChanges();
                return RedirectToPage("./baza");
            }
            return Page();
            
        }

    }
}
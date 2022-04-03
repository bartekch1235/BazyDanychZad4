using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BazyDanychZad4.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; }


        public string? LastName { get; set; }
        public string Przestepca { get; set; }

        [Required,Range(1950,2022,ErrorMessage ="Prosze podac wartosc w zakresie od 1950 do 2022")]
        public int Year { get; set; }
        public string PostDate { get; set; }
        public Person()
        {
            Year = 0;
            LastName = "Nie podano nazwiska";
            Przestepca = "blad";
        }
        public void CzyPrzestepca()
        {
            if (Year % 4 == 0)
                Przestepca = "Przestepca";
            else
                Przestepca = "----------";
        }
       
    }
}

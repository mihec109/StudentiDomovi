using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Models
{
    public class Studenti
    {
        public long Id { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public int Vpisna_stevilka { get; set; }
    }

    public class Domovi
    {
        public int Leto_zgradnje { get; set; }
        public int Stevilka { get; set; }
        public string Naslov { get; set; }
    }

    public class Uporabniki
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

    public class Oseba
    {        
        [Required(ErrorMessage = "Pomembno polje")] [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Polje mora biti crka")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Pomembno polje")] [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Polje mora biti crka")]
        public string Priimek { get; set; }
        [Required(ErrorMessage = "Pomembno polje")] [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")] [Range(typeof(DateTime), "1/1/1900", "22/03/2022", ErrorMessage = "Napacn format datuma")]
        public DateTime Datum_rojstva { get; set; }
        [Required(ErrorMessage = "Pomembno polje")]
        public string Kraj_rojstva { get; set; }
        [Required(ErrorMessage = "Pomembno polje")] [StringLength(13, MinimumLength = 13, ErrorMessage = "Napacen emso")]
        public string EMSO { get; set; }
        [Required(ErrorMessage = "Pomembno polje")] [DataType(DataType.EmailAddress, ErrorMessage = "Polje mora biti email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pomembno polje")]
        public string geslo1 { get; set; }
        [Required(ErrorMessage = "Pomembno polje")]
        public string geslo2 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBlazorApp.Classes.Personal
{
    public class Personal
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        public string Surname { get; set; }
    }
}

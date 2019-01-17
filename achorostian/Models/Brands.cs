using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace achorostian.Models
{
    public class Brand
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Display(Name = "Producent")]
        public string Name { get; set; }

        [Required]
        [Range(1800, 2020)]
        [Display(Name = "Rok założenia")]
        public int Year { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
    }
}

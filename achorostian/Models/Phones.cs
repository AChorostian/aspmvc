using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace achorostian.Models
{
    public class Phone
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Required]
        [Range(1900, 2020)]
        [Display(Name = "Rok produkcji")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Cena")]
        public long Price { get; set; }

        [Required]
        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        [Display(Name = "Producent")]
        public virtual Brand Brand { get; set; }
    }

    public class DefaultConnection : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
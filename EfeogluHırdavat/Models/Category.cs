using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfeogluHırdavat.Models
{
    public class Category
    {
        public Category() { IsActive = true; }
        public int ID { get; set; }

        [Display(Name = "Kategori")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength:100, ErrorMessage = "Bu alan alan en fazla 75 karakter olmalıdır")]
        public string Name { get; set; }

        [Display(Name="Aktif")]
        public bool IsActive { get; set; }

        [Display(Name="Silindi")]
        public bool IsDeleted { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfeogluHırdavat.Models
{
    public class Brand
    {
        public Brand() { IsActive = true; }
        public int ID { get; set; }

        [Display(Name="Marka")]
        [StringLength(maximumLength:100, ErrorMessage = "Bu alan en fazla 100 karakter olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Name { get; set; }

        [Display(Name ="Logo")]
        public string Logo { get; set; }

        [Display(Name = "Aktif")]
        public bool IsActive { get; set; }

        [Display(Name = "Silindi")]
        public bool IsDeleted { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
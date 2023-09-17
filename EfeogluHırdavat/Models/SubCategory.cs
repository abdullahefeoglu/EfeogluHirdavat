using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace EfeogluHırdavat.Models
{
    public class SubCategory
    {
        public int ID { get; set; }

        [Display(Name = "Kategori")]
        public int? Category_ID { get; set; }

        [ForeignKey("Category_ID")]
        [Display(Name = "Kategori")]
        public virtual Category Category { get; set; }

        [Display(Name = "Alt Kategori")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 100, ErrorMessage = "Bu alan alan en fazla 75 karakter olmalıdır")]
        public string Name { get; set; }

        [Display(Name = "Aktif")]
        public bool IsActive { get; set; }

        [Display(Name = "Silindi")]
        public bool IsDeleted { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
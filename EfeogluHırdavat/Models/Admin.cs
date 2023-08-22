using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfeogluHırdavat.Models
{
    public class Admin
    {
        public Admin() { IsActive = true; IsAdmin = false; }
        public int ID { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur!")]
        [Display(Name = "Isim")]
        [StringLength(maximumLength: 50, ErrorMessage = "En fazla 75 karakter olmalıdır.")]
        public string Name { get; set; }

        [Display(Name = "Soyisim")]
        [StringLength(maximumLength: 50, ErrorMessage = "En fazla 75 karakter olmalıdır.")]
        public string Surname { get; set; }

        [Display(Name = "E-mail")]
        [StringLength(maximumLength: 200, ErrorMessage = "Bu alan 200 karakter olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Mail { get; set; }

        [Display(Name = "Şifre")]
        [StringLength(maximumLength:22,MinimumLength = 3, ErrorMessage = "Bu alan en az 3, en fazla 22 karakter olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        [Display(Name = "Aktif")]
        public bool IsActive { get; set; }

        [Display(Name = "Silindi")]
        public bool IsDeleted { get; set; }
    }
}
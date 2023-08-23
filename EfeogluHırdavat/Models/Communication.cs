using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfeogluHırdavat.Models
{
    public class Communication
    {
        public int ID { get; set; }

        [Display(Name = "İsminiz")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "Bu alan en fazla 50 karakter olmalıdır")]
        public string Name { get; set; }

        [Display(Name = "Soy İsminiz")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 50, ErrorMessage = "Bu alan en fazla 50 karakter olmalıdır")]
        public string Surname { get; set; }

        [Display(Name = "Telefon")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 13, ErrorMessage = "Bu alan en fazla 13 karakter olmalıdır")]
        public Int16 PhoneNumber { get; set; }

        [Display(Name = "E-Mail")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 100, ErrorMessage = "Bu alan en fazla 100 karakter olmalıdır")]
        public string Mail { get; set; }

        [Display(Name = "Mesajınız")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 2000, ErrorMessage = "Bu alan en fazla 2000 karakter olmalıdır")]
        public string Message { get; set; }

        [Display(Name = "Doğrulama Kodu")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string VerificationCode { get; set; }
    }
}
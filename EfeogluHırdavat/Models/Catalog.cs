﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfeogluHırdavat.Models
{
    public class Catalog
    {
        public int ID { get; set; }

        [Display(Name = "Katalog")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 100, ErrorMessage = "Bu alan en fazla 100 karakter olmalıdır")]
        public string Name { get; set; }

        [Display(Name = "Katalog Resmi")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 200, ErrorMessage = "Bu alan en fazla 200 karakter olmalıdır")]
        public string Image { get; set; }

        [Display(Name = "Aktif")]
        public bool IsActive { get; set; }

        [Display(Name = "Silinmiş")]
        public bool IsDeleted { get; set; }
    }
}
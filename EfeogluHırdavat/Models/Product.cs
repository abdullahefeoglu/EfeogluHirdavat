using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace EfeogluHırdavat.Models
{
    public class Product
    {
        public Product() {InStock = true;}
        public int ID { get; set; }

        [Display(Name = "Kategori")]
        public int? Category_ID { get; set; }

        [ForeignKey("Category_ID")]
        [Display(Name = "Kategori")]
        public virtual Category Category { get; set; }

        [Display(Name = "Marka")]
        public int? Brand_ID { get; set; }

        [ForeignKey("Brand_ID")]
        [Display(Name = "Marka")]
        public virtual Brand Brand { get; set; }

        [Display(Name = "Ürün")]
        [StringLength(maximumLength:200, ErrorMessage = "Bu alan en fazla 200 karakter olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Name { get; set; }

        [Display(Name = "Fiyat")]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal Price { get; set; }

        [Display(Name = "Stok Durumu")]
        public bool InStock { get; set; }

        [Display(Name = "Stok")]
        public int Stock { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "BU alan zorunludur")]
        [StringLength(maximumLength:250, ErrorMessage = "Bu alan en fazla 250 karakter olmalıdır.")]
        public string Description { get; set; }

        [Display(Name = "Ürün Resmi")]
        [StringLength(maximumLength: 100, ErrorMessage = "100 karakter veya daha düşük olmalıdır")]
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }

        [Display(Name = "Liste Resmi")]
        [StringLength(maximumLength: 100, ErrorMessage = "100 karakter veya daha düşük olmalıdır")]
        [DataType(DataType.ImageUrl)]
        public string ListImage { get; set; }

        [Display(Name = "Önerilen")]
        public bool IsRecent { get; set; }

        [Display(Name = "Silinmiş")]
        public bool IsDeleted { get; set; }
    }
}
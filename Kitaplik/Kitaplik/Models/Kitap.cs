using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kitaplik.Models
{
    public class Kitap
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(100,ErrorMessage ="{0} alanı en fazla 100 karakter olabilir"),Display(Name ="Kitap Adı")]
        public string Ad { get; set; }
        [Required, StringLength(100, ErrorMessage = "{0} alanı en fazla 100 karakter olabilir"), Display(Name = "Kitap Yazarı")]
        public string Yazari { get; set; }
        [Required, StringLength(50, ErrorMessage = "{0} alanı en fazla 50 karakter olabilir"), Display(Name = "Kitap Kategori")]
        public string Kategori { get; set; }
        [Required, StringLength(150, ErrorMessage = "{0} alanı en fazla 150 karakter olabilir"), Display(Name = "Kitap Yayın Evi")]
        public string YayinEvi { get; set; }
        [Required, Range(1800,2020,ErrorMessage ="{0} alanı 1800-2020 arası olabilir"), Display(Name = "Kitap Basım Yılı")]
        public int BasimYili { get; set; }

    }
}
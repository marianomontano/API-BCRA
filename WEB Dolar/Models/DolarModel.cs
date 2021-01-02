using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB_Dolar.Models
{
    public class DolarModel
    {
        [Display(Name ="Fecha")]
        public DateTime D { get; set; }

        [Display(Name ="Valor")]
        public decimal V { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiAngular.Controllers
{
    public class TdLogErreur
    {
        [Key]
        public int IdTdLogErreur { get; set; }
        [Required]
        public DateTime DateErreur { get; set; }
        [MaxLength(2000), Required]
        public string Erreur { get; set; }
        [MaxLength(100), Required]
        public string FonctionErreur { get; set; }
        [MaxLength(100), Required]
        public string PageErreur { get; set; }
    }
}
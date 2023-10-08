using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ApiAngular.Models
{
    public class Personne
    {
        [Key]
        public int id { get; set; }

        [MaxLength(150)]
        public string firstName { get; set; }

        [MaxLength(80)]
        public string lastName { get; set; }

        [MaxLength(50)]
        public string adress { get; set; }

        [MaxLength(50)]
        public string birthDay { get; set; }

        [MaxLength(15)]
        public string phone { get; set; }
    }
}
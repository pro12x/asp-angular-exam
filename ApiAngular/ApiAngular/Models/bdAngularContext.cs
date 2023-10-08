using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ApiAngular.Controllers;

namespace ApiAngular.Models
{
    public class bdAngularContext : DbContext
    {

        public bdAngularContext() : base("connApiAngular")
        {

        }
        public DbSet<Personne> personnes { get; set; }
        public DbSet<TdLogErreur> tdLogErreurs { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ProyectoMicro.Models
{
    public class Parametro
    {
        public int ID { get; set; }
        public float temperatura { get; set; }
        public float humedad { get; set; }
        public int riego { get; set; }
        public int iluminacion { get; set; }
    }
    public class ParametroDBContext : DbContext
    {
        public DbSet<Parametro> Parametros { get; set; }
    }
}
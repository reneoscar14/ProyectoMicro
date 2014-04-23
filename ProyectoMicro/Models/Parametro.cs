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
        public string Modo_Operacion { get; set; }
        public float Temperatura { get; set; }
        public float Humedad { get; set; }
        public string Riego { get; set; }
        public string Iluminacion { get; set; }
        public string Ventilador_Aire { get; set; }
        public string Extractor_Aire { get; set; }
        public DateTime LastChange { get; set; }

    }
    public class ParametroDBContext : DbContext
    {
        public DbSet<Parametro> Parametros { get; set; }
    }
}
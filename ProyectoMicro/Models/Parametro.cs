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
        public string Cultivo { get; set; }
        public string Modo { get; set; }
        public float Temperatura { get; set; }
        public float Humedad { get; set; }
        public string Calefaccion { get; set; }
        public string Ventilador { get; set; }
        public string Extractor { get; set; }
        public string Iluminacion { get; set; }
        public string Riego { get; set; }
        public string Condicion_Riego { get; set; }
        public int Temporizador_Riego { get; set; }
        public DateTime Actualizado { get; set; }

    }
    public class ParametroDBContext : DbContext
    {
        public DbSet<Parametro> Parametros { get; set; }
    }
}
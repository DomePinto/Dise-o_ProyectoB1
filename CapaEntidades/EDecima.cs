using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EDecima
    {
        public int Id { get; set; }
        public DateTime fecha {  get; set; }
        public string comentario { get; set; }

        public double valor { get; set; }

        

        
        public EDecima() 
        {
            Id = 0;
            fecha = DateTime.Now;
            comentario = "Sin comentario";
            valor = 0.1;
        }

        // Constructor con parámetros
        public EDecima(int id,DateTime fecha, string comentario, double valor)
        {
            this.Id = id;
            this.fecha = fecha;
            this.comentario = comentario;
            this.valor = valor;
        }

        // Método ToString para mostrar la información
        public override string ToString()
        {
            return $"{fecha.ToShortDateString()} - {valor:F1} décimas - {comentario}";
        }
    }
}

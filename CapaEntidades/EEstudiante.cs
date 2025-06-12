using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EEstudiante
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public List<EDecima> decimasExtras { get; set; }

        public EEstudiante()
        {
            decimasExtras = new List<EDecima>();
        }

        // Constructor con parámetros
        public EEstudiante(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.decimasExtras = new List<EDecima>();
        }

        // Método ToString para mostrar la información
        public override string ToString()
        {
            return $"Código: {codigo} - Nombre: {nombre} - Décimas: {decimasExtras.Count}";
        }
    }
}

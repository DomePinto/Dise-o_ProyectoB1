using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class EEstudiante
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        private List<EDecima> decimasExtras { get; set; }

        public EEstudiante()
        {
            decimasExtras = new List<EDecima>();
        }

        // Constructor con parámetros
        public EEstudiante(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.decimasExtras = new List<EDecima>();
        }

        // Método ToString para mostrar la información
        public override string ToString()
        {
            return $"ID: {id} - Nombre: {nombre} - Décimas: {decimasExtras.Count}";
        }
    }
}

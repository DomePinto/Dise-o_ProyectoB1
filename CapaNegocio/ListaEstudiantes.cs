using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaNegocio
{
    public class ListaEstudiantes
    {
        private List<EEstudiante> estudiantes = new List<EEstudiante>();

        public void AgregarEstudiante(EEstudiante estudiante)
        {
            estudiantes.Add(estudiante);
        }

        public bool EliminarEstudiante(int codigo)
        {
            var est = estudiantes.FirstOrDefault(e => e.codigo == codigo);
            if (est != null)
            {
                estudiantes.Remove(est);
                return true;
            }
            return false;
        }

        public List<EEstudiante> ObtenerTodos()
        {
            return estudiantes;
        }

        public EEstudiante BuscarEstudiante(int codigo)
        {
            return estudiantes.FirstOrDefault(e => e.codigo == codigo);
        }
    }
}

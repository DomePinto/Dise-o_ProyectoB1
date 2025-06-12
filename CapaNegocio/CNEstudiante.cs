using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaNegocio
{
    public class CNEstudiante
    {
        private ListaEstudiantes lista;

        public CNEstudiante()
        {
            lista = new ListaEstudiantes();
        }

        public bool AgregarEstudiante(int codigo, string nombre, out string comentario)
        {
            if (lista.BuscarEstudiante(codigo) != null)
            {
                comentario = "Ya existe un estudiante con ese código.";
                return false;
            }

            lista.AgregarEstudiante(new EEstudiante(codigo, nombre));
            comentario = "Estudiante agregado correctamente.";
            return true;
        }

        public bool EliminarEstudiante(int codigo, out string comentario)
        {
            bool resultado = lista.EliminarEstudiante(codigo);
            comentario = resultado ? "Estudiante eliminado." : "Estudiante no encontrado.";
            return resultado;
        }

        public EEstudiante Buscar(int codigo)
        {
            return lista.BuscarEstudiante(codigo);
        }

        public List<EEstudiante> ObtenerEstudiantes()
        {
            return lista.ObtenerTodos();
        }

        public ListaEstudiantes ObtenerListaEstudiantes()
        {
            return lista; 
        }
    }
}

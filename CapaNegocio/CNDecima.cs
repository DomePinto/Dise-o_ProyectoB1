using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaNegocio
{
    public class CNDecima
    {
        private ListaEstudiantes lista;

        public CNDecima(ListaEstudiantes listaEstudiantes)
        {
            this.lista = listaEstudiantes;
        }

        public bool AgregarDecima(int codigoEstudiante, int idDecima, DateTime fecha, string comentario, double valor, out string mensaje)
        {
            var estudiante = lista.BuscarEstudiante(codigoEstudiante);
            if (estudiante == null)
            {
                mensaje = "Estudiante no encontrado.";
                return false;
            }

            if (valor <= 0 || valor > 1)
            {
                mensaje = "El valor debe estar entre 0.1 y 1.";
                return false;
            }

            estudiante.decimasExtras.Add(new EDecima(idDecima, fecha, comentario, valor));
            mensaje = "Décima agregada.";
            return true;
        }

        public bool EliminarDecima(int codigoEstudiante, int idDecima, out string mensaje)
        {
            var estudiante = lista.BuscarEstudiante(codigoEstudiante);
            if (estudiante == null)
            {
                mensaje = "Estudiante no encontrado.";
                return false;
            }

            var decima = estudiante.decimasExtras.FirstOrDefault(d => d.id == idDecima);
            if (decima == null)
            {
                mensaje = "Décima no encontrada.";
                return false;
            }

            estudiante.decimasExtras.Remove(decima);
            mensaje = "Décima eliminada.";
            return true;
        }

        public bool ModificarDecima(int codigoEstudiante, int idDecima, DateTime nuevaFecha, string nuevoComentario, double nuevoValor, out string mensaje)
        {
            var estudiante = lista.BuscarEstudiante(codigoEstudiante);
            if (estudiante == null)
            {
                mensaje = "Estudiante no encontrado.";
                return false;
            }

            var decima = estudiante.decimasExtras.FirstOrDefault(d => d.id == idDecima);
            if (decima == null)
            {
                mensaje = "Décima no encontrada.";
                return false;
            }

            if (nuevoValor <= 0 || nuevoValor > 1)
            {
                mensaje = "El valor debe estar entre 0.1 y 1.";
                return false;
            }

            decima.fecha = nuevaFecha;
            decima.comentario = nuevoComentario;
            decima.valor = nuevoValor;

            mensaje = "Décima modificada.";
            return true;
        }

        public List<EDecima> ObtenerDecimas(int codigoEstudiante)
        {
            var estudiante = lista.BuscarEstudiante(codigoEstudiante);
            return estudiante?.decimasExtras ?? new List<EDecima>();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CNEstudiante NegocioEstudiante;
        CNDecima NegocioDecima;
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            NegocioEstudiante = new CNEstudiante();
            NegocioDecima = new CNDecima(NegocioEstudiante.ObtenerListaEstudiantes());

            // Opcional: mostrar estudiantes al cargar
            ActualizarListaEstudiantes();
        }

        private void ActualizarListaEstudiantes()
        {
            lbEstudiantes.Items.Clear();

            lbEstudiantes.Items.Clear();

            foreach (var estudiante in NegocioEstudiante.ObtenerEstudiantes())
            {
                // Línea principal del estudiante
                lbEstudiantes.Items.Add(estudiante);

                // Agregar detalle de cada décima (si tiene)
                if (estudiante.decimasExtras.Count > 0)
                {
                    foreach (var decima in estudiante.decimasExtras)
                    {
                        string detalleDecima = $"    -> [{decima.comentario}] - {decima.valor:F1} - {decima.fecha.ToShortDateString()}";
                        lbEstudiantes.Items.Add(detalleDecima);
                    }
                }
            }
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            mtbCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string textoCodigo = mtbCodigo.Text.Trim();

            if (!mtbCodigo.MaskCompleted)
            {
                MessageBox.Show("Debe ingresar exactamente 9 dígitos.");
                return;
            }

            if (!int.TryParse(textoCodigo, out int codigo))
            {
                MessageBox.Show("El código ingresado no es un número válido.");
                return;
            }

            string nombre = txtNombreEstudiante.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe ingresar el nombre del estudiante.");
                return;
            }

            string mensaje;
            bool agregado = NegocioEstudiante.AgregarEstudiante(codigo, nombre, out mensaje);
            MessageBox.Show(mensaje);

            if (agregado)
            {
                ActualizarListaEstudiantes();

            }

        }




        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBuscar.Text.Trim(), out int codigo))
            {
                MessageBox.Show("El código debe ser un número válido.");
                return;
            }

            var estudiante = NegocioEstudiante.Buscar(codigo);

            if (estudiante != null)
            {
                MessageBox.Show($"Estudiante encontrado:\nNombre: {estudiante.nombre} \nCódigo: {estudiante.codigo}\nDécimas: {estudiante.decimasExtras.Count}");
                lbEstudiantes.SelectedItem = estudiante;
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado.");
            }
        }



        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = "EstudiantesConDecimas.xlsx";

                using (var workbook = new XLWorkbook())
                {
                    var hoja = workbook.Worksheets.Add("Estudiantes");

                    // Cabeceras
                    hoja.Cell(1, 1).Value = "Código";
                    hoja.Cell(1, 2).Value = "Nombre";
                    hoja.Cell(1, 3).Value = "Apellido";
                    hoja.Cell(1, 4).Value = "Cantidad de Décimas";
                    hoja.Row(1).Style.Font.Bold = true;

                    int fila = 2;

                    foreach (var item in lbEstudiantes.Items)
                    {
                        if (item is EEstudiante est && est.decimasExtras != null && est.decimasExtras.Count > 0)
                        {
                            hoja.Cell(fila, 1).Value = est.codigo;
                            hoja.Cell(fila, 2).Value = est.nombre;
                            hoja.Cell(fila, 4).Value = est.decimasExtras.Count;
                            fila++;
                        }
                    }

                    // Guardar archivo
                    workbook.SaveAs(ruta);
                }

                MessageBox.Show("Informe Excel generado correctamente en:\n" + Path.GetFullPath(ruta));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar Excel: " + ex.Message);
            }
        }

        private void btnAgregarDecima_Click(object sender, EventArgs e)
        {
            if (lbEstudiantes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estudiante.");
                return;
            }

            EEstudiante estudianteSeleccionado = (EEstudiante)lbEstudiantes.SelectedItem;

            string motivo = txtMotivo.Text.Trim();
            DateTime fecha = mthCalendario.SelectionStart;

            double valor = 0.1; 
            int idDecima = estudianteSeleccionado.decimasExtras.Count + 1;

            string mensaje;
            bool agregado = NegocioDecima.AgregarDecima(estudianteSeleccionado.codigo, idDecima, fecha, motivo, valor, out mensaje);

            MessageBox.Show(mensaje);

            if (agregado)
            {
                ActualizarListaEstudiantes(); // <- aquí es donde actualizas el ListBox
                txtMotivo.Clear();
            }
        }

        private void btnEliminarDecima_Click(object sender, EventArgs e)
        {
            // Verificar si es una línea de décima (string que empieza con "    ->")
            if (lbEstudiantes.SelectedItem is string linea && linea.TrimStart().StartsWith("->"))
            {
                // Buscar el estudiante correspondiente
                int indexSeleccionado = lbEstudiantes.SelectedIndex;

                // Buscar hacia arriba el estudiante (la primera línea anterior que sea un EEstudiante)
                for (int i = indexSeleccionado - 1; i >= 0; i--)
                {
                    if (lbEstudiantes.Items[i] is EEstudiante estudiante)
                    {
                        // Extraer el motivo de la línea seleccionada
                        string textoLinea = linea.Trim();
                        int inicioMotivo = textoLinea.IndexOf('[') + 1;
                        int finMotivo = textoLinea.IndexOf(']');
                        string motivoSeleccionado = textoLinea.Substring(inicioMotivo, finMotivo - inicioMotivo);

                        // Encontrar la décima en el estudiante con ese motivo
                        var decima = estudiante.decimasExtras.FirstOrDefault(d => d.comentario == motivoSeleccionado);

                        if (decima != null)
                        {
                            string mensaje;
                            bool eliminado = NegocioDecima.EliminarDecima(estudiante.codigo, decima.id, out mensaje);

                            MessageBox.Show(mensaje);

                            if (eliminado)
                            {
                                ActualizarListaEstudiantes();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo encontrar la décima a eliminar.");
                        }

                        return;
                    }
                }

                MessageBox.Show("No se encontró el estudiante correspondiente.");
            }
            else
            {
                MessageBox.Show("Seleccione una línea de décima para eliminar.");
            }
        }

        
    }
}

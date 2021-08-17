using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modulo_Docente
{
    public partial class FrmDocenteEliminar : Form
    {
        List<Object> lst_docente_tmp;
        ClsDocente docente = new ClsDocente();
        public FrmDocenteEliminar(List<Object> lst_docente_tmp)
        {
            InitializeComponent();
            this.lst_docente_tmp = lst_docente_tmp;
            llenar_tabla();
        }

        public void llenar_tabla()
        {
            dgv_listar_docentes.Rows.Clear();
            dgv_listar_docentes.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var docente in lst_docente_tmp)
            {
                System.Type type = docente.GetType();

                String cedula = (String)type.GetProperty("cedula").GetValue(docente);
                String nombres = (String)type.GetProperty("nombres").GetValue(docente);
                String apellidos = (String)type.GetProperty("apellidos").GetValue(docente);
                String estado_civil = (String)type.GetProperty("estado_civil").GetValue(docente);
                String sexo = (String)type.GetProperty("sexo").GetValue(docente);
                Int16 edad = (Int16)type.GetProperty("edad").GetValue(docente);
                String pais = (String)type.GetProperty("nacionalidad").GetValue(docente);
                String provincia = (String)type.GetProperty("provincia").GetValue(docente);
                String canton = (String)type.GetProperty("canton").GetValue(docente);
                String titulo = (String)type.GetProperty("titulo").GetValue(docente);

                dgv_listar_docentes.Rows.Add(cedula, nombres, apellidos, estado_civil, sexo, edad, pais, provincia, canton, titulo);
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //obtener la cedula de la tabla
            try
            {
                    String cedula = this.dgv_listar_docentes.CurrentRow.Cells[0].Value.ToString();
                    MessageBox.Show(docente.Eliminar(cedula));
                    lst_docente_tmp = docente.listar();
                    dgv_listar_docentes.Rows.Clear();
                    llenar_tabla();
               
            }
            catch (System.NullReferenceException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgv_listar_docentes.Rows.Clear();

            foreach (var docente in lst_docente_tmp) {
                System.Type type = docente.GetType();
                String cedula = (String)type.GetProperty("cedula").GetValue(docente);
                if (txtCedula.Text.Equals(cedula)){
                    String nombres = (String)type.GetProperty("nombres").GetValue(docente);
                    String apellidos = (String)type.GetProperty("apellidos").GetValue(docente);
                    String estado_civil = (String)type.GetProperty("estado_civil").GetValue(docente);
                    String sexo = (String)type.GetProperty("sexo").GetValue(docente);
                    Int16 edad = (Int16)type.GetProperty("edad").GetValue(docente);
                    String pais = (String)type.GetProperty("nacionalidad").GetValue(docente);
                    String provincia = (String)type.GetProperty("provincia").GetValue(docente);
                    String canton = (String)type.GetProperty("canton").GetValue(docente);
                    String titulo = (String)type.GetProperty("titulo").GetValue(docente);

                    dgv_listar_docentes.Rows.Add(cedula, nombres, apellidos, estado_civil, sexo, edad, pais, provincia, canton, titulo);
                }
            

            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

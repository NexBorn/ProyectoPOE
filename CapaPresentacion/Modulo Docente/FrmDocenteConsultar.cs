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

namespace CapaPresentacion
{
    public partial class FrmDocenteConsultar : Form
    {
        List<Object> lst_docente_tmp;
        public FrmDocenteConsultar(List<Object> lst_docente_tmp)
        {
            InitializeComponent();
            this.lst_docente_tmp = lst_docente_tmp;
            llenar_tabla();
        }

        public void llenar_tabla() {
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
               
                dgv_listar_docentes.Rows.Add(cedula, nombres,apellidos, estado_civil, sexo, edad, pais, provincia, canton, titulo);               
            }
           


        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            llenar_tabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgv_listar_docentes.Rows.Clear();

            foreach (var docente in lst_docente_tmp)
            {
                System.Type type = docente.GetType();
                String cedula = (String)type.GetProperty("cedula").GetValue(docente);
                if (txtCedula.Text.Equals(cedula))
                {
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

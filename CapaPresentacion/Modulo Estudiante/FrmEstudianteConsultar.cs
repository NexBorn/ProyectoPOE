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
    public partial class FrmEstudianteConsultar : Form
    {
        
        List<Object> lst_estudiantes_tmp;
        public FrmEstudianteConsultar(List<Object> lst_estudiantes_tmp)
        {
            InitializeComponent();
            this.lst_estudiantes_tmp = lst_estudiantes_tmp;
            llenar_datagridview_estudiantes();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            llenar_datagridview_estudiantes();
        }

        public void llenar_datagridview_estudiantes()
        {
            dgvEstudiantes.Rows.Clear();
            dgvEstudiantes.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var estudiante in lst_estudiantes_tmp)
            {
                System.Type type = estudiante.GetType();

                String cedula = (String)type.GetProperty("cedula").GetValue(estudiante);
                String nombres = (String)type.GetProperty("nombres").GetValue(estudiante);
                String apellidos = (String)type.GetProperty("apellidos").GetValue(estudiante);
                Int16 edad = (Int16)type.GetProperty("edad").GetValue(estudiante);
                String direccion = (String)type.GetProperty("direccion").GetValue(estudiante);
                String sexo = (String)type.GetProperty("sexo").GetValue(estudiante);
                String nacionalidad = (String)type.GetProperty("nacionalidad").GetValue(estudiante);
                String representante = (String)type.GetProperty("representante").GetValue(estudiante);

                dgvEstudiantes.Rows.Add(cedula, nombres, apellidos,
                    edad, direccion, sexo, nacionalidad, representante);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String objetivo = txtCedula.Text;
            bool bandera = false;

            dgvEstudiantes.Rows.Clear();
            dgvEstudiantes.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var estudiante in lst_estudiantes_tmp)
            {
                System.Type type = estudiante.GetType();

                String cedula = (String)type.GetProperty("cedula").GetValue(estudiante);
                String nombres = (String)type.GetProperty("nombres").GetValue(estudiante);
                String apellidos = (String)type.GetProperty("apellidos").GetValue(estudiante);
                Int16 edad = (Int16)type.GetProperty("edad").GetValue(estudiante);
                String direccion = (String)type.GetProperty("direccion").GetValue(estudiante);
                String sexo = (String)type.GetProperty("sexo").GetValue(estudiante);
                String nacionalidad = (String)type.GetProperty("nacionalidad").GetValue(estudiante);
                String representante = (String)type.GetProperty("representante").GetValue(estudiante);

                if (cedula == objetivo)
                {
                    dgvEstudiantes.Rows.Add(cedula, nombres, apellidos,
                    edad, direccion, sexo, nacionalidad, representante);
                    bandera = true;
                }
                else
                {

                }   
            }
            if (bandera == false)
            {
                MessageBox.Show("Cédula no registrada!");
            }
        }
    }
}

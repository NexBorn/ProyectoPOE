using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace CapaPresentacion.Modulo_Curso
{
    public partial class FrmCursosList : Form
    {
        ClsCurso curso = new ClsCurso();
        public FrmCursosList()
        {
            InitializeComponent();
            addItemCursos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void cmbCursosList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void addItemCursos()
        {
            foreach (String i in curso.getListCursos())
            {
                cmbCursosList.Items.Add(i);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String curso =(String) cmbCursosList.SelectedItem;
            if (String.IsNullOrEmpty(curso))
            {
                MessageBox.Show("Selecciona un curso");
            }
            dgvEstudiantes.Rows.Clear();
            dgvEstudiantes.Refresh();

            //Se recorre la lista de objetos y se trabaja con los tipos de datos anonymus
            foreach (var docente in this.curso.listarEstudiantes(curso))
            {
                System.Type type = docente.GetType();

                String cedula = (String)type.GetProperty("cedula").GetValue(docente);
                String nombres = (String)type.GetProperty("nombres").GetValue(docente);
                String apellidos = (String)type.GetProperty("apellidos").GetValue(docente);
                Int16 edad = (Int16)type.GetProperty("edad").GetValue(docente);
                String sexo = (String)type.GetProperty("sexo").GetValue(docente);
                String nacionalidad = (String)type.GetProperty("nacionalidad").GetValue(docente);
                String representante = (String)type.GetProperty("representante").GetValue(docente);
                dgvEstudiantes.Rows.Add(cedula, nombres, apellidos, edad, sexo, nacionalidad, representante);
            }
        }
    }
}

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
    public partial class AgregarAlumno : Form
    {
        ClsCurso cusro = new ClsCurso();
        public AgregarAlumno()
        {
            InitializeComponent();
            generateList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarAE_Click(object sender, EventArgs e)
        {
            String estudiante = txtCedula.Text;
            String aula = (String)cmbCursos.SelectedItem;
            if (cusro.insertarAlumnoACurso(estudiante,aula))
            {
                MessageBox.Show("Se agrego correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un problema\n 1.- Quiazas ya existe el aulmno registrao 2.- o otro error inesperado");
            }
            
        }

        public void generateList()
        {
            foreach (String i in cusro.getListCursos())
            {
                cmbCursos.Items.Add(i);
            }
        }

        private void cmbEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

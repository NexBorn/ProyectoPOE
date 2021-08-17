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
    public partial class FrmEstudiante : Form
    {
        ClsEstudiante Al = new ClsEstudiante();
        List<Object> lst_estudiantes;
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String msj = "";
            try
            {

                Al.Cedula = txtCedula.Text;
                Al.Nombres = txtNombre.Text;
                Al.Apellidos = txtApellido.Text;
                Al.Edad = Int16.Parse(txtEdad.Text);
                Al.Direccion = txtDireccion.Text;
                Al.Sexo = cmbSexo.Text;
                Al.Nacionalidad = txtNacionalidad.Text;
                Al.Representante = txtRepresentante.Text;

                msj = Al.registrar();
                MessageBox.Show(msj);

                txtCedula.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
                txtDireccion.Text = "";
                cmbSexo.Text = "";
                txtNacionalidad.Text = "";
                txtRepresentante.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lst_estudiantes = Al.listar();
            FrmEstudianteConsultar frmest = new FrmEstudianteConsultar(lst_estudiantes);
            frmest.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lst_estudiantes = Al.listar();
            FrmEstudianteEliminar frmest = new FrmEstudianteEliminar(lst_estudiantes);
            frmest.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
            cmbSexo.Text = "";
            txtNacionalidad.Text = "";
            txtRepresentante.Text = "";
            pictureBox1.Image = null;
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtRepresentante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

       
    }
}

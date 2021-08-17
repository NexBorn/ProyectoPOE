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
using System.IO;

namespace CapaPresentacion
{
    public partial class FrmAgregarDocente : Form
    {
        List<Object> lst_docente;
        ClsDocente docente = new ClsDocente();

        public FrmAgregarDocente()
        {
            InitializeComponent();
        }

        private void FrmAgregarDocente_Load(object sender, EventArgs e)
        {
            ClsDatos datos = new ClsDatos();
            foreach (var nac in datos.GetNacionalidades()) {
               cmbPais.Items.Add(nac);    
            }
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCantones.Items.Clear();
            ClsDatos datos = new ClsDatos();
            switch (cmbProvincia.SelectedItem)
            {
                case "Azuay":
                    foreach (var nac in datos.GetCantonesAzuay())
                        lstCantones.Items.Add(nac);

                    break;
                case "Bolívar":
                    foreach (var nac in datos.GetCantonesBolivar())
                        lstCantones.Items.Add(nac);

                    break;
                case "Cañar":
                    foreach (var nac in datos.GetCantonesCaniar())
                        lstCantones.Items.Add(nac);

                    break;
                case "Carchi":
                    foreach (var nac in datos.GetCantonesCarchi())
                        lstCantones.Items.Add(nac);

                    break;
                case "Chimborazo":
                    foreach (var nac in datos.GetCantonesChimborazo())
                        lstCantones.Items.Add(nac);

                    break;
                case "Cotopaxi":
                    foreach (var nac in datos.GetCantonesCotopaxi())
                        lstCantones.Items.Add(nac);

                    break;
                case "El Oro":
                    foreach (var nac in datos.GetCantonesElOro())
                        lstCantones.Items.Add(nac);

                    break;
                case "Esmeraldas":
                    foreach (var nac in datos.GetCantonesEsmeralda())
                        lstCantones.Items.Add(nac);

                    break;
                case "Guayas":
                    foreach (var nac in datos.GetCantonesGuayas())
                        lstCantones.Items.Add(nac);

                    break;
                case "Manabí":
                    foreach (var nac in datos.GetCantonesManabi())
                        lstCantones.Items.Add(nac);

                    break;
                case "Pichincha":
                    foreach (var nac in datos.GetCantonesPichincha())
                        lstCantones.Items.Add(nac);

                    break;
                case "Los Ríos":
                    foreach (var nac in datos.GetCantonesLosRios())
                        lstCantones.Items.Add(nac);

                    break;
                default:
                    lstCantones.Items.Add("///////////////");
                    break;
            }

        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProvincia.Items.Clear();
            lstCantones.Items.Clear();
            ClsDatos datos = new ClsDatos();
            if (cmbPais.SelectedItem.Equals("Ecuador"))
            {
                foreach (var nac in datos.GetProvincias())
                    cmbProvincia.Items.Add(nac);

            }
            else if (cmbPais.SelectedItem.Equals("Colombia"))
            {
                foreach (var nac in datos.GetProvinciasColombia())
                    cmbProvincia.Items.Add(nac);
            }
            else {
                cmbProvincia.Items.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String msj;
            try
            {
                //Recoleccion de datos
                if (String.IsNullOrEmpty(txtCedula.Text)&& String.IsNullOrEmpty(txtApellidos.Text)&& String.IsNullOrEmpty(txtNombres.
                    Text)&& String.IsNullOrEmpty(txtEdad.Text)&& String.IsNullOrEmpty((String)cmbEstadoCivil.SelectedItem)&& String.IsNullOrEmpty(
                   (String)cmbMateria.SelectedItem)&& String.IsNullOrEmpty((String)cmbPais.SelectedItem)&& String.IsNullOrEmpty((String)cmbProvincia.
                    SelectedItem)&& String.IsNullOrEmpty((String)lstCantones.SelectedItem))
                    MessageBox.Show("Existen datos vacios");
                else
                {
                    docente.Cedula = txtCedula.Text;
                    docente.Nombres = txtNombres.Text;
                    docente.Apellidos = txtApellidos.Text;
                    docente.Estado_civil = (String)cmbEstadoCivil.SelectedItem;
                    if (rdbMasculino.Checked) {
                        docente.Sexo = rdbMasculino.Text; 
                    }
                    else {
                        docente.Sexo = rdbFemenino.Text; 
                    }
                    docente.Edad = Int16.Parse(txtEdad.Text);
                    docente.Nacionalidad = (String)cmbPais.SelectedItem;
                    docente.Provincia = (String)cmbProvincia.SelectedItem;
                    docente.Canton = (String)lstCantones.SelectedItem;
                    docente.Titulo = (String)cmbMateria.SelectedItem;


                    msj = docente.registrar();
                    MessageBox.Show(msj);
                    txtCedula.Text =null;
                    txtNombres.Text = null;
                    txtApellidos.Text = null;
                    txtEdad.Text = null;
                    cmbEstadoCivil.Text = null;
                    cmbMateria.Text = null;
                    cmbPais.Text="";
                    cmbProvincia.Text=null;
                    lstCantones.Items.Clear() ;
                    pictureBox1.Image = null;



                }
              
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            lst_docente = docente.listar();
            FrmDocenteConsultar frmDoc = new FrmDocenteConsultar(lst_docente);
            frmDoc.Show();

        }
        
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
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

        private void cmbEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }

        }

        private void rdbFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

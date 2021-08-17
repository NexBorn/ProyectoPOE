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
    public partial class FrmAgregarCurso : Form
    {
        ClsCurso curso = new ClsCurso();
        
        public FrmAgregarCurso()
        {
            InitializeComponent();
            addItemsCMB();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstCantones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void addItemsCMB()
        {
            foreach (String i in curso.getStringListDocente())
            {
                Maestros.Items.Add(i);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarAC_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCodigo.Text) && String.IsNullOrEmpty(txtNombCurso.Text) && String.IsNullOrEmpty((String)Maestros.SelectedItem))
                {
                    MessageBox.Show("Existen datos vacios");
                }
                else
                {
                    short codigo = short.Parse(txtCodigo.Text);
                    String nombreCurso = txtNombCurso.Text;
                    String maestro = (String)Maestros.SelectedItem;
                    new ClsCurso().insertarDatos(codigo,nombreCurso,maestro);
                    MessageBox.Show("Se creo el curso");
                }
            }
            catch (Exception eeve)
            {
                MessageBox.Show(eeve.Message);
            }
        }
    }
}

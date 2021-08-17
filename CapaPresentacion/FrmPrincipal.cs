using CapaLogicaNegocio;
using CapaPresentacion.Modulo_Curso;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiante frmest = new FrmEstudiante();
            frmest.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuIMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCurso2().Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDocente frmDoc = new FrmDocente();
            frmDoc.Show();
        }
    }
}

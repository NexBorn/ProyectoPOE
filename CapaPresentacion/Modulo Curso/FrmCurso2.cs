using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modulo_Curso
{
    public partial class FrmCurso2 : Form
    {
        public FrmCurso2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCurso2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmAgregarCurso().Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            new AgregarAlumno().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmEliminarEstud().Show();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            new FrmCursosList().Show();
        }
    }
}

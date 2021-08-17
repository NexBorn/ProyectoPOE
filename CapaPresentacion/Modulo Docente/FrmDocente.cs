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
using CapaPresentacion.Modulo_Docente;

namespace CapaPresentacion
{
    public partial class FrmDocente : Form
    {

        List<Object> lst_docente;
        ClsDocente docente = new ClsDocente();
        public FrmDocente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarDocente frmdoc = new FrmAgregarDocente();
            frmdoc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lst_docente = docente.listar();
            FrmDocenteConsultar frmDoc = new FrmDocenteConsultar(lst_docente);
            frmDoc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lst_docente = docente.listar();
            FrmDocenteEliminar frmelim = new FrmDocenteEliminar(lst_docente);
            frmelim.Show();

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDocente_Load(object sender, EventArgs e)
        {

        }
    }

}

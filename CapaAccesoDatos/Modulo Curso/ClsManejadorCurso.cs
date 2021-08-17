using System;
using CapaAccesoDatos.Modulo_Curso;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Modulo_Curso
{
    public class ClsManejadorCurso
    {

        List<ClsDatosCurso> listCurso = null;

        public static ClsManejadorCurso clsmanejadora = null;

        private ClsManejadorCurso()
        {
            listCurso = new List<ClsDatosCurso>();
        }
        public static ClsManejadorCurso getClsManejadora()
        {
            if (clsmanejadora == null)
            {
                clsmanejadora = new ClsManejadorCurso();
            }
            return clsmanejadora;
        }

        public List<ClsDatosCurso> getListaCursos()
        {
            return listCurso;
        }
    }
}

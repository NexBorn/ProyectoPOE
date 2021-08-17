using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos.Modulo_Docente;

namespace CapaAccesoDatos.Modulo_Curso
{
    public class ClsDatosCurso
    {
        private short codigo;
        private String nombreCurso;
        private ClsDatosDocente docente;
        private List<ClsDatosEstudiantes> estudiantes;


        public ClsDatosCurso(short codigo, String nombreCurso, ClsDatosDocente docente)
        {
            this.codigo = codigo;
            this.nombreCurso = nombreCurso;
            this.docente = docente;
            estudiantes = new List<ClsDatosEstudiantes>();
        }

        public short getCodigo()
        {
            return codigo;
        }

        public String getNombreCurso()
        {
            return nombreCurso;
        }

        public ClsDatosDocente getDocente()
        {
            return docente;
        }

        public List<ClsDatosEstudiantes> getEstudiantes()
        {
            return estudiantes;
        }
    }
}

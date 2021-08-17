using CapaAccesoDatos;
using CapaAccesoDatos.Modulo_Curso;
using CapaAccesoDatos.Modulo_Docente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class ClsCurso
    {
        ClsManejadorCurso instanceCurso = ClsManejadorCurso.getClsManejadora();
        ClsManejadorDoc instanceDoc = ClsManejadorDoc.getClsManejadora();
        ClsManejadora instanceEstu = ClsManejadora.getClsManejadora();

        public ClsCurso()
        {
        }
        public void insertarDatos(short codigo, String nombreCurso, String docente)
        {
            ClsDatosDocente docenteName = getDocenteToList(docente);
            if (docenteName!=null)
            {
                instanceCurso.getListaCursos().Add(new ClsDatosCurso(codigo, nombreCurso, docenteName));
                
            }
            
        }

        public Boolean insertarAlumnoACurso(String cedula,String aula)
        {
            ClsDatosEstudiantes estudiante = getEstudiante(cedula);
            if (estudiante != null)
            {
                foreach (ClsDatosCurso i in instanceCurso.getListaCursos())
                {
                    if (i.getNombreCurso().Equals(aula))
                    {
                        
                        foreach (ClsDatosEstudiantes j in i.getEstudiantes())
                        {
                            if (j.Equals(estudiante))
                            {
                                return false;
                            }
                        }
                        i.getEstudiantes().Add(estudiante);
                        return true;
                    }
                }
            }
            return false;
        }

        public List<ClsDatosDocente> getListaDeDoc()
        {
            return instanceDoc.getListaDocentes();
        }

        public ClsDatosDocente getDocenteToList(String nombre)
        {
            foreach (ClsDatosDocente i in instanceDoc.getListaDocentes())
            {
                if (i.Nombres.Equals(nombre))
                {
                    return i;
                }
            }
            return null;
        }

        public ClsDatosEstudiantes getEstudiante(String cedula)
        {
            foreach (ClsDatosEstudiantes i in instanceEstu.getListaEstudiantes())
            {
                if (cedula.Equals(i.Cedula))
                {
                    return i;
                }
            }
            return null;
        }

        public List<String> getStringListDocente()
        {
            List<String> newList = new List<string>();

            foreach (ClsDatosDocente i in instanceDoc.getListaDocentes())
            {
                newList.Add(i.Nombres);
            }
            return newList;
            
        }
         
        public List<String> getListCursos()
        {
            List<String> newList = new List<string>();

            foreach (ClsDatosCurso i in instanceCurso.getListaCursos())
            {
                newList.Add(i.getNombreCurso());
            }
            return newList;
        }

        public ClsDatosCurso getCurso(String nombre)
        {
            foreach (ClsDatosCurso i in instanceCurso.getListaCursos())
            {
                if (i.getNombreCurso().Equals(nombre))
                {
                    return i;
                }
            }
            return null;
        }

        public Boolean eliminarEstudiantedDelCurso(String cedula,String aula)
        {
            ClsDatosEstudiantes estudiante = getEstudiante(cedula);
            if (estudiante != null)
            {
                foreach (ClsDatosCurso i in instanceCurso.getListaCursos())
                {
                    if (i.getNombreCurso().Equals(aula))
                    {
                        foreach (ClsDatosEstudiantes j in i.getEstudiantes())
                        {
                            if (j.Equals(estudiante))
                            {
                                instanceEstu.getListaEstudiantes().Remove(estudiante);
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public List<Object> listarEstudiantes(String curso)
        {
            List<Object> lstDocente = new List<Object>();

            //Se crea un tipo de datos Anonymus para obtener los datos del estudiantes y
            //pasarlo como objetos a la Capa Lógica del negocio
            foreach (var estudiante in getCurso(curso).getEstudiantes())
            {
                var tmp = new
                {
                    cedula = estudiante.Cedula,
                    nombres = estudiante.Nombres,
                    apellidos = estudiante.Apellidos,
                    edad = estudiante.Edad,
                    direccion = estudiante.Direccion,
                    sexo = estudiante.Sexo,
                    nacionalidad = estudiante.Nacionalidad,
                    representante = estudiante.Representante
                };

                lstDocente.Add(tmp);
            }
            return lstDocente;
        }

    }
}

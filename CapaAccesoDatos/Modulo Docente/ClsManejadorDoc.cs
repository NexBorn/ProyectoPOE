using CapaAccesoDatos.Modulo_Docente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ClsManejadorDoc
    {
        List<ClsDatosDocente> datosDocentes = null;

        private static ClsManejadorDoc clsmanejadora = null;
        private ClsManejadorDoc()
        {
            datosDocentes = new List<ClsDatosDocente>();

        }
        public static ClsManejadorDoc getClsManejadora()
        {
            if (clsmanejadora == null)
            {
                clsmanejadora = new ClsManejadorDoc();
            }
            return clsmanejadora;
        }

        public List<ClsDatosDocente> getListaDocentes()
        {
            return datosDocentes;
        }

        //Método para insertar información

        public String insertar_docente(ClsParametros doc)
        {
            String mensaje = "";
            try
            {
                if (doc != null)
                {
                    datosDocentes.Add(new ClsDatosDocente(doc.Cedula, doc.Nombres, doc.Apellidos, doc.Estado_civil, doc.Sexo, doc.Edad, doc.Nacionalidad, doc.Provincia, doc.Canton, doc.Titulo));
                    mensaje = "Docente insertado ";
                }

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return mensaje;
        }
        public List<Object> listar_docente()
        {
            List<Object> lstDocente = new List<Object>();

            //Se crea un tipo de datos Anonymus para obtener los datos del estudiantes y
            //pasarlo como objetos a la Capa Lógica del negocio
            foreach (var docente in datosDocentes)
            {
                var tmp = new
                {
                    cedula = docente.Cedula,
                    nombres = docente.Nombres,
                    apellidos = docente.Apellidos,
                    estado_civil = docente.Estado_civil,
                    sexo = docente.Sexo,
                    edad = docente.Edad,
                    nacionalidad = docente.Nacionalidad,
                    provincia = docente.Provincia,
                    canton = docente.Canton,
                    titulo = docente.Titulo
                };

                lstDocente.Add(tmp);
            }
            return lstDocente;
        }
        public String eliminar_docente(String cedu) {
            String mensaje = "";
            //cree otro objeto porque no se puede eliminar un objeto de la lista
            //durante la ejecucion de un foreach
            ClsDatosDocente aux = new ClsDatosDocente();
            foreach (ClsDatosDocente doc in datosDocentes) {
                if (cedu.Equals(doc.Cedula)) {
                    aux = doc;
                    mensaje = "Docente eliminado correctamente";
                }
            }
            datosDocentes.Remove(aux);
            return mensaje;
        }
    }


}

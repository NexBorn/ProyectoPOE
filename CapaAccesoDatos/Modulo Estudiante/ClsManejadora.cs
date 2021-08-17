
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ClsManejadora
    {
        List<ClsDatosEstudiantes> datosEstudiantes = null;

        private static ClsManejadora clsmanejadora = null;
        private ClsManejadora()
        {
            datosEstudiantes = new List<ClsDatosEstudiantes>();

        }
        public static ClsManejadora getClsManejadora()
        {
            if (clsmanejadora == null)
            {
                clsmanejadora = new ClsManejadora();
            }
            return clsmanejadora;
        }

        public List<ClsDatosEstudiantes> getListaEstudiantes()
        {
            return datosEstudiantes;
        }

        //Método para insertar información
        public String insertar_estudiante(ClsDatosEstudiantes clsDatosEstudiantes)
        {
            String mensaje = "";
            try
            {
                foreach (ClsDatosEstudiantes tmp in datosEstudiantes)
                {
                    if (tmp.Cedula == clsDatosEstudiantes.Cedula)
                    {
                        mensaje = "Ya existe este usuario";
                        break;
                    }
                }
                if (mensaje == "")
                {
                    datosEstudiantes.Add(clsDatosEstudiantes);
                    mensaje = "Estudiante insertado ";
                }

            }
            catch (Exception ex)
            {
                throw ex;

            }
            return mensaje;
        }

        public List<Object> listar_estudiante()
        {
            List<Object> lstEstudiantes = new List<Object>();

            //Se crea un tipo de datos Anonymus para obtener los datos del estudiantes y
            //pasarlo como objetos a la Capa Lógica del negocio
            foreach (var estudiante in datosEstudiantes)
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

                lstEstudiantes.Add(tmp);
            }
            return lstEstudiantes;
        }


  

    }
}

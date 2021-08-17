using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class ClsEstudiante: ClsPersona
    {
        private String representante;
        protected ClsManejadora listEstudiantes = ClsManejadora.getClsManejadora();


        public ClsEstudiante() { }

        public ClsEstudiante(string cedula, string nombres, string apellidos, Int16 edad, string direccion, string sexo, string nacionalidad, string representante) :
            base(cedula, nombres, apellidos, edad, direccion, sexo, nacionalidad)
        {
            this.representante = representante;
        }

        public String Representante { get => representante; set => representante = value; }

        

        //Registrar alumnos        
        public override String registrar()
        {
            string msj = "";
            try
            {
                //Pasar los parámetros hacia la capa de acceso a datos
                listEstudiantes.insertar_estudiante(new ClsDatosEstudiantes(Cedula,Nombres,Apellidos,Edad,Direccion,Sexo,Nacionalidad,Representante));   
            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos";
                throw ex;
            }
            return msj;
        }

        public override List<Object> listar()
        {
            return listEstudiantes.listar_estudiante();
        }

        public String eliminarEstudiante(String cedula)
        {
            foreach (ClsDatosEstudiantes estudiantes in listEstudiantes.getListaEstudiantes())
            {
                if (cedula.Equals(estudiantes.Cedula))
                {
                    listar().Remove(estudiantes);
                   
                    return "Se ha eliminado estudiante";
                }
            }
            return "No se encuentra estudiante";
        }

    }
}

using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
  public class ClsDocente: ClsPersona
    {
        private String titulo;

        public ClsDocente()
        {
        }

        public ClsDocente( string cedula, string nombres, string apellidos, string estado_civil, string sexo, Int16 edad, string nacionalidad, string provincia,String canton, string titulo)
            :base(cedula,nombres,apellidos,estado_civil,sexo,edad,nacionalidad,provincia,canton)
        {
        
            this.titulo = titulo;
        }
        public string Titulo { get => titulo; set => titulo = value; }

        //Referencia al Maenejador de la capa de acceso de datos
        ClsManejadorDoc M =ClsManejadorDoc.getClsManejadora();

        //Registrar Docente
        public override String registrar() {
            String msj = " ";
            try
            {  
                if (ValidarCedula(Cedula) != true) 
                    msj = M.insertar_docente(new ClsParametros(Cedula, Nombres, Apellidos, Estado_civil, Sexo, Edad, Nacionalidad, Provincia, Canton, Titulo));
                else
                    msj = "Cedula repetida";
            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        
        public override  List<Object> listar()
        {
            return M.listar_docente();
        }
        public Boolean ValidarCedula(String cedu)
        {
            Boolean x = false;
            foreach (var alumnos in listar())
            {
                System.Type type = alumnos.GetType();
                String id_cedula = (String)type.GetProperty("cedula").GetValue(alumnos);
                if (cedu.Equals(id_cedula))
                    x = true;
                else
                    x = false;
            }
            return x;
        }
        public String Eliminar(String cedu) {
            string msj;
              msj = M.eliminar_docente(cedu);
            return msj;
        }

    }
}

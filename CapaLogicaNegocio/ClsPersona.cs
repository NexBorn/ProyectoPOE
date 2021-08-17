using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class ClsPersona
    {
        
        private String cedula;
        private String nombres;
        private String estado_civil;
        private String apellidos;
        private Int16 edad;
        private String direccion;
        private String sexo;
        private String nacionalidad;
        private String provincia;
        private String canton;

        private List<Object> lst_obj;
        public ClsPersona(string cedula, string nombres, string apellidos, string estado_civil, string sexo, Int16 edad, string nacionalidad, string provincia, String canton)
        {
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.estado_civil = estado_civil;
            this.sexo = sexo;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
            this.provincia = provincia;
            this.canton = canton;
        }

        public ClsPersona() { }
        public ClsPersona(string cedula, string nombres, string apellidos, Int16 edad, string direccion, string sexo, string nacionalidad)
        {
            
            this.Cedula = cedula;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Direccion = direccion;
            this.Sexo = sexo;
            this.Nacionalidad = nacionalidad;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public Int16 Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Estado_civil { get => estado_civil; set => estado_civil = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Canton { get => canton; set => canton = value; }

        public virtual String registrar() { return ""; }
        public virtual List<Object> listar() { return lst_obj; }
    }
}

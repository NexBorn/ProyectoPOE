using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ClsDatosEstudiantes
    {
       
        private String cedula;
        private String nombres;
        private String apellidos;
        private Int16 edad;
        private String direccion;
        private String sexo;
        private String nacionalidad;
        private String representante;

        public ClsDatosEstudiantes(string cedula, string nombres, string apellidos, Int16 edad, string direccion, string sexo, string nacionalidad, string representante)
        {
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
            this.direccion = direccion;
            this.sexo = sexo;
            this.nacionalidad = nacionalidad;
            this.representante = representante;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public short Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Representante { get => representante; set => representante = value; }
    }
}

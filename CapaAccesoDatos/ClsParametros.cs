using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ClsParametros
    {
        private String cedula;
        private String nombres;
        private String apellidos;
        private String estado_civil;
        private Int16 edad;
        private String direccion;
        private String sexo;
        private String nacionalidad;
        private String provincia;
        private String canton;
        private String representante;
        private String titulo;

        public ClsParametros(string cedula, string nombres, string apellidos, string estado_civil, string sexo, Int16 edad, string nacionalidad, string provincia, String canton, String titulo)
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
            this.titulo = titulo;
        }

        public ClsParametros(string cedula, string nombres, string apellidos, Int16 edad, string direccion, string sexo, string nacionalidad, string representante)
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

        public String Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public short Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public String Representante { get => representante; set => representante = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Estado_civil { get => estado_civil; set => estado_civil = value; }
        public string Canton { get => canton; set => canton = value; }
        public string Provincia { get => provincia; set => provincia = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Modulo_Docente
{
    public class ClsDatosDocente
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
        private String titulo;

        public ClsDatosDocente()
        {
        }

        public ClsDatosDocente(string cedula, string nombres, string apellidos, string estado_civil, string sexo, Int16 edad, string nacionalidad, string provincia, String canton, String titulo)
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

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Estado_civil { get => estado_civil; set => estado_civil = value; }
        public short Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Canton { get => canton; set => canton = value; }
        public string Titulo { get => titulo; set => titulo = value; }
    }
}

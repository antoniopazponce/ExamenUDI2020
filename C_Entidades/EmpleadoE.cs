using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Entidades
{
    public class EmpleadoE
    {
        public int idEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string CI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public bool Sexo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Sueldo { get; set; }
        public int idProfesion { get; set; }
        public int idCargo { get; set; }
    }
}

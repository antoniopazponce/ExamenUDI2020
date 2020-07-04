using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Entidades
{
    public class CargoE
    {
        public int idCargo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal SueldoBase { get; set; }
        public int idDepartamento { get; set; }
        public int idCargoDependiente { get; set; }
    }
}

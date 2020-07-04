using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Entidades;
using DataAccess;

namespace Business
{
    public class EmpleadoB
    {
        EmpleadoDA empleadoDA = new EmpleadoDA();
        public void CreateEmpleado(EmpleadoE empleado)
        {
            empleadoDA.CreateEmpleado(empleado);
        }
        public List<EmpleadoE> MostrarEmpleado()
        {
            return empleadoDA.MostrarEmpleado();
        }
        public List<EmpleadoE> BuscarPorNombre(EmpleadoE empleado)
        {
            return empleadoDA.BuscarPorNombre(empleado);
        }
        public void EditarEmpledo(EmpleadoE empleadoE)
        {
            empleadoDA.EditarEmpledo(empleadoE);
        } 
        public void Eliminar(EmpleadoE empleado)
        {
            empleadoDA.Eliminar(empleado);
        }
    }
}

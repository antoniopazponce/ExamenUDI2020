using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Entidades;
using DataAccess;

namespace Business
{
    public class DepartamentoB
    {
        DepartamentoDA departamentoDA = new DepartamentoDA();
        public List<DepartamentoE> MostrarDepartamentos()
        {
            return departamentoDA.MostrarDepartamentos();
        }
        public void Create(DepartamentoE departamento)
        {
             departamentoDA.Create(departamento);
        }
        public void EditarDepartamento(DepartamentoE departamento)
        {
            departamentoDA.EditarDepartamento(departamento);
        }
        public void EliminarDepartamento(DepartamentoE departamento)
        {
            departamentoDA.EliminarDepartamento(departamento);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using C_Entidades;

namespace Business
{
    public class ProfesionB
    {
        ProfesioDA profesioDA = new ProfesioDA();
        public void Create(ProfesionE profesion)
        {
            profesioDA.Create(profesion);
        }
        public List<ProfesionE> ObtenerTodoProfesion()
        {
            return profesioDA.ObtenerTodoProfesion();
        }
        public void Editar(ProfesionE profesion)
        {
            profesioDA.Editar(profesion);
        }
        public void Eliminar(ProfesionE profesion)
        {
            profesioDA.Eliminar(profesion);
        }
    }
}

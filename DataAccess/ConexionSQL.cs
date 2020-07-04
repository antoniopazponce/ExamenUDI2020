using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccess
{
    public class ConexionSQL
    {
        public static string ObtenerCadenaSQL()
        {
            return ConfigurationManager.ConnectionStrings["ExamenDB"].ToString();
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Entidades;

namespace DataAccess
{
    public class DepartamentoDA
    {
        /// <summary>
        /// METODO QUE INSERTA NUEVOS DEPARTAMENTOS
        /// </summary>
        /// <param name="departamento"></param>
        /// <returns></returns>
        public void  Create(DepartamentoE departamento)
        {
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry = @"INSERT INTO Departamento (Nombre,Descripcion) VALUES (@nombre,@descripcion) SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(querry,conn);
                cmd.Parameters.AddWithValue("@nombre", departamento.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", departamento.Descripcion);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            
        }
        /// <summary>
        /// METODO QUE DEVUELVE TODOS LOS DEPARTAMENTOS
        /// </summary>
        /// <returns></returns>
        public List<DepartamentoE> MostrarDepartamentos()
        {
            List<DepartamentoE> lista = new List<DepartamentoE>();
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry = @"SELECT * FROM Departamento";
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataReader lector = cmd.ExecuteReader();
                while(lector.Read())
                {
                    lista.Add(CargarDepartamento(lector));
                }
            }
            return lista;
        }
        /// <summary>
        /// METODO QUE ACTUALIZA LOS DEPARTAMENTOS
        /// </summary>
        /// <param name="departamento"></param>
        public void EditarDepartamento(DepartamentoE departamento)
        {
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry = @"UPDATE Departamento SET Nombre=@nombre,Descripcion=@descripcion 
                                    WHERE idDepartamento=@departamentoid";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@departamentoid", departamento.idDepartamento);
                cmd.Parameters.AddWithValue("@nombre", departamento.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", departamento.Descripcion);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        /// <summary>
        /// mETODO QUE ELIMINA LOS DEPARTAMENTOS
        /// </summary>
        /// <param name="departamento"></param>
        public void EliminarDepartamento(DepartamentoE departamento)
        {
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry = @"DELETE Departamento WHERE idDepartamento=@departamentoid";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@departamentoid", departamento.idDepartamento);
                cmd.ExecuteNonQuery();
                conn.Close() ;
            }
        }
        /// <summary>
        /// METODO AUXILIAR QUE CARGA TODOS LOS DEPARTAMENTOS
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private DepartamentoE CargarDepartamento(IDataReader reader)
        {
            DepartamentoE departamento = new DepartamentoE();
            departamento.idDepartamento = Convert.ToInt32(reader["idDepartamento"]);
            departamento.Nombre = Convert.ToString(reader["Nombre"]);
            departamento.Descripcion = Convert.ToString(reader["Descripcion"]);

            return departamento;
        }
    }//endclass
}//end namespace

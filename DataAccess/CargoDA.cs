using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using C_Entidades;

namespace DataAccess
{
    public class CargoDA
    {
        /// <summary>
        /// METODO QUE AGREGAR UN CARGO
        /// </summary>
        /// <param name="cargo"></param>
        public void AgregarCargoPrueba(CargoE cargo)
        {
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL())) 
            {
                conn.Open();
                string querry = @"INSERT INTO Cargo VALUES (@nombre,@descripcion,@sueldo,@iddepartamento, @idcargodependiente)";
                SqlCommand cmd = new SqlCommand(querry,conn);
                cmd.Parameters.AddWithValue("@nombre", cargo.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", cargo.Descripcion);
                cmd.Parameters.AddWithValue("@sueldo", cargo.SueldoBase);
                cmd.Parameters.AddWithValue("@iddepartamento", cargo.idDepartamento);
                cmd.Parameters.AddWithValue("@idcargodependiente", cargo.idCargoDependiente);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            
        }
        public List<CargoE>ObtenerCargo()
        {
            List<CargoE> lista = new List<CargoE>();
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry = @"SELECT * FROM Cargo";
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataReader lector = cmd.ExecuteReader();
                while(lector.Read())
                {
                    lista.Add(CargarCargo(lector));
                }
            }
            return lista;
        }
        public void Upadate(CargoE cargo)
        {
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry = @"UPDATE Cargo SET Nombre = @nombre, Descripcion =@descripcion,
                                SueldoBase = @sueldo, idDepartamento = @idDep, idCargoDependiente=@cargodependienteid 
                                    WHERE idCargo = @cargoid";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@cargoid", cargo.idCargo);
                cmd.Parameters.AddWithValue("@nombre", cargo.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", cargo.Descripcion);
                cmd.Parameters.AddWithValue("@sueldo", cargo.SueldoBase);
                cmd.Parameters.AddWithValue("@idDep", cargo.idDepartamento);
                cmd.Parameters.AddWithValue("@cargodependienteid", cargo.idCargoDependiente);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void Delete(CargoE cargo)
        {
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry = @"DELETE Cargo WHERE idCargo = @cargoid";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@cargoid", cargo.idCargo);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }
        private CargoE CargarCargo(IDataReader reader)
        {
            CargoE cargo = new CargoE();
            cargo.idCargo = Convert.ToInt32(reader["idCargo"]);
            cargo.Nombre = Convert.ToString(reader["Nombre"]);
            cargo.Descripcion = Convert.ToString(reader["Descripcion"]);
            cargo.SueldoBase = Convert.ToDecimal(reader["SueldoBase"]);
            cargo.idDepartamento = Convert.ToInt32(reader["idDepartamento"]);
            cargo.idCargoDependiente = Convert.ToInt32(reader["idCargoDependiente"]);
            return cargo;
        }

    }
}

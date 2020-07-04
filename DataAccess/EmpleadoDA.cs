using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Entidades;

namespace DataAccess
{
    public class EmpleadoDA
    {
        public void CreateEmpleado(EmpleadoE empleado)
        {
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry = @"INSERT INTO Empleado (NombreCompleto,CI,FechaNacimiento,LugarNacimiento,Sexo,Direccion ,Telefono,Celular,FechaIngreso,Sueldo,idProfesion,idCargo)
                                        VALUES (@nombre,@ci,@fechaN,@lugarN,@sexo,@direccion,@telefono,@celular,@fechaI,@sueldo,@profesionid,@cargoid) ";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@nombre", empleado.NombreCompleto);
                cmd.Parameters.AddWithValue("@ci", empleado.CI);
                cmd.Parameters.AddWithValue("@fechaN", empleado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@lugarN", empleado.LugarNacimiento);
                cmd.Parameters.AddWithValue("@sexo", empleado.Sexo);
                cmd.Parameters.AddWithValue("@direccion", empleado.Direccion);
                cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
                cmd.Parameters.AddWithValue("@celular", empleado.Celular);
                cmd.Parameters.AddWithValue("@fechaI", empleado.FechaIngreso);
                cmd.Parameters.AddWithValue("@sueldo", empleado.Sueldo);
                cmd.Parameters.AddWithValue("@profesionid", empleado.idProfesion);
                cmd.Parameters.AddWithValue("@cargoid", empleado.idCargo);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public List<EmpleadoE>MostrarEmpleado()
        {
            List<EmpleadoE> lista = new List<EmpleadoE>();
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry = @"SELECT * FROM Empleado";
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataReader lector = cmd.ExecuteReader();
                while(lector.Read())
                {
                    lista.Add(CargarEmpleado(lector));
                }
            }
            return lista;
        }
        public List<EmpleadoE>BuscarPorNombre(EmpleadoE empleado)
        {
            List<EmpleadoE> lista = new List<EmpleadoE>();

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry= @"SELECT * FROM Empleado WHERE NombreCompleto= @nombre";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@nombre", empleado.NombreCompleto);
                SqlDataReader leer = cmd.ExecuteReader();
                while(leer.Read())
                {
                    lista.Add(CargarEmpleado(leer));
                }

            }
            return lista;
        }
        public void EditarEmpledo(EmpleadoE empleadoE)
        {
            using(SqlConnection cnn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                cnn.Open();
                string querry = @"UPDATE Empleado SET NombreCompleto=@nombre,CI=@ci,FechaNacimiento=@fechaN,
                                    LugarNacimiento=@lugarN,Sexo=@sexo,Direccion=@direccion ,Telefono=@telefono,
                                    Celular=@celular,FechaIngreso=@fechaI,Sueldo=@sueldo,idProfesion=@profesionid,idCargo=@cargoid
                                    WHERE idEmpleado=@empleadoid";
                SqlCommand cmd = new SqlCommand(querry, cnn);
                cmd.Parameters.AddWithValue("@empleadoid", empleadoE.idEmpleado);
                cmd.Parameters.AddWithValue("@nombre", empleadoE.NombreCompleto);
                cmd.Parameters.AddWithValue("@ci", empleadoE.CI);
                cmd.Parameters.AddWithValue("@fechaN", empleadoE.FechaNacimiento);
                cmd.Parameters.AddWithValue("@lugarN", empleadoE.LugarNacimiento);
                cmd.Parameters.AddWithValue("@sexo", empleadoE.Sexo);
                cmd.Parameters.AddWithValue("@direccion", empleadoE.Direccion);
                cmd.Parameters.AddWithValue("@telefono", empleadoE.Telefono);
                cmd.Parameters.AddWithValue("@celular", empleadoE.Celular);
                cmd.Parameters.AddWithValue("@fechaI", empleadoE.FechaIngreso);
                cmd.Parameters.AddWithValue("@sueldo", empleadoE.Sueldo);
                cmd.Parameters.AddWithValue("@profesionid", empleadoE.idProfesion);
                cmd.Parameters.AddWithValue("@cargoid", empleadoE.idCargo);
                cmd.ExecuteNonQuery();
                cnn.Close();

            }
        }
        public void Eliminar(EmpleadoE empleado)
        {
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry = @"DELETE Empleado Where idEmpleado = @empleadoid";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("empleadoid", empleado.idEmpleado);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        private EmpleadoE CargarEmpleado(IDataReader reader)
        {
            EmpleadoE empleado = new EmpleadoE();
            empleado.idEmpleado = Convert.ToInt32(reader["idEmpleado"]);
            empleado.NombreCompleto = Convert.ToString(reader["NombreCompleto"]);
            empleado.CI = Convert.ToString(reader["CI"]);
            empleado.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
            empleado.LugarNacimiento = Convert.ToString(reader["LugarNacimiento"]);
            empleado.Sexo = Convert.ToBoolean(reader["Sexo"]);
            empleado.Direccion = Convert.ToString(reader["Direccion"]);
            empleado.Telefono = Convert.ToString(reader["Telefono"]);
            empleado.Celular = Convert.ToString(reader["Celular"]);
            empleado.FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]);
            empleado.Sueldo = Convert.ToDecimal(reader["Sueldo"]);
            empleado.idProfesion = Convert.ToInt32(reader["idProfesion"]);
            empleado.idCargo = Convert.ToInt32(reader["idCargo"]);
            return empleado;
        }
    }
}

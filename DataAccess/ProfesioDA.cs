using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using C_Entidades;


namespace DataAccess
{
    public class ProfesioDA
    {
        /// <summary>
        /// METODO QUE CREA UNA NUEVA PROFESION
        /// </summary>
        /// <param name="profesion"></param>
        public void  Create(ProfesionE profesion)
        {
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))

            {
                conn.Open();
                string querry = @"INSERT INTO Profesion (Nombre,Descripcion,NIVEL) VALUES (@nombre,@descripcion,@nivel)
                                    SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@nombre", profesion.Nombre);
                cmd.Parameters.AddWithValue(@"descripcion", profesion.Descripcion);
                cmd.Parameters.AddWithValue("@nivel", profesion.NIVEL);
                cmd.ExecuteNonQuery();
                conn.Close();
            }           
         }
        /// <summary>
        /// METODO QUE DEVUELVE UNA LISTA DE LA PROFESION
        /// </summary>
        /// <returns></returns>
        public List<ProfesionE>ObtenerTodoProfesion()
        {
            List<ProfesionE> lista = new List<ProfesionE>();
             using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))

            {
                conn.Open();
                string querry = @"SELECT * FROM Profesion";
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataReader lecto = cmd.ExecuteReader();
                while(lecto.Read())
                {
                    lista.Add(CargarProfesion(lecto));
                }
            }
            return lista;
         }
        /// <summary>
        /// METODO QUE ACTUALIZA UNA PROFESION
        /// </summary>
        /// <param name="profesion"></param>
        public void Editar(ProfesionE profesion)
        {
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry = @"UPDATE Profesion SET Nombre = @nombre, Descripcion =@descripcion , NIVEL = @nivel
                                    WHERE idProfesion = @profesionid";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@profesionid", profesion.idProfesion);
                cmd.Parameters.AddWithValue("@nombre", profesion.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", profesion.Descripcion);
                cmd.Parameters.AddWithValue("@nivel", profesion.NIVEL);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        /// <summary>
        /// METODO QUE ELIMINA UNA PROFESION
        /// </summary>
        /// <param name="profesion"></param>
        public void Eliminar(ProfesionE profesion)
        {
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaSQL()))
            {
                conn.Open();
                string querry = @"DELETE Profesion WHERE idProfesion = @profesionid";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.Parameters.AddWithValue("@profesionid", profesion.idProfesion);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }
        /// <summary>
        /// METODO QUE DEVUELVE LA TABLA PROFESION EN UN DATA  READER
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private ProfesionE CargarProfesion(IDataReader reader)
        {
            ProfesionE profesion = new ProfesionE();
            profesion.idProfesion = Convert.ToInt32(reader["idProfesion"]);
            profesion.Nombre = Convert.ToString(reader["Nombre"]);
            profesion.Descripcion = Convert.ToString(reader["Descripcion"]);
            profesion.NIVEL = Convert.ToInt16(reader["NIVEL"]);
            return profesion;
        }

    }
}

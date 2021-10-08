using Microsoft.Extensions.Configuration;
using Servicio.AccesoDatos.InterfacesDatos;
using Servicio.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Servicio.AccesoDatos.AdminDatos
{
    public class DatosUsuario : IDatosUsuario
    {
        private readonly string conexion;
        public DatosUsuario(IConfiguration config)
        {
            conexion = config.GetConnectionString("BdUsuario");
        }

        public long CrearUsuario(Usuario usuario) 
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand();
                command = new SqlCommand("pa_InsertarUsuario", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UsuarioPersona", usuario.UsuarioPersona);
                command.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                command.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                command.Parameters.AddWithValue("@IdentificadorPerosna", usuario.IdentificadorPerosna);

                conn.Open();
                var idUsuario = command.ExecuteScalar();
                conn.Close();
                return Convert.ToInt32(idUsuario);
            }
        }

        public Usuario ValidarUsuario(Usuario usuario) 
        {
            Usuario _usuario = null;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand();
                command = new SqlCommand("pa_ValidarUsuario", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UsuarioPersona", usuario.UsuarioPersona);
                command.Parameters.AddWithValue("@Contrasena", usuario.Contraseña);

                conn.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _usuario = new Usuario
                    {
                        UsuarioPersona = reader["Usuario_USR"].ToString(),
                        IdentificadorPerosna = Convert.ToInt32(reader["IdentificadorPersona_USR"]),
                        Identificador = Convert.ToInt32(reader["Identificador_USR"]),
                        FechaCreacion = Convert.ToDateTime(reader["FechaCreacion_USR"]),
                    };
                    
                }
                conn.Close();
                //return Convert.ToInt32(idUsuario);
            }


            return _usuario;


        }
    }
}

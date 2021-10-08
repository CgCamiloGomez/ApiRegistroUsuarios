using Microsoft.Extensions.Configuration;
using Servicio.AccesoDatos.InterfacesDatos;
using Servicio.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Servicio.AccesoDatos.AdminDatos
{
    public class DatosPersona : IDatosPersona
    {
        private readonly string conexion;
        public DatosPersona(IConfiguration config)
        {
            conexion = config.GetConnectionString("BdUsuario");
        }

        public long CrearPersona(Persona persona) 
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand();
                command = new SqlCommand("pa_InsertarPersona", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombres", persona.Nombres);
                command.Parameters.AddWithValue("@Apellidos", persona.Apellidos);
                command.Parameters.AddWithValue("@Identificacion", persona.Identificacion);
                command.Parameters.AddWithValue("@Email", persona.Email);
                command.Parameters.AddWithValue("@TipoIdentificacion", persona.TipoIdentificacion);
                command.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                conn.Open();
                var idIPersona = command.ExecuteScalar();
                conn.Close();
                return Convert.ToInt32(idIPersona);
            }
        }
        public List<Persona> ObtenerPerosnas() 
        {
            List<Persona> Ltspersonas = new List<Persona>();

            Persona persona;
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand();
                command = new SqlCommand("pa_ObtenerPersonasCreadas", conn);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                conn.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    persona = new Persona
                    {
                        NombreCompleto = reader["NombreCompleto_PER"].ToString(),
                        Identificacion = reader["NumeroIdentificacion_PER"].ToString(),
                        TipoIdentificacion = reader["TipoIdentificacion_PER"].ToString(),
                        FechaCreacion = Convert.ToDateTime(reader["FechaCreacion_PER"]),
                        Identificador = Convert.ToInt32(reader["Identificador_PER"]),
                        Email = reader["Email_PER"].ToString()
                        
                    };

                    Ltspersonas.Add(persona);
                }
                conn.Close();

            }

            return Ltspersonas;

        }
    }
}

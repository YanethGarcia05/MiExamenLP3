using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class SoporteDatos
    {
        public async Task<DataTable> DevolverListaAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM soporte";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        dt.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return dt;
        }

        public async Task<bool> InsertarAsync(Soporte soporte)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO producto VALUES (@Id, @TipoSoporte)";
                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Id", MySqlDbType.Int32).Value = soporte.Id;
                        comando.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 100).Value = soporte.TipoSoporte;
                        await comando.ExecuteNonQueryAsync();
                        inserto = true;
                    }
                }
            }
            catch (Exception)
            {
            }
            return inserto;
        }

        public async Task<bool> ActualizarAsync(Soporte soporte)
        {
            bool actualizo = false;
            try
            {
                string sql = "UPDATE soporte SET TipoSoporte=@TipoSoporte WHERE Id=@Id; ";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = soporte.Id;
                        comando.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 45).Value = soporte.TipoSoporte;

                        await comando.ExecuteNonQueryAsync();
                        actualizo = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return actualizo;
        }

        public async Task<bool> EliminarAsync(string id)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM soporte WHERE Id = @Id;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Id", MySqlDbType.VarChar, 45).Value = id;

                        await comando.ExecuteNonQueryAsync();
                        elimino = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return elimino;
        }

        public async Task<Soporte> GetPorCodigoAsync(int id)
        {
            Soporte soporte = new Soporte();
            try
            {
                string sql = "SELECT * FROM soporte WHERE Id=@Id;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = id;

                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        if (dr.Read())
                        {
                            soporte.Id = Convert.ToInt32(dr["Codigo"]);
                            soporte.TipoSoporte = dr["TipoSoporte"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return soporte;
        }
    }
}

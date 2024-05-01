using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace OS_03.DAL
{
    internal class ConexaoBD
    {
        private string string_conexao = "";
        private MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarTabelas(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comandos = new MySqlCommand(sql, conexao);
                comandos.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable ConsultarTabelas(string sql)
        {
            try
            {
                Conectar();
                MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
                DataTable dados = new DataTable();
                consulta.Fill(dados);
                return dados;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

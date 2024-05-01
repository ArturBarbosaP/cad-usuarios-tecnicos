using System;
using System.Data;
using OS_03.DAL;

namespace OS_03.BLL
{
    internal class BLL_Login
    {
        private static string tipo_usuario, nome;
        private static int id;

        public string Logar(string usuario, string senha)
        {
            ConexaoBD bd = new ConexaoBD();
            string sql;
            DataTable dt;

            sql = string.Format("select * from usuario where email = '{0}' and senha = '{1}'", usuario, senha);
            dt = bd.ConsultarTabelas(sql);

            if (dt.Rows.Count > 0)
            {
                tipo_usuario = "Usuario";
                nome = dt.Rows[0]["nome"].ToString();
                id = int.Parse(dt.Rows[0]["id"].ToString());
                return "Usuario";
            }

            sql = string.Format("select * from tecnico where email = '{0}' and senha = '{1}'", usuario, senha);
            dt = bd.ConsultarTabelas(sql);

            if (dt.Rows.Count > 0)
            {
                tipo_usuario = "Tecnico";
                nome = dt.Rows[0]["nome"].ToString();
                id = int.Parse(dt.Rows[0]["id"].ToString());
                return "Tecnico";
            }

            return "";
        }

        public string Tipo_Usuario()
        {
            return tipo_usuario;
        }

        public string Nome_Usuario()
        {
            return nome;
        }

        public int ID_Usuario()
        {
            return id;
        }
    }
}
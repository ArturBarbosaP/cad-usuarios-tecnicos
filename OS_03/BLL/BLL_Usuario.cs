using System;
using System.Data;
using OS_03.DTO;
using OS_03.DAL;

namespace OS_03.BLL
{
    internal class BLL_Usuario
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;


        public void CadUsuario(DTO_Usuario usuario)
        {
            try
            {
                sql = string.Format("insert into usuario values(null, '{0}', '{1}', '{2}', '{3}', '{4}')", 
                      usuario.Nome, usuario.Email, usuario.Telefone, usuario.Id_Setor, usuario.Senha);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarUsuario(DTO_Usuario usuario)
        {
            try
            {
                sql = string.Format("update usuario set nome = '{0}', email = '{1}', telefone = '{2}', setor = '{3}', senha = '{4}' where id = '{5}'",
                      usuario.Nome, usuario.Email, usuario.Telefone, usuario.Id_Setor, usuario.Senha, usuario.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExcluirUsuario(DTO_Usuario usuario)
        {
            try
            {
                sql = string.Format("delete from usuario where id = '{0}'", usuario.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ListarUsuario()
        {
            try
            {
                return bd.ConsultarTabelas("select * from usuario");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
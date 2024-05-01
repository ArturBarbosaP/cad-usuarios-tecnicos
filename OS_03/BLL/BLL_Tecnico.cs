using System;
using System.Data;
using OS_03.DTO;
using OS_03.DAL;

namespace OS_03.BLL
{
    internal class BLL_Tecnico
    {
        ConexaoBD bd = new ConexaoBD();
        private string sql;


        public void CadTecnico(DTO_Tecnico tecnico)
        {
            try
            {
                sql = string.Format("insert into tecnico values(null, '{0}', '{1}', '{2}', '{3}')", tecnico.Nome, tecnico.Id_espec, tecnico.Email, tecnico.Senha);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarTecnico(DTO_Tecnico tecnico)
        {
            try
            {
                sql = string.Format("update tecnico set nome = '{0}', especialidade = '{1}', email = '{2}', senha = '{3}' where id = '{4}'", tecnico.Nome, tecnico.Id_espec, tecnico.Email, tecnico.Senha, tecnico.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExcluirTecnico(DTO_Tecnico tecnico)
        {
            try
            {
                sql = string.Format("delete from tecnico where id = '{0}'", tecnico.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ListarTecnico()
        {
            try
            {
                return bd.ConsultarTabelas("select * from tecnico");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
using System;
using OS_03.DTO;
using OS_03.DAL;
using System.Data;

namespace OS_03.BLL
{
    class BLL_OS
    {
        private ConexaoBD bd = new ConexaoBD();
        private string sql;

        public void Criar_OS(DTO_OS os)
        {
            try
            {
                sql = string.Format("insert into os values (null, '{0}', '{1}', '{2}', '{3}')", os.Descricao, os.Status_os, os.Tecnico, os.Usuario);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Alterar_OS(DTO_OS os)
        {
            try
            {
                sql = string.Format("update os set status_os = '{0}' where id = '{1}'", os.Status_os, os.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir_OS(DTO_OS os)
        {
            try
            {
                sql = string.Format("delete from os where id = '{0}'", os.Id);
                bd.AlterarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar_OS()
        {
            try
            {
                return bd.ConsultarTabelas("select * from os");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public DataTable Listar_OS_Usuario(DTO_OS os)
        {
            try
            {
                sql = string.Format("select * from os where usuario_id = '{0}'", os.Usuario);
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Listar_OS_Tecnico(DTO_OS os)
        {
            try
            {
                sql = string.Format("select * from os where tecnico_id = '{0}'", os.Tecnico);
                return bd.ConsultarTabelas(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
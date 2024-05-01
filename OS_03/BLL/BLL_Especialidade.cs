using System;
using OS_03.DAL;
using System.Data;

namespace OS_03.BLL
{
    internal class BLL_Especialidade
    {
        ConexaoBD bd = new ConexaoBD();

        public DataTable ConsultarEspecialidade()
        {
            try
            {
                return bd.ConsultarTabelas("select * from especialidade");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

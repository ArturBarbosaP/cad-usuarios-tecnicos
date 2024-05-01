using System;
using OS_03.DAL;
using System.Data;

namespace OS_03.BLL
{
    internal class BLL_Setor
    {
        ConexaoBD bd = new ConexaoBD();

        public DataTable ConsultarSetor()
        {
            try
            {
                return bd.ConsultarTabelas("select * from setor");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
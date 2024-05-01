using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_03.DTO
{
    class DTO_OS
    {
        private int id, tecnico, usuario;
        private string descricao, status_os;

        public int Id { get => id; set => id = value; }
        public int Tecnico { get => tecnico; set => tecnico = value; }
        public int Usuario { get => usuario; set => usuario = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Status_os { get => status_os; set => status_os = value; }
    }
}
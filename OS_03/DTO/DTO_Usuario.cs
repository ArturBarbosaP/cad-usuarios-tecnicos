using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_03.DTO
{
    internal class DTO_Usuario
    {

        private int id, id_setor;
        private string nome, email, telefone, senha;

        public int Id { get => id; set => id = value; }
        public int Id_Setor { get => id_setor; set => id_setor = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
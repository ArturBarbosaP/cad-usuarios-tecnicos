using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_03.DTO
{
    internal class DTO_Tecnico
    {
        private int id, id_espec;
        private string nome, email, senha;
        
        public int Id { get => id; set => id = value; }
        public int Id_espec { get => id_espec; set => id_espec = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}

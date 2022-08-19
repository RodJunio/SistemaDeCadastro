using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadastro
{

    public class Cliente
    {
        public Cliente() { }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string telefone, string email)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        } 
    }
}

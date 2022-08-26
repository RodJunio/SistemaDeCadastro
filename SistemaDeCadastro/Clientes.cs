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
        public void Salvar()
        {
            Cliente.SalvarClientes(this);
        }
        public static List<Cliente> BancoDeClienteCadastrados = new List<Cliente>();
        public static List<Cliente> Todas()
        {
            return Cliente.BancoDeClienteCadastrados;
        }

        public static void SalvarClientes(Cliente obj)
        {
            Cliente.BancoDeClienteCadastrados.Add(obj);
        }

        //public static List<Cliente> BuscaPorNome(string nome)
        //{
        //    var novaLista = new List<Cliente>();
        //    foreach(Cliente instancia in BancoDeClienteCadastrados)
        //    {
        //        if(instancia.Nome.Contains(nome))
        //        {
        //            novaLista.Add(instancia);
        //        }
        //        return novaLista;
        //    }
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1028_mutantes
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Idade = idade;
            ValidarNome();
        }

        private void ValidarNome()
        {
            if (string.IsNullOrEmpty(Nome) || Nome.Split(' ').Length < 2)
                throw new Exception("Nome precisa ser composto por nome e sobrenome");
        }

        public bool EhMaiorDeIdade() => Idade >= 18;
    }
}

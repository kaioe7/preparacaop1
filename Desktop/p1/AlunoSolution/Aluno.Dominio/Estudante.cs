using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Dominio
{
    public class Estudante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Nota { get; set; }

        public Estudante(string nome, decimal nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public bool EstaAprovado() => Nota >= 7;
    }
}

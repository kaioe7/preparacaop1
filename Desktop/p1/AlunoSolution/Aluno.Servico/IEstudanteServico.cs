using Aluno.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Servico
{
    public interface IEstudanteServico
    {
        void AdicionarEstudante(string nome, decimal nota);
        List<Estudante> ObterTodos();
        Estudante ObterPorId(int id);
        void AtualizarEstudante(Estudante estudante);
        void RemoverEstudante(int id);
    }
}

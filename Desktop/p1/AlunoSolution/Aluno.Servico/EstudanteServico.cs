using Aluno.Dominio;
using Aluno.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Servico
{
    public class EstudanteServico : IEstudanteServico
    {
        private readonly IEstudanteRepositorio _repositorio;

        // 💡 Injeção de dependência via construtor
        public EstudanteServico(IEstudanteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void AdicionarEstudante(string nome, decimal nota)
        {
            var estudante = new Estudante(nome, nota);
            _repositorio.Salvar(estudante);
        }

        public List<Estudante> ObterTodos() => _repositorio.ObterTodos();

        public Estudante ObterPorId(int id) => _repositorio.ObterPorId(id);

        public void AtualizarEstudante(Estudante estudante) => _repositorio.Atualizar(estudante);

        public void RemoverEstudante(int id) => _repositorio.Remover(id);
    }
}

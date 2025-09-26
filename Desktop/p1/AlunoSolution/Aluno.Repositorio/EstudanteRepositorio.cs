using Aluno.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno.Repositorio
{
    public class EstudanteRepositorio : IEstudanteRepositorio
    {
        private readonly List<Estudante> _estudantes = new();
        private int _proximoId = 1;

        public void Salvar(Estudante estudante)
        {
            estudante.Id = _proximoId++;
            _estudantes.Add(estudante);
        }

        public List<Estudante> ObterTodos() => _estudantes;

        public Estudante ObterPorId(int id) => _estudantes.FirstOrDefault(a => a.Id == id);

        public void Atualizar(Estudante estudante)
        {
            var existente = ObterPorId(estudante.Id);
            if (existente != null)
            {
                existente.Nome = estudante.Nome;
                existente.Nota = estudante.Nota;
            }
        }

        public void Remover(int id)
        {
            var estudante = ObterPorId(id);
            if (estudante != null) _estudantes.Remove(estudante);
        }
    }
}

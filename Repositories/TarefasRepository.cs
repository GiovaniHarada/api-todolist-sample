using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeapp2.Models;
using testeapp2.Repositories.Interfaces;

namespace testeapp2.Repositories
{
    public class TarefasRepository: ITarefasRepository
    {
        private readonly FakeDB dB;

        public TarefasRepository(FakeDB dB)
        {
            this.dB = dB;
        }

        public IEnumerable<Tarefa> ObterTarefas()
        {
            var tarefas = dB.Tarefas.ToList();

            return tarefas;
        }
    }
}

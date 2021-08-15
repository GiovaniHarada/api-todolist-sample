using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeapp2.Business.Interfaces;
using testeapp2.Models;
using testeapp2.Repositories.Interfaces;

namespace testeapp2.Business
{
    public class TarefasBusiness: ITarefasBusiness
    {
        private readonly ITarefasRepository tarefasRepository;

        public TarefasBusiness(ITarefasRepository tarefasRepository)
        {
            this.tarefasRepository = tarefasRepository;
        }

        public IEnumerable<Tarefa> GetTarefas()
        {
            return tarefasRepository.ObterTarefas();


        }
    }
}

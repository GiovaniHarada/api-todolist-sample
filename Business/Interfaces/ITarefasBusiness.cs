using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeapp2.Models;

namespace testeapp2.Business.Interfaces
{
    public interface ITarefasBusiness
    {
        IEnumerable<Tarefa> GetTarefas();
    }
}

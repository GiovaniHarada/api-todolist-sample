using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testeapp2.Business.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace testeapp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefasBusiness tarefasBusiness;

        public TarefaController(ITarefasBusiness tarefasBusiness)
        {
            this.tarefasBusiness = tarefasBusiness;
        }

        // GET: api/<TarefaController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(tarefasBusiness.GetTarefas());
        }

        // GET api/<TarefaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TarefaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TarefaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TarefaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

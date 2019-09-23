using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860



using AspnetCore_WebApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace AspnetCore_WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TarefaController : Controller
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;
        public TarefaController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }
        [HttpGet]
        public IEnumerable<TarefaItem> GetAll()
        {
            return _tarefaRepositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetTarefa")]
        public IActionResult GetById(long id)
        {
            var item = _tarefaRepositorio.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
//Metodo Create
[HttpPost]
public IActionResult Create([FromBody] TarefaItem item)
{
    if (item == null)
    {
        return BadRequest();
    }
    _tarefaRepositorio.Add(item);
    return CreatedAtRoute("GetTarefa", new { id = item.Chave }, item);
}
//Metodo Update

[HttpPut("{id}")]
public IActionResult Update(long id, [FromBody] TarefaItem item)
{
    if (item == null || item.Chave != id)
    {
        return BadRequest();
    }
    var tarefa = _tarefaRepositorio.Find(id);
    if (tarefa == null)
    {
        return NotFound();
    }
    tarefa.EstaCompleta = item.EstaCompleta;
    tarefa.Nome = item.Nome;
    _tarefaRepositorio.Update(tarefa);
    return new NoContentResult();
}
//Metodo Delete

[HttpDelete("{id}")]
public IActionResult Delete(long id)
{
    var todo = _tarefaRepositorio.Find(id);
    if (todo == null)
    {
        return NotFound();
    }
    _tarefaRepositorio.Remove(id);
    return new NoContentResult();
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/v1/[controller]")]
[Produces("application/json")]
public class ProgramsController : Controller
{
    private readonly HdSqlContext _repository;

    public ProgramsController(HdSqlContext repository)
    {
        _repository = repository;
    }

    // GET: api/<controller>
    [HttpGet]
    public ActionResult GetAll(int take = 25, int skip = 0)
    {
        var query = _repository.Programs
            .Take(take)
            .Skip(skip);

        var results = query.ToList();

        return Ok(results);
    }

    // GET api/<controller>/5
    [HttpGet("{id}")]
    public ActionResult GetOne(Guid id)
    {
        var result = _repository.Programs
            .Find(id);

        if (result != null)
            return Ok(result);
        else
            return NotFound("Program does not exist!");
    }

    // POST api/<controller>
    [HttpPost]
    public ActionResult Post([FromBody]Program program)
    {
        var result = _repository.Programs
            .Find(program.Id);

        if (result == null)
        {
            program.Created = DateTime.Now;
            _repository.Add(program);
            _repository.SaveChanges();
            return Ok(program.Id);
        }
        else
        {
            return BadRequest("Program already exists");
        }
    }

    // PUT api/<controller>/5
    [HttpPut]
    public ActionResult Update([FromBody]Program program)
    {
        if (_repository.Programs.Contains(program))
        {
            program.Updated = DateTime.Now;
            _repository.Update(program);
            _repository.SaveChanges();
            return Ok(program.Id);
        }
        else
        {
            return BadRequest("Program does not exist");
        }
    }

    // DELETE api/<controller>/5
    [HttpDelete("{id}")]
    public ActionResult Delete(Guid id)
    {
        var result = _repository.Programs
            .Find(id);

        if (result != null)
        {
            _repository.Remove(result);
            _repository.SaveChanges();
            return Ok(result.Id);
        }
        else
        {
            return NotFound("Program does not exist!");
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;


namespace TodoApi.Controllers;

using System.Threading.Tasks;
using TodoLibrary.Models;

[Route("api/[controller]")]
[ApiController]
public class TodosController : ControllerBase
{
    // GET: api/Todos
    [HttpGet]
    public ActionResult<IEnumerable<TodoModel>> Get()
    {
        throw new NotImplementedException();
    }

    // GET api/Todos/5
    [HttpGet("{id}")]
    public ActionResult<TodoModel> Get(int id)
    {
        throw new NotImplementedException();
    }

    // POST api/Todos
    [HttpPost]
    public IActionResult Post([FromBody] string value)
    {
        throw new NotImplementedException();
    }

    // PUT api/Todos/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] string value)
    {
        throw new NotImplementedException();
    }

    // PUT api/Todos/5/Complete
    [HttpPut("{id}/Complete")]
    public IActionResult Complete(int id)
    {
        throw new NotImplementedException();
    }

    // DELETE api/Todos/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        throw new NotImplementedException();
    }
}

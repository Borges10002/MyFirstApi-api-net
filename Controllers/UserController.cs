using Microsoft.AspNetCore.Mvc;
using MyFirstApi3.Communication.Requests;
using MyFirstApi3.Communication.Responses;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new User
        {
            Id = 1,
            Age = 7,
            Name = "diego da silva borges"
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterUserJson user)
    {
        var response = new ResponseRegisterUserJson
        {

            Id = 1,
            Name = user.Name
        };

        return Created(string.Empty, response);
    }
}
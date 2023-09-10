using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("")]
public class HomeController
{
    [HttpGet]
    public List<Object> Get()
    {
        return new List<object>();
    }
}
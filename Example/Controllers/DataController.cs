namespace Example.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]/[action]")]
public class DataController : ControllerBase
{
    [HttpGet]
    public IActionResult List()
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult Create()
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult Update()
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult BulkUpdate()
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult Delete()
    {
        return Ok();
    }
}

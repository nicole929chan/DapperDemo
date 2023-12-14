using Application.Abstractions.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Web.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DemoController : ControllerBase
{
    private readonly IDbContext _dbContext;
    // 因為Extension Method已經把IDbContext註冊為SqlServerConnection實例
    public DemoController(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public IActionResult OnGet()
    {
        // 生成真正的連線物件
        using IDbConnection connection = _dbContext.Create();

        return Ok();
    }
}

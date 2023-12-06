using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EMController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        string demo = "Hello";

        // .CombineWords()不須帶任何參數
        // demo本身就會成為擴展方法的第一個參數(message)
        return Ok(demo.CombineWords());
    }
}

public static class Extensions
{
    // this - 表明CombineWords是一個擴展方法
    // string - CombineWords要擴展到string類別上
    // message - 實例
    public static string CombineWords(this string message)
    {
        return message + " World";
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EMController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        // string demo = "Hello";

        // .CombineWords()不須帶任何參數
        // demo本身就會成為擴展方法的第一個參數(message)
        // return Ok(demo.CombineWords());

        SimpleLogger logger = new();  // 因為下方的程式碼, .NET編譯時已經知道logger已經具備LogError()
        logger.LogError("This is an error");

        return Ok();
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

public static class ExtensionSimpleLogger
{
    // LogError是一個擴展方法
    // 它被掛到SimpleLogger實例上
    // 擴展方法被觸發時所帶進來的參數由message接收
    public static void LogError(this SimpleLogger logger, string message)
    {
        // 因為有logger, 所以可以觸發它真正的方法, 而非野橄欖的~
        // 這裡一律帶的type就是Error (由自己來標準化)
        logger.Log(message, "Error");
    }
}
// 第三方套件
public class SimpleLogger
{
    public void Log(string message)
    {
        // do something
    }

    public void Log(string message, string messageType)
    {
        // do something
    }
}

using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace yepl.Functions.Http;

public class HelloReact
{
    private readonly ILogger<HelloReact> _logger;

    public HelloReact(ILogger<HelloReact> logger)
    {
        _logger = logger;
    }

    [Function("HelloReact")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult($"And Anton Yesenin is here too, {DateTime.Now}");
    }
}
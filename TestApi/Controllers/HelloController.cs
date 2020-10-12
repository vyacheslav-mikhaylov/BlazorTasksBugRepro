using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    public class HelloResponse
    {
        public string Value { get; set; }
    }
    
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public async Task<HelloResponse> Get()
        {
            await Task.Delay(500);
            return new HelloResponse() { Value = $"Hello {DateTime.Now}" };
        }
    }
}
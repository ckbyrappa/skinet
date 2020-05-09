using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api2/[controller]")]
    public class CustomersController : ControllerBase
    { 

        [HttpGet]
        public string abcd()
        {
            return "this is the list of customers";
        }

    }
}
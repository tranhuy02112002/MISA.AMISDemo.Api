using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.AMISDemo.Infrastructure.Repository;

namespace MISA.AMISDemo.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCustomers()
        {
            CustomerRepository customerRepository = new CustomerRepository();
            var customers = customerRepository.GetAll();
            return StatusCode(200, customers);
        }
    }
}

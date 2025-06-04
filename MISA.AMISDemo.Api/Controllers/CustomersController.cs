using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.AMISDemo.Core.Entities;
using MISA.AMISDemo.Core.Interfaces;
using MISA.AMISDemo.Infrastructure.Repository;

namespace MISA.AMISDemo.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {   
        ICustomerRepository _customerRepository;
        private ICustomerService _customerservice;
        public CustomersController(ICustomerRepository customerRepository, ICustomerService customerservice)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customers =_customerRepository.GetAll();
            return StatusCode(200, customers);
        }
        [HttpPost]
        public IActionResult Insert(Customer customer)
        {
            try
            {
                var res = _customerservice.InsertService(customer);
                if (res.Success == true)
                {
                    return StatusCode(201, res);
                }
                else
                {
                    return StatusCode(400, res);
                }

            }
            catch (Exception ex)
            {
                var res = new
                {
                    userMsg = "Có lỗi xảy ra trong quá trình xử lý dữ liệu. Vui lòng thử lại sau nhé",
                    DevMsg = ex.Message,
                    Error = ""
                };
                return StatusCode(500, ex.Message);
            }
         
        }
    }
}

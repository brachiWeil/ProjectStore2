using Microsoft.AspNetCore.Mvc;
using Store.BL;
using Store.BL.Interface;
using Store.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store.server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        readonly ICustomersService _CustomersService;

        public CustomersController(ICustomersService CustomersService)
        {
            _CustomersService = CustomersService;
        }

        [HttpGet]
        public List<Customers> Get()
        {
            return _CustomersService.GetAll();
        }
        [HttpPost]
        public ActionResult Post(Customers customer)
        {
            bool? succsed = _CustomersService.AddCustomer(customer);
            if (succsed == null)
            {
                return NoContent();
            }
            else if (succsed.Value)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpGet("{tz}")]
        public Customers GetCustomerByCode(int tz)
        {
            return _CustomersService.GetCustomerByCode(tz);
        }
        [HttpDelete]
        public bool RemoveCustomer(int tz)
        {
            return _CustomersService.RemoveCustomer(tz);
        }
        [HttpPut]
        public ActionResult Put(Customers customer)
        {
            bool? succsed = _CustomersService.UpdateCustomer(customer);
            if (succsed == null)
            {
                return NoContent();
            }
            else if (succsed.Value)
            {
                return Ok();
            }
            return BadRequest();

        }


    }
}

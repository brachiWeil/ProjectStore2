using Microsoft.AspNetCore.Mvc;
using Store.BL;
using Store.BL.Interface;
using Store.Model;



// זה הממשק משתמש הוא מקבל נתונים משהמשתמש ושולח אותם לservice


namespace Store.server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

            readonly IProductsService _ProductsService;

            public ProductsController(IProductsService ProductsService)
            {
            _ProductsService = ProductsService;
            }
            [HttpGet]
            public List<Products> Get()
            {
                return _ProductsService.GetAll();
            }

        [HttpPost]
        public ActionResult Post(Products product)
        {
            bool? succsed = _ProductsService.AddProduct(product);
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

        [HttpGet("{barkode}")]
        public Products GetProductByCode(string barkode)
        {
            return _ProductsService.GetProductByCode(barkode);
        }
        [HttpDelete]
        public bool RemoveProduct(string barkode)
        {
            return _ProductsService.RemoveProduct(barkode);
        }
        [HttpPut]
        public ActionResult Put(Products product)
        {
            bool? succsed = _ProductsService.UpdateProduct(product);
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


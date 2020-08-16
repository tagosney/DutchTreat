using DutchTreat.Data;
using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly IDutchRepository _repository;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IDutchRepository repository, ILogger<ProductsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }


        //[ProducesResponseType(200)] - different ways to get api set up for public use
        //[ProducesResponseType(400)]
        //public ActionResult<IEnumerable<Product>> Get() //allows MVC 6 to select format-fluid and not rigid like Json
        //{
        //    try
        //    {
        //        return Ok(_repository.GetAllProducts());//return all products in entity framework - returns 200 ok
        //    }
        //    catch(Exception ex)
        //    {
        //        _logger.LogError($"Failed to get products: {ex}");
        //        return BadRequest("Failed to get products");
        //    }

        //}
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public IActionResult Get() //allows MVC 6 to select format-fluid and not rigid like Json
        {
            try
            {
                return Ok(_repository.GetAllProducts());//return all products in entity framework - returns 200 ok
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get products: {ex}");
                return BadRequest("Failed to get products");
            }

        }
    }
}

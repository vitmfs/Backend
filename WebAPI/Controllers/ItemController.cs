using DomainClasses.Base;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : BaseController<Item>
    {

        private readonly ILogger<ItemController> _logger;

        
        public ItemController(ILogger<ItemController> logger)
        {
            _logger = logger;
        }
        

        [HttpGet(Name = "GetItem")]
        public IEnumerable<Item> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Item
            {
                Name = "Something"
            })
            .ToArray();
        }
    }
}

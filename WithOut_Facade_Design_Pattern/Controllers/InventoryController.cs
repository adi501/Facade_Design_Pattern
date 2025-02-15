using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WithOut_Facade_Design_Pattern.Service;
using WithOut_Facade_Design_Pattern.Service.IService;

namespace WithOut_Facade_Design_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService iInventoryService;

        public InventoryController(IInventoryService iInventoryService)
        {
            this.iInventoryService = iInventoryService;
        }

        // GET: api/<InventoryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}

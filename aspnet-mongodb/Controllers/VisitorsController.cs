using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using aspnetmongodb.Models;
using System.Linq;
using System.Text.Encodings.Web;
using aspnetmongodb.Services;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace aspnetmongodb.Controllers
{
    [Route("api/[controller]")]
    public class VisitorsController : Controller
    {
        private readonly IVisitorService _visitorService;

        public VisitorsController(IVisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new ObjectResult(await _visitorService.GetAllAsync());
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Visitor visitor)
        {
            await _visitorService.CreateAsync(visitor);
            return new OkObjectResult(visitor);
        }

    }
}

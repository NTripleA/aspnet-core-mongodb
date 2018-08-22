using Microsoft.AspNetCore.Mvc;
using aspnetmongodb.Models;
using aspnetmongodb.Services;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace aspnetmongodb.Controllers
{
    [Route("api/[controller]")]
    public class VisitorsController : Controller
    {
        private readonly IVisitorService _visitorService;
        private readonly HtmlEncoder _htmlEncoder;

        public VisitorsController(HtmlEncoder htmlEncoder, IVisitorService visitorService)
        {
            _visitorService = visitorService;
            _htmlEncoder = htmlEncoder;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new ObjectResult(await _visitorService.GetAllAsync());
        }

        // POST api/values
        [HttpPost]
        public async IEnumerable<string> Post([FromBody]Visitor visitor)
        {
            await _visitorService.CreateAsync(visitor);
            return new string[] { _htmlEncoder.Encode("Hello " + visitor.Name) };
        }

    }
}

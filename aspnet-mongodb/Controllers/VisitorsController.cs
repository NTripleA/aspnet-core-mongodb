using Microsoft.AspNetCore.Mvc;
using aspnetmongodb.Models;
using aspnetmongodb.Services;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace aspnetmongodb.Controllers
{
    [Produces("application/json")]
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
        public IEnumerable<string> Get()
        {
          if (_visitorService == null)
          {
              return new string[] { "No database connection" };
          }
          else
          {
              return _visitorService.GetAll();

          }
        }

        // POST api/values
       [HttpPost]
       public string Post([FromBody]Visitor visitor)
       {
           _visitorService.Create(visitor);
           return "Hello, "+visitor.Name+"!";
       }

    }
}

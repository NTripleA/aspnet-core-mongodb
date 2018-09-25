using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetmongodb.Models;
using aspnetmongodb.Services;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace aspnetmongodb.Services
{
    public class VisitorService : IVisitorService
    {
        private readonly IMongoContext _context;
        public VisitorService(IMongoContext context)
        {
            _context = context;
        }

        public IEnumerable<string> GetAll()
        {
          List<Visitor> visitors = _context.Visitors.Find(_ => true).ToList();
          List<string> names = new List<string>();;
          foreach(Visitor v in visitors)
          {
            names.Add(v.Name);
          }
          return names;

        }

        public void Create(Visitor visitor)
        {
            _context.Visitors.InsertOne(visitor);
        }
    }
}

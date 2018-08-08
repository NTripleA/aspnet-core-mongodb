using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetmongodb.Models;
using aspnetmongodb.Services;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace aspnetmongodb
{
    public class VisitorService : IVisitorService
    {
        private readonly IMongoContext _context;
        public VisitorService(IMongoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Visitor>> GetAllAsync()
        {
            return await _context
            .Visitors
            .Find(_ => true)
            .ToListAsync();  
            
        }

        public async Task CreateAsync(Visitor visitor)
        {
            await _context.Visitors.InsertOneAsync(visitor);
        }
    }
}

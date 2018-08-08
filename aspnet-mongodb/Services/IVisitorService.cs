using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetmongodb.Models;

namespace aspnetmongodb.Services
{
    public interface IVisitorService
    {
        Task CreateAsync(Visitor visitor);
        Task<IEnumerable<Visitor>> GetAllAsync();
    }
}

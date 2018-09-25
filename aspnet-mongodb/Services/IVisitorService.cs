using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetmongodb.Models;

namespace aspnetmongodb.Services
{
    public interface IVisitorService
    {
        void Create(Visitor visitor);
        IEnumerable<string> GetAll();
    }
}

using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstraction.DataAccess
{
    public interface IDocumentRepository : IBaseRepository<Document>
    {

        List<Document> Get(int? Types, int? Numbers, string Name, int? ClientId, int skipCount = 0, int takeCount = 100);
        
    }
}

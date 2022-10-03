using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Document
{
    public class CreateDocumentModel
    {
        public int Types { get; set; }
        public int Numbers { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }

        internal Core.Models.Document MapToDocumentModel()
        {
            throw new NotImplementedException();
        }

        internal Core.Models.Document MapToDocumentTypeModel()
        {
            throw new NotImplementedException();
        }
    }
}

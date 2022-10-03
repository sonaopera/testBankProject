using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.Document
{
    public class UpdateDocumentModel
    {
        public int Id { get; set; }

        public int Types { get; set; }
        public int Numbers { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }


    }
}

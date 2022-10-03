using BLL.DTO.Document;
using BLL.Interfaces;
using BLL.Services;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        private Document model;

        public DocumentController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpGet]
        public List<GetDocumentModel> Get(int? Types, int? Numbers, string Name, int? ClientId, int skipCount, int takeCount)
        {
            return _documentService.Get(Types, Numbers, Name, ClientId, skipCount, takeCount);



        }


        [HttpPost]
        public void Add(CreateDocumentModel model)
        {
            _documentService.Add(model);
        }



        [HttpPut]
        public void Update(UpdateDocumentModel model)
        {
            _documentService.Update(model);
        }


        [HttpDelete]
        public void Delete(int id)
        {
            _documentService.Delete(id);
        }





    }
}

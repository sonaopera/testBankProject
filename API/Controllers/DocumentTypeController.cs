using BLL.DTO.DocumentType;
using BLL.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentTypeController : ControllerBase
    {

        private readonly IDocumentTypeService _documentTypeService;
        private DocumentType model;

        public DocumentTypeController(IDocumentTypeService documentTypeService)
        {
            _documentTypeService = documentTypeService;
        }

        


        [HttpPost]
        public void Add(CreateDocumentTypeModel model)
        {
            _documentTypeService.Add(model);
        }



        [HttpPut]
        public void Update(UpdateDocumentTypeModel model)
        {
            _documentTypeService.Update(model);
        }


        [HttpDelete]
        public void Delete(int id)
        {
            _documentTypeService.Delete(id);
        }

    }




}

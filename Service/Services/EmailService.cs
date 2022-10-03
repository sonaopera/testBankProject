using BLL.DTO.Email;
using BLL.Interfaces;
using BLL.Mappers;
using Core.Abstraction.DataAccess;





namespace BLL.Services
{
    public class EmailService : IEmailService
    {
        private readonly IEmailRepository _emailRepo;

        public EmailService(IEmailRepository emailRepo)
        {
            _emailRepo = emailRepo;
        }



        public void Add(CreateEmailModel model)
        {
            _emailRepo.Add(model.MapToEmail());
        }

        public void Delete(int id)
        {

            _emailRepo.Delete(id);
        }

       

        public void Update(UpdateEmailModel model)
        {
            _emailRepo.Update(model.MapToEmail());
        }

       

       
        
    }

   
}

using BLL.DTO.Email;


namespace BLL.Interfaces
{
    public interface IEmailService 
    {
        void Add(CreateEmailModel model);
        void Delete(int id);
        void Update(UpdateEmailModel model);

    }

   
}

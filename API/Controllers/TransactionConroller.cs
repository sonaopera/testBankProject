using BLL.DTO.Transaction;
using BLL.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        private Transaction model;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public  List<GetTransactionModel> Get(DateOnly? Dates, decimal? Amouts, int? AccountId, int skipCount, int takeCount)
        {
            return _transactionService.Get( Dates,  Amouts,  AccountId,  skipCount,  takeCount);
        }



        [HttpPost]
        public void Add(CreateTransactionModel model)
        {
            _transactionService.Add(model);
        }



        [HttpPut]
        public void Update(UpdateTransactionModel model)
        {
            _transactionService.Update(model);
        }


        [HttpDelete]
        public void Delete(int id)
        {
            _transactionService.Delete(id);
        }


    }
}

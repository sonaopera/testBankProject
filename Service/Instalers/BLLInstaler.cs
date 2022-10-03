using BLL.Interfaces;
using BLL.Services;
using DataAccessLayer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Instalers
{
    public static class BLLInstaler
    {
        public static IServiceCollection AddBLLs(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAccountTypeService, AccountTypeService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<ICurrencyService, CurrencyService>();
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IDocumentTypeService, DocumentTypeService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IPhoneNumberService, PhoneNumberService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<IUserService, UserService>();




            return services;



        }


    }
}

using Core.Abstraction.DataAccess;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        protected override string TableName => "User";

        public UserRepository(DataAccess dataAccess) : base(dataAccess)
        {
        }


        public override void Add(User model)
        {
            var query = $@"insert into [{TableName}] ([Name],[UserName],[Password],CreatedDate,EmployeId) 
            values('{model.Name}','{model.UserName}','{model.Password}','{model.CreatedDate.ToString("MM/dd/yyyy HH:mm:ss")}',{model.EmployeeId})";

            dataAccess.RunQuery(query);
        }

        public List<User> Get(string Name, string Password, DateOnly? CreatedDate, int? EmployeeId, int skipCount = 0, int takeCount = 100)
        {
            var sqlWhere = new List<string>();

            if (!(CreatedDate is null))
            {
                sqlWhere.Add($"CreatedDate={CreatedDate}");
            }

            if (!(EmployeeId is null))
            {
                sqlWhere.Add($"EmployeeId={EmployeeId}");
            }


            if (!String.IsNullOrWhiteSpace(Name))
            {
                sqlWhere.Add($"Name like '%{Name}%'");
            }

            if (!String.IsNullOrWhiteSpace(Password))
            {
                sqlWhere.Add($"Password like '%{Password}%'");
            }

            var query = $@"select * from {TableName} {(sqlWhere.Count > 0 ? $"where {string.Join("and", sqlWhere)}" : "")} ORDER BY id OFFSET ({skipCount}) ROWS FETCH NEXT ({takeCount}) ROWS ONLY)";

            return GetByQuery(query).ToList();
        }

        public User Get(string userName)
        {
            var query = $"select top 1 [Id], [Password] from [{TableName}] where [UserName] = '{userName}'";

            var result = dataAccess.SelectDataRow(query);

            return DataRowToUser(result);
        }

        public override void Update(User model)
        {
            var query = $@"upadte {TableName} set Name={model.Name},  CreatedDate={model.CreatedDate},
                         where Id = {model.Id}";
            dataAccess.RunQuery(query);
        }

        protected override User DataRowToModel(DataRow dr)
        {
            if (dr == null)
            {
                return null;
            }

            return new User
            {
                Id = dr.Field<int>("id"),
                Name = dr.Field<string>("Name"),
                Password = dr.Field<string>("Password"),
                CreatedDate = dr.Field<DateTime>("CreateDate"),
                EmployeeId = dr.Field<int>("Gender"),




            };
        }

        protected User DataRowToUser(DataRow dr)
        {
            if (dr == null)
            {
                return null;
            }

            return new User
            {
                Id = dr.Field<int>("id"),
                Password = dr.Field<string>("Password"),
            };
        }


    }
}

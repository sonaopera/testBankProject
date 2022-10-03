
using BLL.DTO.User;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class UserMapper
    {
        public static User MapToUser(this CreatUserModel createUser)
        {
            return new User
            {
                UserName = createUser.UserName,
                EmployeeId = createUser.EmployeeId,
                Name = createUser.Name,
                Password = createUser.Password,
                CreatedDate = createUser.CreateDate
            };

        }
        public static List<GetUserModel> MapToGetUserModel(this IEnumerable<User> user)
        {
            return user.Select(x => x.MapToGetUserModel()).ToList();

        }


        public static GetUserModel MapToGetUserModel(this User user)
        {
            return new GetUserModel
            {
                Id = user.Id,
                CreateDate = user.CreatedDate,
                EmployeeId = user.EmployeeId,
                Name = user.Name



            };



        }

        public static UserCredentials MapToUserCredentialsModel(this User user)
        {
            return new UserCredentials
            {
                UserId = user.Id,
                Password = user.Password
            };
        }

        public static User MapToUser(this UpdateUserModel updateUser)
        {
            return new User
            {
                Id = updateUser.Id,
                CreatedDate = updateUser.CreateDate,
                EmployeeId = updateUser.EmployeeId,
                Name = updateUser.Name,
                Password = updateUser.Password


            };


        }

    }




}

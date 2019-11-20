using CommonLayer.Model;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Service
{
    public class AccountRL : IAccountRL
    {
        private readonly AuthenticationContext context;

        public AccountRL(AuthenticationContext context)
        {
            this.context = context;
        }
        public async Task<string> RegisterUserAsync(UserModel model)
        {
            try
            {
                UserModel userModel = new UserModel()
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    UserType = model.UserType,
                    Email = model.Email,
                    Password = model.Password

                };
                context.userModel.Add(userModel);

                var result = await this.context.SaveChangesAsync();
                if (result > 0)
                {
                    return "user registered successfully";
                }
                else
                {
                    return "something went wrong";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IList<UserModel> GetUser()
        {
            var result = this.context.userModel.Where(g => g.UserType == "user");
            return result.ToList();
        }
    }
}

using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class AccountBL : IAccountBL
    {
        private readonly IAccountRL account;

        public AccountBL(IAccountRL account)
        {
            this.account = account;
        }
        public async Task<string> RegisterUserAsync(UserModel model)
        {
            try
            {
                if(model != null)
                {
                    return await this.account.RegisterUserAsync(model);
                }
                else
                {
                    return "model is empty";
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IList<UserModel> GetUser()
        {
            try
            {
                return  this.account.GetUser();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

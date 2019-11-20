using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IAccountBL
    {
        Task<string> RegisterUserAsync(UserModel model);
        IList<UserModel> GetUser();
    }
}

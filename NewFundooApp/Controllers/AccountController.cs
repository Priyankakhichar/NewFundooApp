


namespace NewFundooApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using BusinessLayer.Interface;
    using CommonLayer.Model;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountBL account;
        public AccountController(IAccountBL account)
        {
            this.account = account;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUserAsync(UserModel model)
        {
            var result = await this.account.RegisterUserAsync(model);
            return Ok(new { result });
        }
        [HttpGet]
        public IActionResult GetUser()
        {
            var result =  this.account.GetUser();
            return Ok(new { result });
        }

    }
}
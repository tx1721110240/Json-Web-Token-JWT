using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class UserController : Controller
    {
        private List<Users> _userList = null;
        public UserController() 
        {
            this._userList = new List<Users> { new Users { UserID = 1, UserEmail = "121221@qq.com", UserName = "张三" } };
        }
        [HttpGet]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        public IEnumerable<Users> Get()
        {
            return _userList;
        }
        [HttpPost]
        public IEnumerable<Users> GetUserByID(int id)
        {
            return _userList;
        }

    }
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
    }
}

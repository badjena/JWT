using JWTToken.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("GetData")]
        public string GetData()
        {
            return "Authenticated with JWT";
        }

        [HttpGet]
        [Route("Details")]
        public string Details()
        {
            return "Authenticated with JWT";
        }

        [Authorize]
        [HttpPost]
        public string Adduser(Users user)
        {
            return "User added with Username" + user.Username;
        }
    }
}

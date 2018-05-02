using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace StudentSample.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {
            
        }

        [HttpPost]
        public async Task LogOut()
        {
            await HttpContext.SignOutAsync("cookie");
            await HttpContext.SignOutAsync("oidc");
        }
    }
}
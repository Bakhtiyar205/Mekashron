using Mekashron.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mekashron.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("login");
        }

        public IActionResult Login()
        {
            LoginVM loginVM = new LoginVM();
            return View(loginVM);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVm)
        {
            var client = new MekashronLogin.ICUTechClient();
            var result = await client.LoginAsync(loginVm.UserName, loginVm.Password, "");
            loginVm.Response = JsonConvert.DeserializeObject<LoginResponse>(result.@return);
            return View(loginVm);
        }
    }
}

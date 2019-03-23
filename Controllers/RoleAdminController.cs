using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogs.Controllers
{
    public class RoleAdminController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        public RoleAdminController(RoleManager<IdentityRole> roleMgr)
        {
            roleManager = roleMgr;
        }

        public IActionResult Index() => View(roleManager.Roles);

    }
}
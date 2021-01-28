/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DagBok.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DagBok.Views.Inlägg
{
    public class InläggViewComponent : ViewComponent
    {
        private DbContextOptions<ApplicationDbContext> db = new DbContextOptions<ApplicationDbContext>();

        public readonly UserManager<IdentityUser> _userManager;
        public InläggViewComponent(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync((System.Security.Claims.ClaimsPrincipal)User);
            ApplicationDbContext context = new ApplicationDbContext(db);
            IEnumerable<Models.Inlägg> mc = await context.Inlägg.ToListAsync();
            return View("Index",mc);
        }

    }
}
*/
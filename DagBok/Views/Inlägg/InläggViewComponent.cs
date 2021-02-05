using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DagBok.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DagBok.Controllers;
using DagBok.ViewModels;

namespace DagBok.Views.Inlägg
{
    public class InläggViewComponent : ViewComponent
    {
        private ApplicationDbContext _context { get; set; }

        public readonly UserManager<IdentityUser> _userManager;
        public InläggViewComponent(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context =context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync((System.Security.Claims.ClaimsPrincipal)User);
           /* ApplicationDbContext context = new ApplicationDbContext(db);*/
      
            var mc = await _context.Inlägg
                .Select(s => new InläggIndexModel
                {
                    Id = s.Id,
                    Datum = s.Datum,
                    Innehåll = s.Innehåll,
                    IdUserId = s.IdUserId,
                    User = s.User
                }).OrderBy(s => s.Datum).ToListAsync();
            return View(mc);
        }

    }
}

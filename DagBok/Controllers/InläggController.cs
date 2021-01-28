using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DagBok.Data;
using DagBok.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DagBok.Controllers
{
    public class InläggController : Controller
    {
        private readonly ApplicationDbContext _context;
        public readonly UserManager<IdentityUser> _userManager;
        public InläggController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        private async Task<IdentityUser> GetCurrentUser()
        {
            return await _userManager.GetUserAsync(HttpContext.User);
        }

  



    /*    protected Inlägg setUserId { get; set; }

*/

       /* protected  string UserName()
        {

            var userStr =  _userManager.GetUserAsync(User).ToString();
            return userStr;
        }


        protected string userStr = UserName();*/







        [Authorize]
        // GET: Inlägg
        public async Task<IActionResult> Index()
        {
            /*
                        var user = await _userManager.GetUserAsync(User);
                        var EmptyInlägg = new List<Inlägg>();*/

            var inlägg = await _context.Inlägg
                .Select(s => new InläggIndexModel
                {
                    Id = s.Id,
                    Datum = s.Datum,
                    Innehåll = s.Innehåll,
                    IdUserId = s.IdUserId,
                    User = s.User
                }).ToListAsync();




/*            var inlägg = await _context.Inlägg.ToListAsync();
*/




          /*  List<InläggIndexModel>  model = new List <InläggIndexModel>
            {
                Id = inlägg.Id,
                Innehåll = inlägg.Innehåll,
                Datum = inlägg.Datum,
                IdUserId = inlägg.IdUserId,
                User = inlägg.User

            };
*/

           
            ;


            /*                var singleInl = await _context.Inlägg.FindAsync(int.Parse(p.IdUserId));*/



            /*  var inl = (from i in _context.Inlägg
                  where user.Id.Equals(p.IdUserId)
                  select i).FirstOrDefault();*/
            /*  if (inl.Equals(p) )
              {*/

            /* if (inl.IdUserId == null)
             {
                 return View(EmptyInlägg);
             }*/

            /*
                            if (inl.IdUserId == null)
                            {
                                return View(EmptyInlägg);
                
            
            
            }*/
            /* }*/






            /*  foreach (var p in inlägg)
              {
                  var userName = (from u in _context.Users
                      where u.Id.Equals(p.IdUserId)
                      select u);

                  if (user.Id == p.IdUserId)

                  {
                      var UserInl = inlägg;

                      return View(UserInl);
                  }   }
  */






            return View(inlägg);
            /* var inläggsLista = new List<Inlägg>();
             foreach (var p in inlägg)
             {
                 var userName = (from u in _context.Users
                     where u.Id.Equals(p.IdUserId)
                     select u.UserName).SingleOrDefault();
                 var post = new Inlägg()
                 {
                     Innehåll = p.Innehåll,
                     Datum = p.Datum,

                 };

                 inläggsLista.Add(post);
             */


        }



        [Authorize]
        // GET: Inlägg/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inlägg = await _context.Inlägg
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inlägg == null)
            {
                return NotFound();
            }

            return View(inlägg);
        }

        // GET: Inlägg/Create
        public IActionResult Create(InläggCreateModel ic)
        {

        /*    ic = new InläggCreateModel
            {
                Id = inlägg.Id,
                Innehåll = inlägg.Innehåll,
                Datum = inlägg.Datum,
                IdUserId = inlägg.IdUserId,
                User = inlägg.User

            };
*/

            return View();
        }

        [Authorize]
        // POST: Inlägg/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Datum,Innehåll,IdUserId")] Inlägg inlägg)
        {
            /*            ModelState.Clear();
            *//*            var user = await _userManager.GetUserAsync(HttpContext.User);
            */
            var user = await GetCurrentUser();
            inlägg.User = user;


            if (ModelState.IsValid)
            {

                /* inlägg = (Inlägg) _context.Inlägg.Select(s => new InläggCreateModel
                {
                    Id = s.Id,
                    Datum = s.Datum,
                    Innehåll = s.Innehåll,
                    IdUserId = s.IdUserId,
                    User = s.User
                });

                _context.Inlägg.Add(inlägg);
*/


                _context.Inlägg.Add(inlägg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));



            }
            return View(inlägg);
        }

        // GET: Inlägg/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inlägg = await _context.Inlägg.FindAsync(id);
            if (inlägg == null)
            {
                return NotFound();
            }
            return View(inlägg);
        }

        // POST: Inlägg/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Datum,Innehåll,IdUserId")] Inlägg inlägg)
        {


            var user = await GetCurrentUser();
            inlägg.User = user;

            if (id != inlägg.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inlägg);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InläggExists(inlägg.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(inlägg);
        }

        // GET: Inlägg/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inlägg = await _context.Inlägg
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inlägg == null)
            {
                return NotFound();
            }

            return View(inlägg);
        }

        // POST: Inlägg/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inlägg = await _context.Inlägg.FindAsync(id);
            _context.Inlägg.Remove(inlägg);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InläggExists(int id)
        {
            return _context.Inlägg.Any(e => e.Id == id);
        }
    }
}

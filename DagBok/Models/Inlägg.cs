using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DagBok.Models
{
    public class Inlägg
    {


/*

        public readonly UserManager<IdentityUser> _userManager;


        public Inlägg(
            UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;

        }*/

        public int Id { get; set; }

        public string Datum { get; set; }

        public string Innehåll { get; set;}

        [Required]
        [ForeignKey("User")]
        public string IdUserId { get; set; }
        public IdentityUser User { get; set;}

}
}

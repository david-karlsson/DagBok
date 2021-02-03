using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DagBok.ViewModels
{
    public class InläggIndexModel
    {

        public int Id { get; set; }

        [Display(Name = "Datum")]
        public string Datum { get; set; }

        [Display(Name = "Innehåll")]
        public string Innehåll { get; set; }


        [Required]
        [ForeignKey("User")]
        public string IdUserId { get; set; }
        public IdentityUser User { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DagBok.Models
{
    public class InläggIndexModel
    {

        public int Id { get; set; }

        [Display(Name = "Datum")]
        public string Datum { get; set; }

        [Display(Name = "Innehåll")]
        public string Innehåll { get; set; }

    }
}

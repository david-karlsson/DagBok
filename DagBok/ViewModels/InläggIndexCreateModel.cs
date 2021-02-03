using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DagBok.Controllers;
using DagBok.Models;

namespace DagBok.ViewModels
{
    public class InläggIndexCreateModel

    {
        private List<Inlägg> inlägg;

        public InläggIndexCreateModel()
        {


        }

        public InläggIndexCreateModel(List<InläggIndexModel> inläggIndexModelList)
        {

            inläggIndexModelList = InläggIndexModelList;

        }

        public InläggIndexCreateModel(List<Inlägg> inlägg)
        {
            this.inlägg = inlägg;
        }

        public InläggCreateModel InläggCreateModel{get; set; }
        public List <InläggIndexModel> InläggIndexModelList { get; set; } 

        public List<Inlägg> InläggsList { get; set; }
    }
}

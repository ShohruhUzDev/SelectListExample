using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectListExample.Models.ViewModels
{
    public class CustomerCreateModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }
        public IEnumerable<SelectListItem> Cities { get; set; }

    }
}

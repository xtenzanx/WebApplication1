using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MovieEditViewModel
    {
        public Movie Movie { get; set; }
        public SelectList Genres { get; set; }
    }
}

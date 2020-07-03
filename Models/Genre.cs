using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }
    }
}

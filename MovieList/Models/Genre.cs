using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieList.Models
{
    public class Genre
    {
        public string GenreId { get; set; }
        public string Name { get; set; }

    }
}

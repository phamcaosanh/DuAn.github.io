using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Image.Models;

namespace Image.Data
{
    public class ImageContext : DbContext
    {
        public ImageContext (DbContextOptions<ImageContext> options)
            : base(options)
        {
        }

        public DbSet<Image.Models.Comics> Comics { get; set; }
    }
}

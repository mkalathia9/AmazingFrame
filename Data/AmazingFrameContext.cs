using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AmazingFrame.Models;

namespace AmazingFrame.Data
{
    public class AmazingFrameContext : DbContext
    {
        public AmazingFrameContext(DbContextOptions<AmazingFrameContext> options)
           : base(options)
        {
        }
        public DbSet<Frame> Frame { get; set; }
    }
}

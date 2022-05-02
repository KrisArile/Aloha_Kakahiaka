#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ALOHA.Models;

namespace ALOHA.Data
{
    public class ALOHAContext : DbContext
    {
        public ALOHAContext (DbContextOptions<ALOHAContext> options)
            : base(options)
        {
        }

        public DbSet<ALOHA.Models.Item> Item { get; set; }
    }
}

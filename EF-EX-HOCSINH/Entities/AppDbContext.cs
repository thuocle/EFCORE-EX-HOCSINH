using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EX_HOCSINH.Entities
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<HocSinh> HocSinh { get; set; }
        public virtual DbSet<Lop> Lop { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server = THUOCLE\\THUOCLE; Database = QLHocSinh; Trusted_Connection = True; " +
                $"TrustServerCertificate=True");
        }
    }
}

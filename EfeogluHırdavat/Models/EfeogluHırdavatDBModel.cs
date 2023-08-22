using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EfeogluHırdavat.Models
{
    public partial class EfeogluHırdavatDBModel : DbContext
    {
        public EfeogluHırdavatDBModel()
            : base("name=EfeogluHırdavatDBModel")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

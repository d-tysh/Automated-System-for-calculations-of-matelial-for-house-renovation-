namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ASModel : DbContext
    {
        public ASModel()
            : base("name=ASModel")
        {
        }

        public virtual DbSet<CalculationHistory> CalculationHistories { get; set; }
        public virtual DbSet<RenovationWork> RenovationWorks { get; set; }
        public virtual DbSet<TypesMaterial> TypesMaterials { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RenovationWork>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}

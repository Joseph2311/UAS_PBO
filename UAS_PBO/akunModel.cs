namespace UAS_PBO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class akunModel : DbContext
    {
        public akunModel()
            : base("name=akunModel")
        {
        }

        public virtual DbSet<Akun> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

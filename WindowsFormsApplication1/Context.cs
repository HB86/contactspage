namespace WindowsFormsApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    //Add-Migration
    //Update-Database
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Database1Entities")
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}

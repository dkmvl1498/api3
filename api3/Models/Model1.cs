namespace api3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblAccount> tblAccounts { get; set; }
        public virtual DbSet<tblNote> tblNotes { get; set; }
        public virtual DbSet<tblNoteImg> tblNoteImgs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblAccount>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<tblAccount>()
                .Property(e => e.userpass)
                .IsUnicode(false);

            modelBuilder.Entity<tblAccount>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<tblNote>()
                .Property(e => e.gps)
                .IsUnicode(false);

            modelBuilder.Entity<tblNoteImg>()
                .Property(e => e.imglink)
                .IsUnicode(false);
        }
    }
}

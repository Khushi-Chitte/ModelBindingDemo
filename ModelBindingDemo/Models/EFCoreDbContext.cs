using Microsoft.EntityFrameworkCore;

namespace ModelBindingDemo.Models
{
    public class EFCoreDbContext: DbContext
    {
        public EFCoreDbContext() { }

        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            //optionsBuilder.UseSqlServer("Server=KHUSHI\\SQLEXPRESS,Databse=EFCoreDemo;" + "Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;");
            optionsBuilder.UseSqlServer("Server=KHUSHI\\SQLEXPRESS;Database=EFCoreDemo;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;");

        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }
}

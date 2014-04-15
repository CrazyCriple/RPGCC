using Microsoft.AspNet.Identity.EntityFramework;

namespace RPGCC.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<RPGCC.Models.Character> Characters { get; set; }

        public System.Data.Entity.DbSet<RPGCC.Models.Wizard.BasicDetails> BasicDetails { get; set; }

        public System.Data.Entity.DbSet<RPGCC.Models.Wizard.BasicStats> BasicStats { get; set; }
    }
}
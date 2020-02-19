using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ComplainManager.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
       public virtual ICollection<Issue> Issues { get; set; }
       public virtual ICollection<Rating> Ratings { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Assignee>().HasKey(n => n.AssigneeID);
            modelBuilder.Entity<Issue>().HasKey(n => n.IssueID);
            modelBuilder.Entity<Department>().HasKey(n => n.DepartmnentID);
            modelBuilder.Entity<Rating>().HasKey(n => n.RatingID);
            modelBuilder.Entity<Status>().HasKey(n => n.StatusID);


            //Forgein Keys

            modelBuilder.Entity<Issue>().HasRequired(m => m.applicationUser).WithMany(m => m.Issues).HasForeignKey(l => l.UserID);
            modelBuilder.Entity<Issue>().HasRequired(m => m.status).WithMany(m => m.Issues).HasForeignKey(l => l.StatusID);
            modelBuilder.Entity<Issue>().HasRequired(m => m.department).WithMany(m => m.Issues).HasForeignKey(l => l.DepartmnentID);
            modelBuilder.Entity<Issue>().HasRequired(m => m.assignee).WithMany(m => m.Issues).HasForeignKey(l => l.AssigneeID);

            //Rating  
            modelBuilder.Entity<Rating>().HasRequired(m => m.applicationUser).WithMany(m => m.Ratings).HasForeignKey(l => l.UserID);
            modelBuilder.Entity<Rating>().HasRequired(m => m.issue).WithMany(m => m.Ratings).HasForeignKey(l => l.IssueID);





        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
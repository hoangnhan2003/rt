using Domain.Entity;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new GitConfiguration());
            modelBuilder.ApplyConfiguration(new GitRepoConfiguration());

            modelBuilder.ApplyConfiguration(new HistoryConfiguration());
            modelBuilder.ApplyConfiguration(new IssueConfiguration());
            modelBuilder.ApplyConfiguration(new IssueTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PriotyConfiguration());

            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectUserConfiguration());
            modelBuilder.ApplyConfiguration(new MemberRoleConfiguration());
            modelBuilder.ApplyConfiguration(new SpaceConfiguration());

            modelBuilder.ApplyConfiguration(new SpaceUserConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
            modelBuilder.ApplyConfiguration(new WikiConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ActiveTypeConfigurations());
            //modelBuilder.Seeder();
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Active_Type> Active_Types { get; set; }    
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Comment> Comments {  get; set; }   
        public DbSet<Git> Gits { get; set; }    
        public DbSet<Git_Repo> Git_Repos { get; set; }
        public DbSet<History> Histories { get; set; }   
        public DbSet<Issue> Issues { get; set; }    
        public DbSet<Issue_Type> Issue_Types { get; set; }  
        public DbSet<Priority> Priority { get; set; } 
        public DbSet<Project> Projects { get; set; }    
        public DbSet<Project_User> Project_Users { get; set; }
        public DbSet<Member_Role> Role_Menbers { get; set; }    
        public DbSet<Space> Spaces { get; set; }    
        public DbSet<Space_User> Space_Users { get; set; }
        public DbSet<Status> Statuses { get; set; } 
        public DbSet<Wiki> Wikis { get; set; }  
    }
}



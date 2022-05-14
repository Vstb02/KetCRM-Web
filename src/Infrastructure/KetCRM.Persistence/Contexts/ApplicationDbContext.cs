using KetCRM.Application.Common.Interfaces;
using KetCRM.Domain.Entities;
using KetCRM.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Parent> Parents { get; set; } = null!;
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<Representative> Representatives { get; set; } = null!;
        public DbSet<SchoolType> SchoolTypes { get; set; } = null!;
        public DbSet<Specialization> specializations { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;

        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AddressConfiguration());
            builder.ApplyConfiguration(new DepartmentConfiguration());
            builder.ApplyConfiguration(new GroupConfiguration());
            builder.ApplyConfiguration(new ParentConfiguration());
            builder.ApplyConfiguration(new RepresentativeConfiguration());
            builder.ApplyConfiguration(new SchoolTypeConfiguration());
            builder.ApplyConfiguration(new SpecializationConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());

            base.OnModelCreating(builder);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}

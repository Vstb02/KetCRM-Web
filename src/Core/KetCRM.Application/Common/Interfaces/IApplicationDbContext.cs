using KetCRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Address> Addresses { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<Parent> Parents { get; set; }
        DbSet<Person> Persons { get; set; }
        DbSet<Representative> Representatives { get; set; }
        DbSet<SchoolType> SchoolTypes { get; set; }
        DbSet<Specialization> specializations { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        Task<int> SaveChangesAsync();
    }
}

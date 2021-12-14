using CoreMultiJoinsProject.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMultiJoinsProject.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Departments> departments { get; set; }
        public DbSet<Countries> countries { get; set; }
        public DbSet<States> states { get; set; }
        public DbSet<Cities> cities { get; set; }
    }
}

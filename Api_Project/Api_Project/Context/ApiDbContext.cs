using Api_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Project.Context;

public class ApiDbContext:DbContext
{
    public ApiDbContext()
    {
    }

    public ApiDbContext(DbContextOptions<ApiDbContext> options):base(options)
    {

    }
    public DbSet<Employee> employees { get; set; }
    public DbSet<Employattendance> Employattendance { get; set; }
}

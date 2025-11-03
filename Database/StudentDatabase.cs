using Microsoft.EntityFrameworkCore;
using StudentApi.Models;

namespace StudentApi.Database;

public class StudentsDbContext : DbContext
{
    public StudentsDbContext(DbContextOptions<StudentsDbContext> ops) : base(ops) { }
    public DbSet<Students> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
}

using api.Model;
using Microsoft.EntityFrameworkCore;

public class PersonContext : DbContext
{
    public PersonContext()
    { }

    public PersonContext(DbContextOptions<PersonContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().ToTable("Person");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("Person");
    }

}
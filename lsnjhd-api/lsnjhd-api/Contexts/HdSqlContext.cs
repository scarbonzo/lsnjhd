using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class HdSqlContext : DbContext
{
    public HdSqlContext(DbContextOptions<HdSqlContext> options) : base(options) { }

    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<Program> Programs { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<Severity> Severities { get; set; }
    public DbSet<TicketTemplate> TicketTemplates { get; set; }
    public DbSet<TicketType> TicketTypes { get; set; }
    public DbSet<User> Users { get; set; }
}

public class RecruiterContextFactory : IDesignTimeDbContextFactory<HdSqlContext>
{
    public HdSqlContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<HdSqlContext>();
        optionsBuilder.UseSqlServer(@"Server=192.168.50.116;Database=lsnjhd;User Id=lsnjhd;Password=lsnjhd;");

        return new HdSqlContext(optionsBuilder.Options);
    }
}

using Microsoft.EntityFrameworkCore;
using CloudformationGoodies.Shared.Model;

namespace CloudformationGoodies.Api.Context
{
    public class StackContext : DbContext
    {
        public StackContext(DbContextOptions opts) : base(opts) { }

        public DbSet<Stack> Stacks { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using CloudformationGoodies.Shared.Model;

namespace CloudformationGoodies.Api.Context
{
    public class StackComponentContext : DbContext
    {
        public StackComponentContext(DbContextOptions opts) : base(opts) { }

        public DbSet<StackComponent> StackComponents { get; set; }
    }
}

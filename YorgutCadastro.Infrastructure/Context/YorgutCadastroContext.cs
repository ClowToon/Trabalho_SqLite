using Microsoft.EntityFrameworkCore;
using YorgutCadastro.Domain.Entities;

namespace YorgutCadastro.Infrastructure.Context
{
    public class YorgutCadastroContext : DbContext
    {
        public YorgutCadastroContext(DbContextOptions options) : base(options) { }

        public DbSet<YorgutCadastroEntity> YorgutCadastroEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

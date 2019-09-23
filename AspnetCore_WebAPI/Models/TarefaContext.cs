
using Microsoft.EntityFrameworkCore;
namespace AspnetCore_WebApi.Models
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options)
            : base(options)
        { }
        public DbSet<TarefaItem> TarefaItens { get; set; }
    }
}

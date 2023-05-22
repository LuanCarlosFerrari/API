using Microsoft.EntityFrameworkCore;
using client.Models;
using order.Models;
using product.Models;

namespace api.DBContext
{
    /// <summary>
    /// Classe AppDBContext.
    /// 
    /// Representa o contexto do banco de dados da aplicação.
    /// Herda da classe DbContext fornecida pelo Entity Framework Core.
    /// O contexto é responsável por mapear as entidades da aplicação para as tabelas do banco de dados
    /// e também por estabelecer a conexão com o banco de dados.
    /// </summary>
    public class AppDBContext : DbContext
    {
        /// <summary>
        /// DbSet da entidade Client. Representa a tabela de clientes no banco de dados.
        /// </summary>
        public DbSet<Client>? Clients { get; set; }

        /// <summary>
        /// DbSet da entidade Order. Representa a tabela de pedidos no banco de dados.
        /// </summary>
        public DbSet<Order>? Orders { get; set; }

        //public DbSet<OrderProducts>? OrderProducts { get; set; }

        /// <summary>
        /// DbSet da entidade Product. Representa a tabela de produtos no banco de dados.
        /// </summary>
        public DbSet<Product>? Products { get; set; }

        /// <summary>
        /// Construtor da classe AppDBContext.
        /// </summary>
        /// <param name="options">As opções de configuração do contexto, fornecidas por meio de DbContextOptions<AppDBContext>.</param>
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProducts>().HasNoKey();
        }*/

        /// <summary>
        /// Método chamado durante a configuração do contexto.
        /// Permite configurar opções adicionais para o contexto, como a string de conexão com o banco de dados.
        /// </summary>
        /// <param name="optionsBuilder">O objeto DbContextOptionsBuilder para configuração.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mydatabase;Username=postgres;Password=123");
        }
    }
}

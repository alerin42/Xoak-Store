using System.Collections.Generic;
using System.Data.Entity;
using XOakStore.Models;

namespace XOakStore.App_Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class OrderContext : DbContext{
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options){
            this.Database.EnsureCreated(); //自动建库建表
        }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<OrderDetails> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
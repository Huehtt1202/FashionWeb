using DataEntity.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    public class FashionWebDBContext : DbContext
    {
        public DbSet<DAO.Category> Categories { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Attributes> Attributes { get; set; }
        public DbSet<Customer> Cutomers { get; set; }
        public DbSet<GoodsReceivedNote> GoodsReceivedNotes { get; set; }
        public DbSet<InVoice> InVoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsOnInvoice> ProductsOnInvoices { get; set; }
        public DbSet<ProductsOnNote> ProductsOnNotes { get; set; }
        public DbSet<PropertyOfAttributes> PropertyOfAttributes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        //public object DataEntity { get; internal set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //var entityTypes = modelBuilder.Model.GetEntityTypes();

        //    //modelBuilder.Entity<PersonEntity>().HasQueryFilter(b => !b.IsDeleted);
        //    FilterSoftDelete.ApplySoftDeleteQueryFilter(modelBuilder);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}

using Microsoft.EntityFrameworkCore;
using Restaurant.Core.Domain.Entities.Dish;
using Restaurant.Core.Domain.Entities.Ingredient;
using Restaurant.Core.Domain.Entities.Order;
using Restaurant.Core.Domain.Entities.Relations;
using Restaurant.Core.Domain.Entities.Table;

namespace Restaurant.Infrastructure.Persistence.Context
{
    public class RestaurantApiContext : DbContext
    {
        public RestaurantApiContext(DbContextOptions<RestaurantApiContext> options) : base(options) {}

        public DbSet<Dishes> Dishes { get; set; }
        public DbSet<DishIngredient> DishIngredients { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDish> OrderDishes { get; set; }
        public DbSet<Tables> Tables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Dishes
            modelBuilder.Entity<Dishes>().ToTable("Dishes");
            modelBuilder.Entity<Ingredients>().ToTable("Ingredientes");
            modelBuilder.Entity<DishIngredient>().ToTable("DishIngredients");
            modelBuilder.Entity<Orders>().ToTable("Orders");
            modelBuilder.Entity<OrderDish>().ToTable("OrderDishes");
            modelBuilder.Entity<Tables>().ToTable("Tables");
            #endregion

            #region Primary Keys
            modelBuilder.Entity<Dishes>().HasKey(d => d.Id);
            modelBuilder.Entity<Ingredients>().HasKey(i => i.Id);
            modelBuilder.Entity<DishIngredient>().HasKey(di => new { di.DishId, di.IngredientId });
            modelBuilder.Entity<Orders>().HasKey(o => o.Id);
            modelBuilder.Entity<OrderDish>().HasKey(od => new { od.OrderId, od.DishId });
            modelBuilder.Entity<Tables>().HasKey(t => t.Id);
            #endregion

            #region Dish
            modelBuilder.Entity<Dishes>(entity =>
            {
                entity.Property(d => d.Name).IsRequired().HasMaxLength(100);
                entity.Property(d => d.Price).IsRequired();
                entity.Property(d => d.Servings).IsRequired();
                entity.Property(d => d.Category).HasConversion<int>();

            });
            #endregion

            #region Ingredients
            modelBuilder.Entity<Ingredients>(entity =>
            {
                entity.Property(i => i.Name).IsRequired().HasMaxLength(100);
                entity.HasIndex(i => i.Name).IsUnique();
            });
            #endregion

            #region DishIngredients 
            modelBuilder.Entity<DishIngredient>(entity =>
            {
                entity.HasOne(di => di.Dish)
                    .WithMany(d => d.Ingredients)
                    .HasForeignKey(di => di.DishId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(di => di.Ingredient)
                    .WithMany(i => i.Dishes)
                    .HasForeignKey(di => di.IngredientId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            #endregion

            #region Tables
            modelBuilder.Entity<Tables>(entity =>
            {
                entity.Property(t => t.Capacity).IsRequired();
                entity.Property(t => t.Description).HasMaxLength(200);
                entity.Property(t => t.Status).HasConversion<int>();
            });

            #endregion

            #region Orders
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(o => o.Subtotal).IsRequired();
                entity.Property(o => o.Status).HasConversion<int>();
                entity.HasOne(o => o.Table)
                    .WithMany(t => t.orders)
                    .HasForeignKey(o => o.TableId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            #endregion

            #region OrderDish
            modelBuilder.Entity<OrderDish>(entity =>
            {
                entity.Property(od => od.Quantity).IsRequired();
                entity.HasOne(od => od.Order)
                    .WithMany(o => o.OrderDishes)
                    .HasForeignKey(od => od.OrderId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(od => od.Dish)
                    .WithMany(d => d.OrderDishes)
                    .HasForeignKey(od => od.DishId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            #endregion


            base.OnModelCreating(modelBuilder);
        }
    }
}

namespace Supply_Chain_Backend.Models
{
    public partial class gis44_SupplyChainContext : IdentityDbContext<ApplicationUser>
    {
        public gis44_SupplyChainContext()
        {
        }

        public gis44_SupplyChainContext(DbContextOptions<gis44_SupplyChainContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart_Item> Cart_Items { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<OrderHeader> OrderHeaders { get; set; }
        public virtual DbSet<Order_Item> Order_Items { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shopping_Cart> Shopping_Carts { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Store_Product> Store_Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=gis44_SupplyChain;Persist Security Info=True;User ID=gis44_SupplyChain;Password=12345;Encrypt=True; Integrated Security=false;Trust Server Certificate=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);  // Ensure Identity configurations are applied

            modelBuilder.Entity<Cart_Item>(entity =>
            {
                entity.HasOne(d => d.Product).WithMany(p => p.Cart_Items).HasConstraintName("FK_Cart Items_Product");

                entity.HasOne(d => d.ShoppingCart).WithMany(p => p.Cart_Items).HasConstraintName("FK_Cart Items_Shopping Cart");
            });

            modelBuilder.Entity<Order_Item>(entity =>
            {
                entity.HasOne(d => d.OrederHearder).WithMany(p => p.Order_Items).HasConstraintName("FK_Order Items_OrderHeader");

                entity.HasOne(d => d.Product).WithMany(p => p.Order_Items).HasConstraintName("FK_Order Items_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Products).HasConstraintName("FK_Product_Category");
            });

            modelBuilder.Entity<Store_Product>(entity =>
            {
                entity.HasOne(d => d.Product).WithMany(p => p.Store_Products).HasConstraintName("FK_Store Product_Product");

                entity.HasOne(d => d.Store).WithMany(p => p.Store_Products).HasConstraintName("FK_Store Product_Stores");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

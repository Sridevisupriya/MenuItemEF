namespace CaseStudy2
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TruYumContext : DbContext
    {
       
        public TruYumContext()
            : base("name=TruYumContext1")
        {
        }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
    }

    
}
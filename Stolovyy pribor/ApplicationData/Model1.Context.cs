﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stolovyy_pribor.ApplicationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        private static Entities _context;
            public static Entities GetContext()
        {
            if (_context == null)
                _context = new Entities();
            return _context;
                }
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderProduct> OrderProduct { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeCategory> TypeCategory { get; set; }
        public virtual DbSet<TypeManufacturer> TypeManufacturer { get; set; }
        public virtual DbSet<TypeOrder> TypeOrder { get; set; }
        public virtual DbSet<TypeStatus> TypeStatus { get; set; }
        public virtual DbSet<TypeSuppluer> TypeSuppluer { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
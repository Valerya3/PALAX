﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PALAX
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PALAXEntities : DbContext
    {
        public PALAXEntities()
            : base("name=PALAXEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClientsFizSet> ClientsFizSet { get; set; }
        public virtual DbSet<ClientsYourSet> ClientsYourSet { get; set; }
        public virtual DbSet<SaleSet> SaleSet { get; set; }
        public virtual DbSet<StaffSet> StaffSet { get; set; }
    }
}

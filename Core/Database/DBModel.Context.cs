﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apteka.Core.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AptekaEntities : DbContext
    {
        public AptekaEntities()
            : base("name=AptekaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adress> Adress { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Dogovor_na_okazanie_uslug> Dogovor_na_okazanie_uslug { get; set; }
        public virtual DbSet<Dogovor_o_sotrudnichestve> Dogovor_o_sotrudnichestve { get; set; }
        public virtual DbSet<Dolzhnost> Dolzhnost { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Kabinet> Kabinet { get; set; }
        public virtual DbSet<Oborudovanie> Oborudovanie { get; set; }
        public virtual DbSet<Pokupka> Pokupka { get; set; }
        public virtual DbSet<Pokupka_preparat> Pokupka_preparat { get; set; }
        public virtual DbSet<Postavka> Postavka { get; set; }
        public virtual DbSet<Postavka_zakaz> Postavka_zakaz { get; set; }
        public virtual DbSet<Postavshic> Postavshic { get; set; }
        public virtual DbSet<Preparat> Preparat { get; set; }
        public virtual DbSet<Priem> Priem { get; set; }
        public virtual DbSet<schet> schet { get; set; }
        public virtual DbSet<Sklad> Sklad { get; set; }
        public virtual DbSet<Specialist> Specialist { get; set; }
        public virtual DbSet<Specialist_type> Specialist_type { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Zakaz> Zakaz { get; set; }
    }
}

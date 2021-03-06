﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DatabaseLibrary.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using static System.Configuration.ConfigurationManager;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DatabaseLibrary.Context
{
    public partial class AccountContext : DbContext
    {
        public AccountContext()
        {
        }

        public AccountContext(DbContextOptions<AccountContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerSequence> CustomerSequence { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString =
                    $"Data Source={AppSettings["DatabaseServer"]};" +
                    $"Initial Catalog={AppSettings["AccountCatalog"]};" +
                    "Integrated Security=True";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerSequence>(entity =>
            {
                entity.Property(e => e.SequencePreFix)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.HasOne(d => d.CustomerIdentifierNavigation)
                    .WithMany(p => p.CustomerSequence)
                    .HasForeignKey(d => d.CustomerIdentifier)
                    .HasConstraintName("FK_CustomerSequence_Customers");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerIdentifier);

                entity.Property(e => e.City).HasMaxLength(15);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ContactName).HasMaxLength(30);

                entity.Property(e => e.ContactTitle).HasMaxLength(30);

                entity.Property(e => e.Country).HasMaxLength(15);

                entity.Property(e => e.PostalCode).HasMaxLength(10);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.HasOne(d => d.CustomerIdentifierNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerIdentifier)
                    .HasConstraintName("FK_Orders_Customers");
            });


            OnModelCreatingPartial(modelBuilder);
        }

        public void CheckAdditons() 
        {
            ChangeTracker.DetectChanges();

            foreach (EntityEntry entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added)
                {
                    Console.WriteLine(entry.Entity.GetType());

                    if (entry.Entity is Customers ee)
                    {
                        Console.WriteLine(ee.CompanyName);
                    }

                }
            }
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        /// <summary>
        /// Custom to examine data
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            /*
             * Change PeekChangesNone to PeekChanges
             */
            
            #if PeekChanges

            ChangeTracker.DetectChanges();
            foreach (var entry in ChangeTracker.Entries())
            {

                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    switch (entry.Entity)
                    {
                        case Customers entity:
                        {
                            var item = entity;
                            break;
                        }
                        case CustomerSequence entity:
                        {
                            var item = entity;
                            break;
                        }
                        case Order order:
                        {
                            var item = order;
                            break;
                        }
                    }
                }
            }

            #endif


            return base.SaveChanges();
        }
    }
}
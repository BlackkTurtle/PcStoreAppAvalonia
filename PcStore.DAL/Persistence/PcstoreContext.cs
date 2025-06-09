using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PcStore.DAL.Models;

namespace PcStore.DAL.Persistence;

public partial class PcstoreContext : DbContext
{
    public PcstoreContext()
    {
    }

    public PcstoreContext(DbContextOptions<PcstoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Advertisement> Advertisements { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Characteristic> Characteristics { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Contragent> Contragents { get; set; }

    public virtual DbSet<ContragentDescription> ContragentDescriptions { get; set; }

    public virtual DbSet<Count> Counts { get; set; }

    public virtual DbSet<CountManipulation> CountManipulations { get; set; }

    public virtual DbSet<CountOperation> CountOperations { get; set; }

    public virtual DbSet<DeliverAddress> DeliverAddresses { get; set; }

    public virtual DbSet<DeliverOption> DeliverOptions { get; set; }

    public virtual DbSet<Inventarization> Inventarizations { get; set; }

    public virtual DbSet<Manipulation> Manipulations { get; set; }

    public virtual DbSet<Nakladni> Nakladnis { get; set; }

    public virtual DbSet<NakladniProduct> NakladniProducts { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentType> PaymentTypes { get; set; }

    public virtual DbSet<Photo> Photos { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCharacteristic> ProductCharacteristics { get; set; }

    public virtual DbSet<ProductInventarization> ProductInventarizations { get; set; }

    public virtual DbSet<ProductRestorage> ProductRestorages { get; set; }

    public virtual DbSet<ProductStorage> ProductStorages { get; set; }

    public virtual DbSet<Restorage> Restorages { get; set; }

    public virtual DbSet<Storage> Storages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasMany(d => d.Characteristics).WithMany(p => p.Categories)
                .UsingEntity<Dictionary<string, object>>(
                    "CategoryCharacteristic",
                    r => r.HasOne<Characteristic>().WithMany().HasForeignKey("CharacteristicsId"),
                    l => l.HasOne<Category>().WithMany().HasForeignKey("CategoriesId"),
                    j =>
                    {
                        j.HasKey("CategoriesId", "CharacteristicsId");
                        j.ToTable("CategoryCharacteristics");
                        j.HasIndex(new[] { "CharacteristicsId" }, "IX_CategoryCharacteristics_CharacteristicsId");
                    });
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasIndex(e => e.ParentId, "IX_Comments_ParentId");

            entity.HasIndex(e => e.ProductId, "IX_Comments_ProductId");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Product).WithMany(p => p.Comments).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<ContragentDescription>(entity =>
        {
            entity.HasIndex(e => e.ContragentId, "IX_ContragentDescriptions_ContragentId");

            entity.HasOne(d => d.Contragent).WithMany(p => p.ContragentDescriptions).HasForeignKey(d => d.ContragentId);
        });

        modelBuilder.Entity<CountManipulation>(entity =>
        {
            entity.HasIndex(e => e.CountId, "IX_CountManipulations_CountId");

            entity.HasIndex(e => e.ManipulationId, "IX_CountManipulations_ManipulationId");

            entity.HasOne(d => d.Count).WithMany(p => p.CountManipulations).HasForeignKey(d => d.CountId);

            entity.HasOne(d => d.Manipulation).WithMany(p => p.CountManipulations).HasForeignKey(d => d.ManipulationId);
        });

        modelBuilder.Entity<CountOperation>(entity =>
        {
            entity.HasIndex(e => e.FromCountId, "IX_CountOperations_FromCountId");

            entity.HasIndex(e => e.ToCountId, "IX_CountOperations_ToCountId");

            entity.HasOne(d => d.FromCount).WithMany(p => p.CountOperationFromCounts).HasForeignKey(d => d.FromCountId);

            entity.HasOne(d => d.ToCount).WithMany(p => p.CountOperationToCounts).HasForeignKey(d => d.ToCountId);
        });

        modelBuilder.Entity<DeliverAddress>(entity =>
        {
            entity.HasIndex(e => e.DeliverOptionId, "IX_DeliverAddresses_DeliverOptionId");

            entity.HasOne(d => d.DeliverOption).WithMany(p => p.DeliverAddresses).HasForeignKey(d => d.DeliverOptionId);
        });

        modelBuilder.Entity<Nakladni>(entity =>
        {
            entity.HasIndex(e => e.ContragentId, "IX_Nakladnis_ContragentId");

            entity.HasOne(d => d.Contragent).WithMany(p => p.Nakladnis).HasForeignKey(d => d.ContragentId);
        });

        modelBuilder.Entity<NakladniProduct>(entity =>
        {
            entity.HasIndex(e => e.NakladnaId, "IX_NakladniProducts_NakladnaId");

            entity.HasIndex(e => e.ProductId, "IX_NakladniProducts_ProductId");

            entity.HasIndex(e => e.ProductStorageId, "IX_NakladniProducts_ProductStorageId");

            entity.HasOne(d => d.Nakladna).WithMany(p => p.NakladniProducts).HasForeignKey(d => d.NakladnaId);

            entity.HasOne(d => d.Product).WithMany(p => p.NakladniProducts).HasForeignKey(d => d.ProductId);

            entity.HasOne(d => d.ProductStorage).WithMany(p => p.NakladniProducts).HasForeignKey(d => d.ProductStorageId);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasIndex(e => e.DeliverAddressId, "IX_Orders_DeliverAddressId");

            entity.HasIndex(e => e.NakladnaId, "IX_Orders_NakladnaId").IsUnique();

            entity.HasIndex(e => e.PaymentTypeId, "IX_Orders_PaymentTypeId");

            entity.HasOne(d => d.DeliverAddress).WithMany(p => p.Orders).HasForeignKey(d => d.DeliverAddressId);

            entity.HasOne(d => d.Nakladna).WithOne(p => p.Order).HasForeignKey<Order>(d => d.NakladnaId);

            entity.HasOne(d => d.PaymentType).WithMany(p => p.Orders).HasForeignKey(d => d.PaymentTypeId);
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasIndex(e => e.CountId, "IX_Payments_CountId");

            entity.HasIndex(e => e.NakladnaId, "IX_Payments_NakladnaId");

            entity.HasIndex(e => e.PaymentTypeId, "IX_Payments_PaymentTypeId");

            entity.HasOne(d => d.Count).WithMany(p => p.Payments).HasForeignKey(d => d.CountId);

            entity.HasOne(d => d.Nakladna).WithMany(p => p.Payments).HasForeignKey(d => d.NakladnaId);

            entity.HasOne(d => d.PaymentType).WithMany(p => p.Payments).HasForeignKey(d => d.PaymentTypeId);
        });

        modelBuilder.Entity<Photo>(entity =>
        {
            entity.HasIndex(e => e.ProductId, "IX_Photos_ProductId");

            entity.HasOne(d => d.Product).WithMany(p => p.Photos).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => e.BrandId, "IX_Products_BrandId");

            entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

            entity.HasOne(d => d.Brand).WithMany(p => p.Products).HasForeignKey(d => d.BrandId);

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasForeignKey(d => d.CategoryId);
        });

        modelBuilder.Entity<ProductCharacteristic>(entity =>
        {
            entity.HasIndex(e => e.CharacteristicId, "IX_ProductCharacteristics_CharacteristicId");

            entity.HasIndex(e => e.ProductId, "IX_ProductCharacteristics_ProductId");

            entity.HasOne(d => d.Characteristic).WithMany(p => p.ProductCharacteristics).HasForeignKey(d => d.CharacteristicId);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductCharacteristics).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<ProductInventarization>(entity =>
        {
            entity.HasKey(e => new { e.InventarizationId, e.ProductStorageId });

            entity.HasIndex(e => e.ProductStorageId, "IX_ProductInventarizations_ProductStorageId");

            entity.HasOne(d => d.Inventarization).WithMany(p => p.ProductInventarizations).HasForeignKey(d => d.InventarizationId);

            entity.HasOne(d => d.ProductStorage).WithMany(p => p.ProductInventarizations).HasForeignKey(d => d.ProductStorageId);
        });

        modelBuilder.Entity<ProductRestorage>(entity =>
        {
            entity.HasIndex(e => e.FromStorageId, "IX_ProductRestorages_FromStorageId");

            entity.HasIndex(e => e.ProductStorageId, "IX_ProductRestorages_ProductStorageId");

            entity.HasIndex(e => e.RestorageId, "IX_ProductRestorages_RestorageId");

            entity.HasIndex(e => e.ToStorageId, "IX_ProductRestorages_ToStorageId");

            entity.HasOne(d => d.FromStorage).WithMany(p => p.ProductRestorageFromStorages).HasForeignKey(d => d.FromStorageId);

            entity.HasOne(d => d.ProductStorage).WithMany(p => p.ProductRestorages).HasForeignKey(d => d.ProductStorageId);

            entity.HasOne(d => d.Restorage).WithMany(p => p.ProductRestorages).HasForeignKey(d => d.RestorageId);

            entity.HasOne(d => d.ToStorage).WithMany(p => p.ProductRestorageToStorages).HasForeignKey(d => d.ToStorageId);
        });

        modelBuilder.Entity<ProductStorage>(entity =>
        {
            entity.HasIndex(e => e.ProductId, "IX_ProductStorages_ProductId");

            entity.HasIndex(e => e.StorageId, "IX_ProductStorages_StorageId");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductStorages).HasForeignKey(d => d.ProductId);

            entity.HasOne(d => d.Storage).WithMany(p => p.ProductStorages).HasForeignKey(d => d.StorageId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

public partial class LOCATIONContext : DbContext
{
    public LOCATIONContext()
    {
    }

    public LOCATIONContext(DbContextOptions<LOCATIONContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorie> Categories { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Marque> Marques { get; set; }

    public virtual DbSet<Vehicule> Vehicules { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LOCATION_VEHICULE;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CATEGORI__3214EC27066946AF");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CLIENT__3214EC2735947840");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOCATION__3214EC2766138D33");

            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.Locations).HasConstraintName("FK__LOCATION__ID_CLI__30F848ED");

            entity.HasOne(d => d.IdVehiculeNavigation).WithMany(p => p.Locations).HasConstraintName("FK__LOCATION__ID_VEH__31EC6D26");
        });

        modelBuilder.Entity<Marque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MARQUE__3214EC274AAD008B");
        });

        modelBuilder.Entity<Vehicule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VEHICULE__3214EC271A78F13E");

            entity.HasOne(d => d.IdCategorieNavigation).WithMany(p => p.Vehicules).HasConstraintName("FK__VEHICULE__ID_CAT__2E1BDC42");

            entity.HasOne(d => d.IdMarqueNavigation).WithMany(p => p.Vehicules).HasConstraintName("FK__VEHICULE__ID_MAR__2D27B809");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
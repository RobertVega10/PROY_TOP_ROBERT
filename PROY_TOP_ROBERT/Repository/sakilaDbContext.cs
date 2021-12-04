using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PROY_TOP_ROBERT.Models;

#nullable disable

namespace PROY_TOP_ROBERT.Repository
{
    public partial class sakilaDbContext : DbContext
    {
        public sakilaDbContext()
        {
        }

        public sakilaDbContext(DbContextOptions<sakilaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<ActorInfo> ActorInfos { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        /*
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerList> CustomerLists { get; set; }
        */
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmActor> FilmActors { get; set; }
        public virtual DbSet<FilmCategory> FilmCategories { get; set; }
        public virtual DbSet<FilmList> FilmLists { get; set; }
        public virtual DbSet<FilmText> FilmTexts { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        
        public virtual DbSet<NicerButSlowerFilmList> NicerButSlowerFilmLists { get; set; }
        public virtual DbSet<SalesByFilmCategory> SalesByFilmCategories { get; set; }
        public virtual DbSet<SalesByStore> SalesByStores { get; set; }
        public virtual DbSet<Sheet1> Sheet1s { get; set; }
        public virtual DbSet<StaffList> StaffLists { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-B65VJOD6\\MYSQL2019;Initial Catalog=sakila;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>(entity =>
            {
                entity.Property(e => e.FilmId).ValueGeneratedNever();
            });

            modelBuilder.Entity<FilmActor>(entity =>
            {
                entity.HasKey(e => new { e.ActorId, e.FilmId });

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmActors)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_film_actor_film");
            });

            modelBuilder.Entity<FilmCategory>(entity =>
            {
                entity.HasKey(e => new { e.FilmId, e.CategoryId });

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmCategories)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_film_category_film");
            });

            modelBuilder.Entity<FilmList>(entity =>
            {
                entity.Property(e => e.FilmId).ValueGeneratedNever();

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmList)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_film_list_film");
            });

            modelBuilder.Entity<FilmText>(entity =>
            {
                entity.Property(e => e.FilmId).ValueGeneratedNever();

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmText)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_film_text_film");


            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => new { e.InventoryId, e.FilmId });

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_inventory_film");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

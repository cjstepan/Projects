using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MusicShop.com.Models;

namespace MusicShop.com.Data
{
    public class MusicShopcomContext : IdentityDbContext<IdentityUser>
    {
        public MusicShopcomContext (DbContextOptions<MusicShopcomContext> options)
            : base(options)
        {
        }

        public DbSet<MusicShop.com.Models.Music> Music { get; set; } = default!;
        public DbSet<MusicShop.com.Models.User> User { get; set; } = default!;
        public DbSet<MusicShop.com.Models.Price> Price { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Music>()
                .Property(m => m.Price)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Price>()
                .Property(m => m.digitalPrice)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Price>()
                .Property(m => m.cdPrice)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Price>()
                .Property(m => m.vinylPrice)
                .HasColumnType("decimal(18, 2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}

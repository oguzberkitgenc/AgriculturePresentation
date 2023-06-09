﻿using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Contexts
{
    public class AgricultureContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\OBG;database=DbAgricultur;integrated security=true");
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contects { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> socialMedias { get; set; }
        public DbSet<Abaout> Abaouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}

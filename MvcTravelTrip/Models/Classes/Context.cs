﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcTravelTrip.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<AddressBlog> AddressBlogs { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<HomePage> HomePages { get; set; }
    }
}
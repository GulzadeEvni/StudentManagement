﻿using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;


namespace StudentManagement.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
            

        public DbSet<Student> Students { get; set; }
    }
}

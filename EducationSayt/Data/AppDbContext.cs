﻿using EducationSayt.Models;
using Microsoft.EntityFrameworkCore;

namespace EducationSayt.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseImage> CourseImages { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Newser> Newsers { get; set; }
        public DbSet<New> News { get; set; }
    }
}

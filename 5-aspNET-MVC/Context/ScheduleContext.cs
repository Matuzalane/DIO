using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _5_aspNET_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace _5_aspNET_MVC.Context
{
    public class ScheduleContext : DbContext
    {
        public ScheduleContext(DbContextOptions<ScheduleContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
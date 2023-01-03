using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4_dotNET_API_com_Csharp.Entities;
using Microsoft.EntityFrameworkCore;

namespace _4_dotNET_API_com_Csharp.Context
{
    public class ScheduleContext : DbContext
    {
        public ScheduleContext(DbContextOptions<ScheduleContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts{ get; set; }
    }
}
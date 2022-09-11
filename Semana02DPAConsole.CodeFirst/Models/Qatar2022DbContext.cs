using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02DPAConsole.CodeFirst.Models
{
    public class Qatar2022DbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Windows authentications
            var myCnxString = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=Qatar2022Db;Integrated Security = true";
            // SQL auth
            //var myCnxString = "Server=MYSERVER;Database=MYDATABASE;User=MYUSER;Password=MYPASSWORD";

            options
                .UseSqlServer(myCnxString)
                .LogTo(Console.WriteLine, LogLevel.Information);

        }

        public virtual DbSet<Player> Player { get; set; } 
        public virtual DbSet<Team> Team { get; set; }
    }
}

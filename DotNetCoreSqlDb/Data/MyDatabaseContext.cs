using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreSqlDb.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext (DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetCoreSqlDb.Models.Todo> Todo { get; set; }
    }
}
// Data Source=evelyn-sql-server.database.windows.net,1433;Initial Catalog=evelyn-sql-database;User ID=evelyn-sql-server-admin;Password=6SF64FWRL000ZQ8M$

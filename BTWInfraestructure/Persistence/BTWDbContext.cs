using BTWDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWInfraestructure.Persistence
{
    public class BTWDbContext : DbContext
    {
        public BTWDbContext(DbContextOptions options) : base(options)
        {

        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
        public DbSet<Customer> Customers { get; set; }
    }
}

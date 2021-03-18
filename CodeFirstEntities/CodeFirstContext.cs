using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoenixCust.CodeFirstEntities
{
    public class CodeFirstContext: DbContext
    {

        public CodeFirstContext(DbContextOptions<CodeFirstContext> options)
           : base(options)
        {
        }

        public DbSet <CodeFirstCustomer> CodeFirstCustomers { get; set; }
    }




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoenixCust.CodeFirstEntities
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }

        public virtual CodeFirstCustomer Customer { get; set; }

    }
}

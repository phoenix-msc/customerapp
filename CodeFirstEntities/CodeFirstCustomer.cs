using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoenixCust.CodeFirstEntities
{
    public class CodeFirstCustomer
    {
        public int Id { get; set; }
        public string Custname { get; set; }
        public string Busname { get; set; }
        public string Custemailaddress { get; set; }
        public string Custcellphone { get; set; }
        public string Password { get; set; }
    }
}

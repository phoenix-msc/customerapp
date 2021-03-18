using System;
using System.Collections.Generic;

#nullable disable

namespace PhoenixCust.Entities
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Custname { get; set; }
        public string Busname { get; set; }
        public string Custemailaddress { get; set; }
        public string Custcellphone { get; set; }
        public string Password { get; set; }
    }
}

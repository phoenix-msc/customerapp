using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoenixCust.Models
{
    public class LoginViewModel
    {
        public  string Email { get; set; }
        public string Password { get; set; }
        public string ErrorMessage { get; set; }

    }
}

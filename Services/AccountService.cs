using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using PhoenixCust.CodeFirstEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PhoenixCust.Services
{
    public class AccountService
    {
        private readonly CodeFirstContext _context;
        public AccountService(CodeFirstContext context)
        {
            _context = context;
        }
        
    }
}

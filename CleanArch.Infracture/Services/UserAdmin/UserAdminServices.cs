using CleanArch.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infracture.Services.UserAdmin
{
    public class UserAdminServices : IUserAdminServices
    {
        private readonly PostgresContext _context;
        public UserAdminServices(PostgresContext context)
        {
            _context = context;
        }
    }
}

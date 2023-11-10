using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadinSoft.Domain.Users
{
    public class User
    {
        public UserId Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

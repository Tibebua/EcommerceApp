using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace EcommerceApp.Core.Entities.Identity
{
    public class AppUser: IdentityUser
    {
        public string DisplayName { get; set; }
        public Address Address { get; set; }
    }
}

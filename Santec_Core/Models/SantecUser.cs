using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Santec_Core.Models
{
    public class SantecUser : IdentityUser
    {
        public String SantecCode { get; set; }
        public int SantecNumber { get; set; }
    }
}

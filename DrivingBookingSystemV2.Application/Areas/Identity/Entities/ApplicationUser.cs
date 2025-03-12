using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DrivingBookingSystemV2.Application.Areas.Identity.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required]
        public bool RequirePasswordReset { get; set; }

        public DateTime LastPasswordReset { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

    }
}

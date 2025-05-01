using Microsoft.AspNetCore.Identity;

namespace DrivingBookingSystemV2.Application.Areas.Identity.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public int EthnicityID { get; set; }

        public int GenderID { get; set; }

        public DateTime DateCreated { get; set; }

        public bool Inactive { get; set; }

    }
}

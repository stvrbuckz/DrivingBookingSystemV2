using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DrivingBookingSystemV2.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
    }
}

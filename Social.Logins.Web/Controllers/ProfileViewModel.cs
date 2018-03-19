namespace Social.Logins.Web.Controllers
{
    using System.Collections.Generic;
    using System.Security.Claims;

    public class ProfileViewModel
    {
        public string Name { get; set; }
        public IEnumerable<Claim> Claims { get; set; }
    }
}

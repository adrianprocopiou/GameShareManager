using System.Linq;
using System.Security.Claims;
using System.Security.Principal;

namespace GameShareManager.Helpers
{
    public static class ApplicationUserExtensions
    {
        public static string FullName(this IPrincipal user)
        {        
            var claimsIdentity = user.Identity as ClaimsIdentity;
            if (claimsIdentity?.Claims == null) return "";
            return claimsIdentity.Claims.FirstOrDefault(x=>x.Type == "FullName")?.Value;
        }
    }
}

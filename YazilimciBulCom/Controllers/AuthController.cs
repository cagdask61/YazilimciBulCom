using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace YazilimciBulCom.Controllers
{
    public class AuthController : Controller
    {
        public async Task Login()
        {
            var authenticationProperties = new LoginAuthenticationPropertiesBuilder().WithRedirectUri("Accounts").Build();

            await HttpContext.ChallengeAsync(Auth0Constants.AuthenticationScheme, authenticationProperties);

        }
    }
}

using BusinessLogic.Interfaces;
using BusinessLogic.Utilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using ISystemClock = Microsoft.AspNetCore.Authentication.ISystemClock;

namespace BusinessLogic.Authentication
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IUserService _userService;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IUserService userService) 
            : base(options, logger, encoder, clock)
        {
            _userService = userService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey(AuthenticationConstants.Authorization))
            {
                return AuthenticateResult.Fail("Missing Authorization header");
            }

            var authorizationHeader = Request.Headers[AuthenticationConstants.Authorization].ToString();
            if (!authorizationHeader.StartsWith(AuthenticationConstants.Basic, StringComparison.OrdinalIgnoreCase))
            {
                return AuthenticateResult.Fail("Authorization header does not start with 'Basic'");
            }

            var authBase64Decoded = Encoding.UTF8.GetString(Convert.FromBase64String(authorizationHeader.Replace(AuthenticationConstants.Basic, string.Empty, StringComparison.OrdinalIgnoreCase)));
            var authSplit = authBase64Decoded.Split(new[] { ApplicationConstants.Colon }, 2);

            if (authSplit.Length != 2)
            {
                return AuthenticateResult.Fail("Invalid Authorization header format");
            }

            var clientId = authSplit[0];
            var clientSecret = authSplit[1];

            var user = await _userService.ValidateCredentialsAsync(clientId, clientSecret);
            if (user == null)
            {
                return AuthenticateResult.Fail("Invalid username or password");
            }

            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, user.Username),
            }, Scheme.Name));

            return AuthenticateResult.Success(new AuthenticationTicket(claimsPrincipal, Scheme.Name));
        }
    }
}

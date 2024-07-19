using Application.Models.Authentication;
using Message_Exchange_App.Application.Contracts.Identity;
using Message_Exchange_App.Application.Models.Authentication;
using Message_Exchange_App.Identity.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Message_Exchange_App.Identity.Services
{
    public class AuthenticationService: IAuthenticationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly JwtSettings _jwtSettings;

        public AuthenticationService(UserManager<ApplicationUser> userManager,
            IOptions<JwtSettings> jwtSettings,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;
            _signInManager = signInManager;
        }

        public async Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request)
        {
            // User Authentication
            AuthenticationResponse response = new AuthenticationResponse
            {
                // Implementation goes here with user information
            };
            
            return response;
        }

        public async Task<RegistrationResponse> RegisterAsync(RegistrationRequest request)
        {
            // User Registration code goes here
            RegistrationResponse response = new RegistrationResponse
            {
                // Implementation goes here with user information
            };

            return response;

        }

    }
}

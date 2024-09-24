using GoogleAuthticationExample.Repositories.Interfance;
using Microsoft.AspNetCore.Identity;

namespace GoogleAuthticationExample.Repositories.Implementaion
{
    public class LoginGoogleService : ILoginGoogleService
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

        public LoginGoogleService(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        public Task<bool> LoginExtnal(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterExtnal(string email)
        {
            throw new NotImplementedException();
        }
    }
}

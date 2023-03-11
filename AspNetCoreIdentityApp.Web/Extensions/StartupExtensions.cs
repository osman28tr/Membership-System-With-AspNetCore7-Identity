using AspNetCoreIdentityApp.Web.CustomValidations;
using AspNetCoreIdentityApp.Web.Localization;
using AspNetCoreIdentityApp.Web.Models;

namespace AspNetCoreIdentityApp.Web.Extensions
{
    public static class StartupExtensions
    {
        public static void AddIdentityWithExt(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;

            }).AddPasswordValidator<PasswordValidator>().AddUserValidator<UserValidator>().AddErrorDescriber<LocalizationIdentityErrorDescriber>().AddEntityFrameworkStores<AppDbContext>();
        }
    }
}

﻿using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentityApp.Web.Localization
{
    public class LocalizationIdentityErrorDescriber:IdentityErrorDescriber
    {
        public override IdentityError DuplicateUserName(string userName)
        {
            return new() { Code = "DuplicateUserName", Description = $"Bu {userName} daha önce başka bir kullanıcı tarafından alınmıştır." };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new() { Code = "DuplicateEmail", Description = $"Bu {email} adresi daha önce başka bir kullanıcı tarafından alınmıştır." };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new() { Code = "Şifre en az 6 karakterde olmalıdır." };
        }
    }
}

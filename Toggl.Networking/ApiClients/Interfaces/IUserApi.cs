﻿using System.Threading.Tasks;
using Toggl.Shared;
using Toggl.Shared.Models;

namespace Toggl.Networking.ApiClients
{
    public interface IUserApi
        : IUpdatingApiClient<IUser>,
          IPullingSingleApiClient<IUser>
    {
        Task<IUser> GetWithGoogle();
        Task<IUser> GetWithApple(string clientId);
        Task<string> ResetPassword(Email email);
        Task<IUser> SignUp(Email email, Password password, bool termsAccepted, int countryId, string timezone);
        Task<IUser> SignUpWithGoogle(string googleToken, bool termsAccepted, int countryId, string timezone);
        Task<IUser> SignUpWithApple(string clientId, string appleToken, string fullname, bool termsAccepted, int countryId, string timezone);
    }
}

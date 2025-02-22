﻿using Microsoft.AspNetCore.Components.Server;

namespace DingleValleyRebooted.Server.Services
{
    public class RemoteAuthenticationService : ServerAuthenticationStateProvider, IRemoteAuthenticationService<RemoteAuthenticationState>
    {

        public Task<RemoteAuthenticationResult<RemoteAuthenticationState>> CompleteSignInAsync(RemoteAuthenticationContext<RemoteAuthenticationState> context)
        {
            return Success(context);
        }

        public Task<RemoteAuthenticationResult<RemoteAuthenticationState>> CompleteSignOutAsync(RemoteAuthenticationContext<RemoteAuthenticationState> context)
        {
            return Success(context);
        }

        public Task<RemoteAuthenticationResult<RemoteAuthenticationState>> SignInAsync(RemoteAuthenticationContext<RemoteAuthenticationState> context)
        {
            return Success(context);
        }

        public Task<RemoteAuthenticationResult<RemoteAuthenticationState>> SignOutAsync(RemoteAuthenticationContext<RemoteAuthenticationState> context)
        {
            return Success(context);
        }

        private static Task<RemoteAuthenticationResult<RemoteAuthenticationState>> Success(RemoteAuthenticationContext<RemoteAuthenticationState> context)
        {
            return Task.FromResult(new RemoteAuthenticationResult<RemoteAuthenticationState>
            {
                State = context.State,
                Status = RemoteAuthenticationStatus.Success
            });
        }
    }
}

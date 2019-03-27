﻿namespace Skoruba.IdentityServer4.Admin.Configuration.Interfaces
{
    public interface IRootConfiguration
    {
        IAdminConfiguration AdminConfiguration { get; }
        IUserDataConfiguration UserDataConfiguration { get; }
        IClientDataConfiguration ClientDataConfiguration { get; }
    }
}
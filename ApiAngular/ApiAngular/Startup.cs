using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.IdentityModel.Tokens;
using System.Configuration;
using Microsoft.Owin.Security.Jwt;
using Microsoft.IdentityModel.Tokens;

[assembly: OwinStartup(typeof(ApiAngular.Startup))]

namespace ApiAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

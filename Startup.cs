﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BTVN_B5_2.Startup))]
namespace BTVN_B5_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

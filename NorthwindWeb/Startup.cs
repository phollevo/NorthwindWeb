﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindWeb.Startup))]
namespace NorthwindWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //Ceci est un commentaire écrit par Félicien
            ConfigureAuth(app);
        }
    }
}

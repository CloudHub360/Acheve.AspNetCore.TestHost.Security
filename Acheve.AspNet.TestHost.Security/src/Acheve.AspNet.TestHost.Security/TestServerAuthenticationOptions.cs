﻿using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNet.Authentication;
using Microsoft.Extensions.OptionsModel;

namespace Acheve.AspNet.TestHost.Security
{
    public class TestServerAuthenticationOptions : AuthenticationOptions, IOptions<TestServerAuthenticationOptions>
    {
        public TestServerAuthenticationOptions()
        {
            AuthenticationScheme = TestServerAuthenticationDefaults.AuthenticationScheme;
            AutomaticAuthenticate = true;
            AutomaticChallenge = true;

            CommonClaims = new Claim[0];
        }

        public IEnumerable<Claim> CommonClaims { get; set; }

        public TestServerAuthenticationOptions Value => this;
    }
}
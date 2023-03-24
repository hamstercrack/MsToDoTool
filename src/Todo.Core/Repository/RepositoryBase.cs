﻿using Microsoft.Graph;
using Microsoft.Kiota.Abstractions.Authentication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Core.Repository
{
    public abstract class RepositoryBase
    {
        protected IAuthenticationProvider AuthenticationProvider { get; }

        public RepositoryBase(IAuthenticationProvider authenticationProvider)
        {
            AuthenticationProvider = authenticationProvider;
        }
    }
}

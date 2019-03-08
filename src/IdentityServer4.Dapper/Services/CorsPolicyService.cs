using IdentityServer4.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer4.Dapper {
    /// <summary>
    /// Implementation of ICorsPolicyService that consults the client configuration in the database for allowed CORS origins.
    /// </summary>
    /// <seealso cref="IdentityServer4.Services.ICorsPolicyService" />
   public class CorsPolicyService : ICorsPolicyService {
        public Task<bool> IsOriginAllowedAsync(string origin) {
            throw new NotImplementedException();
        }
    }
}

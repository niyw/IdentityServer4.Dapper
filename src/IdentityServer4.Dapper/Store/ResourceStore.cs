using IdentityServer4.Models;
using IdentityServer4.Stores;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer4.Dapper {
    /// <summary>
    /// Implementation of IResourceStore thats uses Dapper.
    /// </summary>
    /// <seealso cref="IdentityServer4.Stores.IResourceStore" />
    public class ResourceStore : IResourceStore {
        private readonly IIdentityServerDb _context;
        private readonly ILogger _logger;
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceStore"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="logger">The logger.</param>
        public ResourceStore(IIdentityServerDb context, ILogger<PersistedGrantStore> logger) {
            _context = context;
            _logger = logger;
        }
        public Task<ApiResource> FindApiResourceAsync(string name) {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApiResource>> FindApiResourcesByScopeAsync(IEnumerable<string> scopeNames) {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IdentityResource>> FindIdentityResourcesByScopeAsync(IEnumerable<string> scopeNames) {
            throw new NotImplementedException();
        }

        public Task<Resources> GetAllResourcesAsync() {
            throw new NotImplementedException();
        }
    }
}

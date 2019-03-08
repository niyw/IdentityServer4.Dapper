using IdentityServer4.Models;
using IdentityServer4.Stores;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace IdentityServer4.Dapper {
    /// <summary>
    /// Implementation of IClientStore thats uses Dapper.
    /// </summary>
    /// <seealso cref="IdentityServer4.Stores.IClientStore" />
    public class ClientStore : IClientStore {
        private readonly IIdentityServerDb _context;
        private readonly ILogger _logger;
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientStore"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="logger">The logger.</param>
        public ClientStore(IIdentityServerDb context, ILogger<PersistedGrantStore> logger) {
            _context = context;
            _logger = logger;
        }
        public Task<Client> FindClientByIdAsync(string clientId) {
            throw new NotImplementedException();
        }
    }
}

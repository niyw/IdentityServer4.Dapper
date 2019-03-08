using IdentityServer4.Models;
using IdentityServer4.Stores;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer4.Dapper {
    /// <summary>
    /// Implementation of IPersistedGrantStore thats uses Dapper.
    /// </summary>
    /// <seealso cref="IdentityServer4.Stores.IPersistedGrantStore" />
    public class PersistedGrantStore : IPersistedGrantStore {
        private readonly IIdentityServerDb _context;
        private readonly ILogger _logger;
        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedGrantStore"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="logger">The logger.</param>
        public PersistedGrantStore(IIdentityServerDb context, ILogger<PersistedGrantStore> logger) {
            _context = context;
            _logger = logger;
        }
        public Task<IEnumerable<PersistedGrant>> GetAllAsync(string subjectId) {
            throw new NotImplementedException();
        }

        public Task<PersistedGrant> GetAsync(string key) {
            throw new NotImplementedException();
        }

        public Task RemoveAllAsync(string subjectId, string clientId) {
            throw new NotImplementedException();
        }

        public Task RemoveAllAsync(string subjectId, string clientId, string type) {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(string key) {
            throw new NotImplementedException();
        }

        public Task StoreAsync(PersistedGrant grant) {
            throw new NotImplementedException();
        }
    }
}

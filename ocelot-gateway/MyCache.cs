using Ocelot.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ocelot_gateway
{
    public class MyCache : IOcelotCache<CachedResponse>
    {
        public void Add(string key, CachedResponse value, TimeSpan ttl, string region)
        {
            throw new NotImplementedException();
        }

        public void AddAndDelete(string key, CachedResponse value, TimeSpan ttl, string region)
        {
            throw new NotImplementedException();
        }

        public void ClearRegion(string region)
        {
            throw new NotImplementedException();
        }

        public CachedResponse Get(string key, string region)
        {
            throw new NotImplementedException();
        }
    }
}

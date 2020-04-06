using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ocelot_gateway
{
    public class FakeHandler : DelegatingHandler
    {
        public static DateTime TimeCalled { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            TimeCalled = DateTime.Now;
            return base.SendAsync(request, cancellationToken);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace delivery_api
{
    public class ConsulEntity
    {
        public string Ip { get; set; }

        public int Port { get; set; }

        public string ServiceName { get; set; }

        public string ConsulIp { get; set; }

        public int ConsulPort { get; set; }
    }
}

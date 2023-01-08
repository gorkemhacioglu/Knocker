using System;
using System.Collections.Generic;
using System.Text;

namespace KnockerCore.DTO
{
    public class ThreadStatusDto
    {
        public int Id { get; set; }

        public string IpAddress { get; set; }

        public string Port { get; set; }
        
        public string MacAddress { get; set; }
    }
}

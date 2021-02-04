using System;
using System.Collections.Generic;
using System.Text;

namespace KnockerCore.DTO
{
    public class ComponentStatusDto
    {
        public bool isFromHostValid { get; set; }
        public bool isToHostValid { get; set; }
        public bool isFromPortValid { get; set; }
        public bool isToPortValid { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace KnockerCore.DTO
{
    public class MainStatusDto
    {
        public bool IsRunning { get; set; } = false;

        public ComponentStatusDto ComponentStatus { get; set; } = new ComponentStatusDto();
    }
}

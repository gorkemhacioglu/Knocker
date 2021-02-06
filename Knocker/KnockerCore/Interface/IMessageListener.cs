using System;
using System.Collections.Generic;
using System.Text;

namespace KnockerCore.DTO.Interface
{
    public interface IMessageListener
    {
        void OnListen(string action, object data);
    }
}

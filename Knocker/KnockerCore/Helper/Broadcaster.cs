using KnockerCore.DTO.Interface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KnockerCore.Helper
{
    public class Broadcaster
    {
        private readonly Collection<IMessageListener> _listeners = new Collection<IMessageListener>();

        public void Broadcast(string type, object data)
        {
            foreach (IMessageListener listener in _listeners)
            {
                listener.OnListen(type,data);
            }
        }

        public void AddListener(IMessageListener listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveListener(IMessageListener listener)
        {
            for (int index = 0; index < _listeners.Count; index++)
            {
                if (_listeners[index].Equals(listener))
                {
                    _listeners.Remove(_listeners[index]);
                }
            }
        }
    }

    public static class Factory
    {
        private static Broadcaster _broadcaster;

        public static Broadcaster Broadcaster()
        {
            return _broadcaster ?? (_broadcaster = new Broadcaster());
        }
    }
}

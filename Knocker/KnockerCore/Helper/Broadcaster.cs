using KnockerCore.DTO.Interface;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace KnockerCore.Helper
{
    public class Broadcaster
    {
        private readonly ConcurrentQueue<IMessageListener> _listeners = new ConcurrentQueue<IMessageListener>();

        public void Broadcast(string type, object data)
        {
            foreach (IMessageListener listener in _listeners)
            {
                listener.OnListen(type,data);
            }
        }

        public void AddListener(IMessageListener listener)
        {
            _listeners.Enqueue(listener);
        }

        public void RemoveListener(IMessageListener listener)
        {
            IMessageListener item;
            var a = _listeners.TryDequeue(out item);

            if (!a)
                return;
            else
            {
                if (item != listener)
                {
                    _listeners.Enqueue(item);
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

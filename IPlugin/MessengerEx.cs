using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TTSM2.PluginInterface
{
    public class MessengerEx
    {
        #region members
        static Messenger messenger = new Messenger();
        #endregion

        #region methods
        public static void Register(string message, Action callback)
        {
            messenger.Register(message, callback);
        }
        public static void Register<T>(string message, Action<T> callback)
        {
            messenger.Register(message, callback);
        }

        public static void Notify(string message)
        {
            messenger.NotifyColleagues(message);
        }

        public static void Notify(string message, object parameter)
        {
            messenger.NotifyColleagues(message, parameter);
        }
        #endregion
    }
}

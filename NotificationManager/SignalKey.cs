using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationManager
{
    public class SignalKey
    {
        public string Key { get; private set; }
        private string AddCode(string key)
        {
            return this.Key;
        }
        public SignalKey(string key) { Key = AddCode(key); }
    }
}

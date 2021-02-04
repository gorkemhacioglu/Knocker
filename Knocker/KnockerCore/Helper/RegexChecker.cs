using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace KnockerCore.Helper
{
    public class RegexChecker
    {
        public bool CheckIpAddress(string address)
        {
            Regex r = new Regex(@"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");

            return r.IsMatch(address);
        }

        public bool CheckPortValue(string port) {

            Regex r = new Regex(@"^()([1-9]|[1-5]?[0-9]{2,4}|6[1-4][0-9]{3}|65[1-4][0-9]{2}|655[1-2][0-9]|6553[1-5])$");

            return r.IsMatch(port);
        }
    }
}

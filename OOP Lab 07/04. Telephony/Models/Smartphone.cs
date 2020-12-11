using System;
using System.Linq;

namespace Telephony.Models
{
    public class Smartphone : ICaller, IBrowser
    {
        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(char.IsDigit))
                throw new ArgumentException("Invalid number!");
            return $"Calling... {phoneNumber}";
        }

        public string Browse(string url)
        {
            if (url.Any(char.IsDigit))
                throw new ArgumentException("Invalid URL!");
            return $"Browsing... {url}";
        }
    }
}

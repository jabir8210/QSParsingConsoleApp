using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSParsingConsoleApp
{
    public class QSParser
    {
        public int Count(string queryString)
        {
            if (string.IsNullOrEmpty(queryString))
            {
                return 0;
            }

            // Trim any leading or trailing spaces and split by '&'
            var pairs = queryString.Trim().Split('&');

            // Return the number of name/value pairs
            return pairs.Length;
        }

        public string ValueOf(string queryString, string key)
        {
            if (string.IsNullOrEmpty(queryString) || string.IsNullOrEmpty(key))
            {
                return null; // Return null if queryString or key is null or empty
            }

            // Split the query string into key-value pairs
            var pairs = queryString.Split('&');

            foreach (var pair in pairs)
            {
                var keyValue = pair.Split('=');

                if (keyValue.Length == 2 && keyValue[0] == key)
                {
                    return keyValue[1]; // Return the value associated with the key
                }
            }

            return null; // Return null if the key was not found
        }
    }
}

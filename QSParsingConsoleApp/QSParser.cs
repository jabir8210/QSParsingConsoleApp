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
    }
}

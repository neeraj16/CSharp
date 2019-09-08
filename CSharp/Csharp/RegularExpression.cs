using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp
{
    class RegularExpression
    {
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^(\d+)$";
            Match match = Regex.Match(phoneNumber, pattern);
            
            return match.Success;
        }
    }
}

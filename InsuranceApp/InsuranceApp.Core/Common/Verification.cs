using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InsuranceApp.Core.Common
{
    class Verification
    {
        internal delegate  System.Exception Ext(string exception);
        internal static void String(string value, string stringValue)
        {
            if (string.IsNullOrEmpty(value))
            {
                // TODO: Warn the user that value cannot be left empty
                throw new ArgumentNullException($"{stringValue} value cannot be left empty!");
                }
           if (string.IsNullOrWhiteSpace(value))
            {
                    // TODO: Warn the user that value cannot be Whitespace
                throw new ArgumentException($"{stringValue} cannot be set with White Space!");;
           }
        }

        internal static void StringExcactLength(string value, string stringValue,int lenght)
        {
            String(value, stringValue);

            if (value.Length!= lenght)
            {
                throw new ArgumentException($"{stringValue} must be exact {lenght} symbols");
            }
        }


        internal static void Phone(string value,string phoneStr)
        {
            Match match = Regex.Match(value, @"^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                throw new ArgumentException(phoneStr);
            }
        }

        internal static void CarRegistration(string value)
        {
            Match match = Regex.Match(value, @"[a-zA-Z]{2}\s\d{4}\s[a-zA-Z]{2}", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
            throw new NotImplementedException();
            }
        }

        internal static void PersonalID(string value)
        {
            Match match = Regex.Match(value, @"^\d{10}", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
            throw new NotImplementedException();
            }
        }
    }
}

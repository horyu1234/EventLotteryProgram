using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EventLotteryProgram
{
    public class PrivacyUtils
    {
        public static string HideName(string text)
        {
            const string pattern = @"[가-힣]{2,4}";
            var patternRegex = new Regex(pattern, RegexOptions.IgnoreCase);
            var regexResult = patternRegex.Matches(text);

            if (regexResult.Count == 0)
            {
                return text;
            }

            var result = text;
            foreach (Match regexMatch in regexResult)
            {
                var name = regexMatch.Value;
                var firstName = name[0];
                var lastName = name[name.Length - 1];

                string hidedName;
                if (name.Length == 2)
                {
                    hidedName = firstName + "*";
                }
                else
                {
                    hidedName = firstName + new string('*', name.Length - 2) + lastName;
                }

                result = result.Replace(name, hidedName);
            }

            return result;
        }

        public static string HideEmail(string text)
        {
            const string pattern =
                @"(?:[a-z0-9!#$%&'*+\/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+\/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])";
            var patternRegex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            var regexResult = patternRegex.Matches(text);

            if (regexResult.Count == 0)
            {
                return text;
            }

            var result = text;
            foreach (Match regexMatch in regexResult)
            {
                var email = regexMatch.Value;
                var emailFront = email.Split('@')[0];
                var emailDomain = email.Split('@')[1];

                string hidedEmail;
                if (emailFront.Length < 6)
                {
                    hidedEmail = new string('*', emailFront.Length) + "@" + emailDomain;
                }
                else
                {
                    hidedEmail = emailFront.Substring(0, 4) + new string('*', emailFront.Length - 4) + "@" +
                                 emailDomain;
                }

                result = result.Replace(email, hidedEmail);
            }

            return result;
        }

        public static string HidePhone(string text)
        {
            const string normalPhonePattern = @"(0(2|3[1-3]|4[1-4]|5[1-5]|6[1-4]))-?(\d{3,4})-?(\d{4})";
            const string cellPhonePattern = @"(01[0|1|6|7|8|9])-?(\d{3,4})-?(\d{4})";

            var normalPhoneRegex = new Regex(normalPhonePattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            var cellPhoneRegex = new Regex(cellPhonePattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);

            var normalPhoneRegexResult = normalPhoneRegex.Matches(text);
            var cellPhoneRegexResult = cellPhoneRegex.Matches(text);

            var result = text;

            if (normalPhoneRegexResult.Count != 0)
            {
                foreach (Match regexMatch in normalPhoneRegexResult)
                {
                    var phone = regexMatch.Value;
                    var locationCode = regexMatch.Result("$1");
                    var first = regexMatch.Result("$3");
                    var last = regexMatch.Result("$4");

                    var hidedPhone = locationCode + "-" + first + "-" + new string('*', last.Length);
                    result = result.Replace(phone, hidedPhone);
                }
            }

            if (cellPhoneRegexResult.Count != 0)
            {
                foreach (Match regexMatch in cellPhoneRegexResult)
                {
                    var phone = regexMatch.Value;
                    var locationCode = regexMatch.Result("$1");
                    var first = regexMatch.Result("$2");
                    var last = regexMatch.Result("$3");

                    var hidedPhone = locationCode + "-" + first + "-" + new string('*', last.Length);
                    result = result.Replace(phone, hidedPhone);
                }
            }

            return result;
        }
    }
}
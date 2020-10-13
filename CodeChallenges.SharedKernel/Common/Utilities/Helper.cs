using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeChallenges.SharedKernel.Common.Utilities
{
    public class Helper
    {
        public static int ConvertStringValueToInt(string input)
        {
            var sanitized = Regex.Replace(input, "[^0-9]+", string.Empty);
           

            return  int.Parse( sanitized);
        }

        public static List<int> ConvertStringValueToListInt(string input)
        {

            var selectedEditionIds = input.ToArray()
                .Where(i => !char.IsWhiteSpace(i)
                            && char.IsDigit(i))
                .Select(x => (int)Char.GetNumericValue(x)
                //Convert.ToInt16(x)
                ).ToList();

            return selectedEditionIds;
        }

        public static List<int> ConvertStringValuesToInt(List<string> input)
        {

            var selectedEditionIds = input.ToArray()
                .Where(i => !string.IsNullOrWhiteSpace(i)
                            && int.TryParse(i, out int validNumber))
                .Select(x => int.Parse(x)).ToList();

            return selectedEditionIds;
        }

        public static List<string> ConvertStringValuesToString(List<string> input)
        {
            var selectedEditionStrings = input.ToArray().Where(i => !int.TryParse(i, out int validNumber))
                .Select(i => i.ToString()).ToList();

            return selectedEditionStrings;
        }
    }
}

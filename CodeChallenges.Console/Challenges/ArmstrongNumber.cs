using CodeChallenges.SharedKernel.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.ConsoleUI.Challenges
{
    /// <summary>
    /// Armstrong number is a number that is equal to the sum of cubes of its digits. For example 0, 1, 153, 370, 371 and 407 are the Armstrong numbers. Let's try to understand why 153 is an Armstrong number. Let's try to understand why 371 is an Armstrong number.
    /// </summary>
    public class ArmstrongNumber
    {
        public bool Calculate (string input)
        {
            var sanitzed = Helper.ConvertStringValueToInt(input);

            var splitInteger = Helper.ConvertStringValueToListInt(input);
            var total = 0;
            foreach (var item in splitInteger)
            {
                total = Convert.ToInt32( Math.Pow(item, 3)) + total;
            }

            
            return sanitzed == total;

        }

       
    }
}

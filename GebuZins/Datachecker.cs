using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebuZins
{
    public class Datachecker
    {
        public decimal[] checkData(string birthdayDate, string wealthAmount, string interestRate)
        {
            decimal[] checkedData = new decimal[3];

            checkedData[0] = Convert.ToDecimal(birthdayDate.Substring(0, 2));
            checkedData[1] = Convert.ToDecimal(wealthAmount);
            checkedData[2] = Convert.ToDecimal(interestRate);
            

            return checkedData;
        }
    }
}

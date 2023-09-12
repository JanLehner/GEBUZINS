using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebuZins
{
    public class Dataprocessor
    {
        public decimal[] processData(decimal[] data)
        {
            decimal[] results = new decimal[2];
            
            decimal wealthAmount = data[0];
            decimal interestRate = data[1];
            decimal birthdayDate = data[2];

            decimal amountPerDay = ((wealthAmount / 100) * interestRate) / 365;
            decimal amountToGet = amountPerDay * birthdayDate;
            decimal inputTax = (amountToGet / 100) * 35;

            results[0] = decimal.Round(amountToGet, 2);
            results[1] = decimal.Round(inputTax, 2); ;
            return results;
        }
    }
}

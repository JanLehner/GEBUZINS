namespace GebuZins
{
    public class Dataprocessor
    {
        public decimal[] ProcessData(decimal birthdayDate, decimal wealthAmount, decimal interestRate)
        {
            decimal[] results = new decimal[2];

            decimal amountPerDay = ((wealthAmount / 100) * interestRate) / 365;
            decimal amountToGet = amountPerDay * birthdayDate;
            decimal inputTax = (amountToGet / 100) * 35;

            results[0] = decimal.Round(amountToGet, 2);
            results[1] = decimal.Round(inputTax, 2);
            return results;
        }
    }
}

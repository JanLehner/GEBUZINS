using System.Text.RegularExpressions;

namespace GebuZins
{
    public class Datachecker
    {
        public void CheckData(object sender)
        {
            var textBox = (TextBox)sender;
            string input = textBox.Text;
            string cleanedInput = new(input.Where(c => char.IsDigit(c) || c == '.').ToArray());
            bool decimalEntered = cleanedInput.Contains('.');

            cleanedInput = cleanedInput.Replace(".", "");

            if (!decimalEntered) return;
            cleanedInput = cleanedInput.TrimStart('0');
            cleanedInput = cleanedInput.Length switch
            {
                >= 3 => cleanedInput.Insert(cleanedInput.Length - 2, "."),
                2 => cleanedInput.Insert(0, "0."),
                1 => cleanedInput.Insert(0, "0.0"),
                _ => cleanedInput.Insert(0, "0.00")
            };

            textBox.Text = cleanedInput;
            textBox.SelectionStart = textBox.Text.Length;
        }
    }
}

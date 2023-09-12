namespace GebuZins
{
    public class Datachecker
    {
        public void CheckData(object sender)
        {
            var textBox = (TextBox)sender;
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]")) return;
            textBox.Text = System.Text.RegularExpressions.Regex.Replace(textBox.Text, "[^0-9]", "");
            textBox.SelectionStart = textBox.Text.Length;
        }
    }
}

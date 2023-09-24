namespace GebuZins
{
    public partial class Form2 : Form
    {
        private readonly Dataprocessor _dataprocessor;
        private readonly Datachecker _checker;

        public Form2(Dataprocessor dataprocessor, Datachecker checker)
        {
            InitializeComponent();
            _dataprocessor = dataprocessor;
            _checker = checker;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            labelError.Text = string.Empty;
            textBoxWealth.BackColor = Color.White;
            textBoxInterestRate.BackColor = Color.White;

            if (textBoxWealth.Text == string.Empty || textBoxInterestRate.Text == string.Empty)
            {
                labelError.Text = "Bitte füllen Sie alle Felder aus.";
                labelAmountToGet.Text = "- CHF";
                labelAmountTax.Text = "- CHF";
                if (textBoxWealth.Text == string.Empty) textBoxWealth.BackColor = Color.LightCoral;
                if (textBoxInterestRate.Text == string.Empty) textBoxInterestRate.BackColor = Color.LightCoral;
                return;
            }

            decimal birthdayDate = Convert.ToDecimal(pickerBirthday.Value.Day);
            decimal wealthAmount = Convert.ToDecimal(textBoxWealth.Text);
            decimal interestRate = Convert.ToDecimal(textBoxInterestRate.Text);
            decimal[] results = _dataprocessor.ProcessData(birthdayDate, wealthAmount, interestRate);
            labelAmountToGet.Text = results[0] + " CHF";
            labelAmountTax.Text = results[1] + " CHF";
        }

        private void CheckInputData(object sender, EventArgs e)
        {
            _checker.CheckData(sender);
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            textBoxInterestRate.Text = string.Empty;
            pickerBirthday.Value = new DateTime(DateTime.Now.Year, 1, 1);
            textBoxWealth.Text = string.Empty;
            labelAmountToGet.Text = "- CHF";
            labelAmountTax.Text = "- CHF";
            labelError.Text = string.Empty;
            textBoxWealth.BackColor = Color.White;
            textBoxInterestRate.BackColor = Color.White;
        }
    }
}

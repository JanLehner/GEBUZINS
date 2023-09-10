using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GebuZins
{
    public partial class Form2 : Form
    {
        private Dataprocessor _dataprocessor;
        private Datachecker _checker;
        public Form2(Dataprocessor dataprocessor, Datachecker checker)
        {
            InitializeComponent();
            _dataprocessor = dataprocessor;
            _checker = checker;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string birthdayDate = Convert.ToString(this.pickerBirthday.Value);
            string wealthAmount = this.textBoxWealth.Text;
            string interestRate = this.textBoxInterestRate.Text;
            /*Hier Prüfung der Daten*/
            decimal[] results = _dataprocessor.processData(_checker.checkData(birthdayDate, wealthAmount, interestRate));
            this.labelAmountToGet.Text = (results[0] + " CHF");
            this.labelAmountTax.Text = (results[1] + " CHF");
        }
    }
}

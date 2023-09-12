namespace GebuZins
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonCalculate = new Button();
            textBoxInterestRate = new TextBox();
            textBoxWealth = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pickerBirthday = new DateTimePicker();
            pictureBox1 = new PictureBox();
            labelError = new Label();
            labelAmountTax = new Label();
            labelAmountToGet = new Label();
            label2 = new Label();
            label7 = new Label();
            buttonNew = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(61, 320);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 6;
            label1.Text = "Vermögen:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Anchor = AnchorStyles.None;
            buttonCalculate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCalculate.Location = new Point(161, 400);
            buttonCalculate.Margin = new Padding(2);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(150, 48);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Bonus berechnen";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += ButtonCalculate_Click;
            // 
            // textBoxInterestRate
            // 
            textBoxInterestRate.Anchor = AnchorStyles.None;
            textBoxInterestRate.Location = new Point(161, 212);
            textBoxInterestRate.Margin = new Padding(2);
            textBoxInterestRate.Name = "textBoxInterestRate";
            textBoxInterestRate.Size = new Size(150, 23);
            textBoxInterestRate.TabIndex = 8;
            textBoxInterestRate.TextChanged += CheckInputData;
            // 
            // textBoxWealth
            // 
            textBoxWealth.Anchor = AnchorStyles.None;
            textBoxWealth.Location = new Point(161, 319);
            textBoxWealth.Margin = new Padding(2);
            textBoxWealth.Name = "textBoxWealth";
            textBoxWealth.Size = new Size(150, 23);
            textBoxWealth.TabIndex = 9;
            textBoxWealth.TextChanged += CheckInputData;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(61, 267);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 12;
            label3.Text = "Geburtstag:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(61, 212);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 13;
            label4.Text = "Zinssatz:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(342, 212);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(21, 19);
            label5.TabIndex = 14;
            label5.Text = "%";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(326, 320);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 19);
            label6.TabIndex = 15;
            label6.Text = "CHF";
            // 
            // pickerBirthday
            // 
            pickerBirthday.Anchor = AnchorStyles.None;
            pickerBirthday.CustomFormat = " dd MMMM";
            pickerBirthday.Format = DateTimePickerFormat.Custom;
            pickerBirthday.Location = new Point(161, 265);
            pickerBirthday.Margin = new Padding(3, 2, 3, 2);
            pickerBirthday.Name = "pickerBirthday";
            pickerBirthday.Size = new Size(150, 23);
            pickerBirthday.TabIndex = 17;
            pickerBirthday.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.GEBUZINS_logo;
            pictureBox1.Location = new Point(125, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // labelError
            // 
            labelError.Anchor = AnchorStyles.None;
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(164, 359);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 19);
            labelError.TabIndex = 19;
            labelError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAmountTax
            // 
            labelAmountTax.Anchor = AnchorStyles.None;
            labelAmountTax.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelAmountTax.ForeColor = SystemColors.Control;
            labelAmountTax.Location = new Point(10, 169);
            labelAmountTax.Margin = new Padding(2, 0, 2, 0);
            labelAmountTax.Name = "labelAmountTax";
            labelAmountTax.Size = new Size(301, 17);
            labelAmountTax.TabIndex = 23;
            labelAmountTax.Text = "XXXX CHF";
            labelAmountTax.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelAmountToGet
            // 
            labelAmountToGet.Anchor = AnchorStyles.None;
            labelAmountToGet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelAmountToGet.ForeColor = SystemColors.Control;
            labelAmountToGet.Location = new Point(10, 118);
            labelAmountToGet.Margin = new Padding(2, 0, 2, 0);
            labelAmountToGet.Name = "labelAmountToGet";
            labelAmountToGet.Size = new Size(301, 17);
            labelAmountToGet.TabIndex = 22;
            labelAmountToGet.Text = "XXXX CHF";
            labelAmountToGet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(159, 152);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 19);
            label2.TabIndex = 21;
            label2.Text = "Verrechnungssteuer:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(152, 100);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(152, 19);
            label7.TabIndex = 20;
            label7.Text = "Zu erhaltener Betrag:";
            // 
            // buttonNew
            // 
            buttonNew.Anchor = AnchorStyles.None;
            buttonNew.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNew.Location = new Point(161, 460);
            buttonNew.Margin = new Padding(2);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(150, 48);
            buttonNew.TabIndex = 24;
            buttonNew.Text = "Neu";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += ButtonNew_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(472, 526);
            Controls.Add(buttonNew);
            Controls.Add(labelAmountTax);
            Controls.Add(labelAmountToGet);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(labelError);
            Controls.Add(pictureBox1);
            Controls.Add(pickerBirthday);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxWealth);
            Controls.Add(textBoxInterestRate);
            Controls.Add(label1);
            Controls.Add(buttonCalculate);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Eingabe Daten";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonCalculate;
        private TextBox textBoxWealth;
        private TextBox textBoxInterestRate;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker pickerBirthday;
        private PictureBox pictureBox1;
        private Label labelError;
        private Label labelAmountTax;
        private Label labelAmountToGet;
        private Label label2;
        private Label label7;
        private Button buttonNew;
        private TextBox textInterestRate;
    }
}
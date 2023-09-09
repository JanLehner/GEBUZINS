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
            textBoxWealth = new TextBox();
            textBoxInterestRate = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pickerBirthday = new DateTimePicker();
            pictureBox1 = new PictureBox();
            labelError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(70, 426);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 6;
            label1.Text = "Vermögen:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Anchor = AnchorStyles.None;
            buttonCalculate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCalculate.Location = new Point(184, 557);
            buttonCalculate.Margin = new Padding(2, 3, 2, 3);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(171, 64);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Bonus berechnen";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textBoxWealth
            // 
            textBoxWealth.Anchor = AnchorStyles.None;
            textBoxWealth.Location = new Point(184, 282);
            textBoxWealth.Margin = new Padding(2, 3, 2, 3);
            textBoxWealth.Name = "textBoxWealth";
            textBoxWealth.Size = new Size(171, 27);
            textBoxWealth.TabIndex = 8;
            // 
            // textBoxInterestRate
            // 
            textBoxInterestRate.Anchor = AnchorStyles.None;
            textBoxInterestRate.Location = new Point(184, 425);
            textBoxInterestRate.Margin = new Padding(2, 3, 2, 3);
            textBoxInterestRate.Name = "textBoxInterestRate";
            textBoxInterestRate.Size = new Size(171, 27);
            textBoxInterestRate.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(70, 356);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 12;
            label3.Text = "Geburtstag:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(70, 283);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 13;
            label4.Text = "Zinssatz:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(385, 283);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(25, 23);
            label5.TabIndex = 14;
            label5.Text = "%";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(385, 426);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 23);
            label6.TabIndex = 15;
            label6.Text = "CHF";
            // 
            // pickerBirthday
            // 
            pickerBirthday.Anchor = AnchorStyles.None;
            pickerBirthday.CustomFormat = " dd MMMM";
            pickerBirthday.Format = DateTimePickerFormat.Custom;
            pickerBirthday.Location = new Point(184, 353);
            pickerBirthday.Name = "pickerBirthday";
            pickerBirthday.Size = new Size(171, 27);
            pickerBirthday.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.GEBUZINS_logo;
            pictureBox1.Location = new Point(143, 102);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 97);
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
            labelError.Location = new Point(195, 493);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 23);
            labelError.TabIndex = 19;
            labelError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(539, 701);
            Controls.Add(labelError);
            Controls.Add(pictureBox1);
            Controls.Add(pickerBirthday);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxInterestRate);
            Controls.Add(textBoxWealth);
            Controls.Add(label1);
            Controls.Add(buttonCalculate);
            Margin = new Padding(2, 3, 2, 3);
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
    }
}
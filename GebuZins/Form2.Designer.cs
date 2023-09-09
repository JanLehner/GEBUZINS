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
            label2 = new Label();
            label1 = new Label();
            buttonCalculate = new Button();
            textBoxWealth = new TextBox();
            textBoxInterestRate = new TextBox();
            comboBirthmonth = new ComboBox();
            comboBirthday = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 7;
            label2.Text = "Geburtsmonat:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 72);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 6;
            label1.Text = "Vermögen:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(248, 279);
            buttonCalculate.Margin = new Padding(2);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(130, 27);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Bonus berechnen";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textBoxWealth
            // 
            textBoxWealth.Location = new Point(302, 72);
            textBoxWealth.Margin = new Padding(2);
            textBoxWealth.Name = "textBoxWealth";
            textBoxWealth.Size = new Size(121, 27);
            textBoxWealth.TabIndex = 8;
            // 
            // textBoxInterestRate
            // 
            textBoxInterestRate.Location = new Point(301, 200);
            textBoxInterestRate.Margin = new Padding(2);
            textBoxInterestRate.Name = "textBoxInterestRate";
            textBoxInterestRate.Size = new Size(121, 27);
            textBoxInterestRate.TabIndex = 9;
            // 
            // comboBirthmonth
            // 
            comboBirthmonth.FormattingEnabled = true;
            comboBirthmonth.Items.AddRange(new object[] { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" });
            comboBirthmonth.Location = new Point(302, 111);
            comboBirthmonth.Margin = new Padding(2);
            comboBirthmonth.Name = "comboBirthmonth";
            comboBirthmonth.Size = new Size(146, 28);
            comboBirthmonth.TabIndex = 10;
            // 
            // comboBirthday
            // 
            comboBirthday.FormattingEnabled = true;
            comboBirthday.Location = new Point(302, 157);
            comboBirthday.Margin = new Padding(2);
            comboBirthday.Name = "comboBirthday";
            comboBirthday.Size = new Size(146, 28);
            comboBirthday.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 159);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 12;
            label3.Text = "Geburtstag:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 202);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 13;
            label4.Text = "Zinssatz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 200);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(21, 20);
            label5.TabIndex = 14;
            label5.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(426, 72);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 15;
            label6.Text = "CHF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(309, 248);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 16;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBirthday);
            Controls.Add(comboBirthmonth);
            Controls.Add(textBoxInterestRate);
            Controls.Add(textBoxWealth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCalculate);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Eingabe Daten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button buttonCalculate;
        private TextBox textBoxWealth;
        private TextBox textBoxInterestRate;
        private ComboBox comboBirthmonth;
        private ComboBox comboBirthday;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
namespace GebuZins
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonChangeData = new Button();
            label1 = new Label();
            label2 = new Label();
            labelAmountToGet = new Label();
            labelAmountTax = new Label();
            SuspendLayout();
            // 
            // buttonChangeData
            // 
            buttonChangeData.Location = new Point(249, 254);
            buttonChangeData.Margin = new Padding(2);
            buttonChangeData.Name = "buttonChangeData";
            buttonChangeData.Size = new Size(130, 27);
            buttonChangeData.TabIndex = 0;
            buttonChangeData.Text = "Daten bearbeiten";
            buttonChangeData.UseVisualStyleBackColor = true;
            buttonChangeData.Click += buttonChangeData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 124);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 1;
            label1.Text = "Zu erhaltener Betrag:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 172);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 2;
            label2.Text = "Verrechnungssteuer:";
            // 
            // labelAmountToGet
            // 
            labelAmountToGet.AutoSize = true;
            labelAmountToGet.Location = new Point(359, 124);
            labelAmountToGet.Margin = new Padding(2, 0, 2, 0);
            labelAmountToGet.Name = "labelAmountToGet";
            labelAmountToGet.Size = new Size(76, 20);
            labelAmountToGet.TabIndex = 3;
            labelAmountToGet.Text = "XXXX CHF";
            // 
            // labelAmountTax
            // 
            labelAmountTax.AutoSize = true;
            labelAmountTax.Location = new Point(359, 172);
            labelAmountTax.Margin = new Padding(2, 0, 2, 0);
            labelAmountTax.Name = "labelAmountTax";
            labelAmountTax.Size = new Size(76, 20);
            labelAmountTax.TabIndex = 4;
            labelAmountTax.Text = "XXXX CHF";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(labelAmountTax);
            Controls.Add(labelAmountToGet);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonChangeData);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Ausgabe Resultat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonChangeData;
        private Label label1;
        private Label label2;
        private Label labelAmountToGet;
        private Label labelAmountTax;
    }
}
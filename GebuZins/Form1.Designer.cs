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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(311, 317);
            button1.Name = "button1";
            button1.Size = new Size(162, 34);
            button1.TabIndex = 0;
            button1.Text = "Daten bearbeiten";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 155);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 1;
            label1.Text = "Zu erhaltener Betrag:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 215);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 2;
            label2.Text = "Verrechnungssteuer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 155);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 3;
            label3.Text = "XXXX CHF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 215);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 4;
            label4.Text = "XXXX CHF";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
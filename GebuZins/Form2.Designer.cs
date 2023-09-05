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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
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
            label2.Location = new Point(214, 142);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 7;
            label2.Text = "Geburtsmonat:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 90);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 6;
            label1.Text = "Vermögen:";
            // 
            // button1
            // 
            button1.Location = new Point(310, 349);
            button1.Name = "button1";
            button1.Size = new Size(162, 34);
            button1.TabIndex = 5;
            button1.Text = "Bonus berechnen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(377, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(376, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember" });
            comboBox1.Location = new Point(377, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(377, 196);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 199);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 12;
            label3.Text = "Geburtstag:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 253);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 13;
            label4.Text = "Zinssatz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 250);
            label5.Name = "label5";
            label5.Size = new Size(27, 25);
            label5.TabIndex = 14;
            label5.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(533, 90);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 15;
            label6.Text = "CHF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(386, 310);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 16;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
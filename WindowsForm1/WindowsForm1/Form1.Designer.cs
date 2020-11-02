namespace WindowsForm1
{
    partial class Form1
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
            this.Anketa = new System.Windows.Forms.GroupBox();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.manButton = new System.Windows.Forms.RadioButton();
            this.womanButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Anketa.SuspendLayout();
            this.SuspendLayout();
            // 
            // Anketa
            // 
            this.Anketa.Controls.Add(this.womanButton);
            this.Anketa.Controls.Add(this.manButton);
            this.Anketa.Controls.Add(this.dateTimePicker1);
            this.Anketa.Controls.Add(this.textBox5);
            this.Anketa.Controls.Add(this.textBox4);
            this.Anketa.Controls.Add(this.textBox3);
            this.Anketa.Controls.Add(this.textBox2);
            this.Anketa.Controls.Add(this.textBox1);
            this.Anketa.Controls.Add(this.label9);
            this.Anketa.Controls.Add(this.label8);
            this.Anketa.Controls.Add(this.phone);
            this.Anketa.Controls.Add(this.City);
            this.Anketa.Controls.Add(this.country);
            this.Anketa.Controls.Add(this.name);
            this.Anketa.Controls.Add(this.surname);
            this.Anketa.Location = new System.Drawing.Point(66, 36);
            this.Anketa.Name = "Anketa";
            this.Anketa.Size = new System.Drawing.Size(282, 358);
            this.Anketa.TabIndex = 0;
            this.Anketa.TabStop = false;
            this.Anketa.Text = "Anketa";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(7, 20);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(56, 13);
            this.surname.TabIndex = 0;
            this.surname.Text = "Прізвище";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(7, 48);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(24, 13);
            this.name.TabIndex = 0;
            this.name.Text = "Імя";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(7, 74);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(41, 13);
            this.country.TabIndex = 0;
            this.country.Text = "Країна";
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(7, 102);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(35, 13);
            this.City.TabIndex = 0;
            this.City.Text = "Місто";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(7, 127);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(52, 13);
            this.phone.TabIndex = 0;
            this.phone.Text = "Телефон";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(69, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(69, 123);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "День Народження";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Стать";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // manButton
            // 
            this.manButton.AutoSize = true;
            this.manButton.Location = new System.Drawing.Point(69, 262);
            this.manButton.Name = "manButton";
            this.manButton.Size = new System.Drawing.Size(70, 17);
            this.manButton.TabIndex = 3;
            this.manButton.TabStop = true;
            this.manButton.Text = "Чоловіча";
            this.manButton.UseVisualStyleBackColor = true;
            // 
            // womanButton
            // 
            this.womanButton.AutoSize = true;
            this.womanButton.Location = new System.Drawing.Point(179, 262);
            this.womanButton.Name = "womanButton";
            this.womanButton.Size = new System.Drawing.Size(61, 17);
            this.womanButton.TabIndex = 3;
            this.womanButton.TabStop = true;
            this.womanButton.Text = "Жіноча";
            this.womanButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Text Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Anketa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Anketa.ResumeLayout(false);
            this.Anketa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Anketa;
        private System.Windows.Forms.RadioButton womanButton;
        private System.Windows.Forms.RadioButton manButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Button button1;
    }
}


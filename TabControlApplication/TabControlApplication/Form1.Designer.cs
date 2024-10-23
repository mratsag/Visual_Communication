namespace TabControlApplication
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textColor = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSent = new System.Windows.Forms.Button();
            this.BtnGender2 = new System.Windows.Forms.RadioButton();
            this.BtnGender1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFesir = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBirtday = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 574);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPage1.Controls.Add(this.textColor);
            this.tabPage1.Controls.Add(this.btnColor);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.BtnSent);
            this.tabPage1.Controls.Add(this.BtnGender2);
            this.tabPage1.Controls.Add(this.BtnGender1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblFesir);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.dateTimePicker);
            this.tabPage1.Controls.Add(this.textSurname);
            this.tabPage1.Controls.Add(this.textName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblBirtday);
            this.tabPage1.Controls.Add(this.lblSurname);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registration";
            // 
            // textColor
            // 
            this.textColor.Location = new System.Drawing.Point(289, 281);
            this.textColor.Name = "textColor";
            this.textColor.Size = new System.Drawing.Size(100, 20);
            this.textColor.TabIndex = 18;
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnColor.Location = new System.Drawing.Point(200, 278);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 17;
            this.btnColor.Text = "Select";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(172, 476);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(217, 31);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Value = 10;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(323, 381);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(45, 20);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(256, 380);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Yes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Are you student ?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnSent
            // 
            this.BtnSent.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSent.Location = new System.Drawing.Point(422, 400);
            this.BtnSent.Name = "BtnSent";
            this.BtnSent.Size = new System.Drawing.Size(104, 32);
            this.BtnSent.TabIndex = 12;
            this.BtnSent.Text = "Sent";
            this.BtnSent.UseVisualStyleBackColor = true;
            this.BtnSent.Click += new System.EventHandler(this.BtnSent_Click);
            // 
            // BtnGender2
            // 
            this.BtnGender2.AutoSize = true;
            this.BtnGender2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGender2.ForeColor = System.Drawing.Color.White;
            this.BtnGender2.Location = new System.Drawing.Point(272, 334);
            this.BtnGender2.Name = "BtnGender2";
            this.BtnGender2.Size = new System.Drawing.Size(79, 20);
            this.BtnGender2.TabIndex = 11;
            this.BtnGender2.TabStop = true;
            this.BtnGender2.Text = "Female";
            this.BtnGender2.UseVisualStyleBackColor = true;
            // 
            // BtnGender1
            // 
            this.BtnGender1.AutoSize = true;
            this.BtnGender1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGender1.ForeColor = System.Drawing.Color.White;
            this.BtnGender1.Location = new System.Drawing.Point(185, 334);
            this.BtnGender1.Name = "BtnGender1";
            this.BtnGender1.Size = new System.Drawing.Size(59, 20);
            this.BtnGender1.TabIndex = 10;
            this.BtnGender1.TabStop = true;
            this.BtnGender1.Text = "Male";
            this.BtnGender1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gender  :";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblFesir
            // 
            this.lblFesir.AutoSize = true;
            this.lblFesir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFesir.ForeColor = System.Drawing.Color.White;
            this.lblFesir.Location = new System.Drawing.Point(69, 281);
            this.lblFesir.Name = "lblFesir";
            this.lblFesir.Size = new System.Drawing.Size(112, 18);
            this.lblFesir.TabIndex = 8;
            this.lblFesir.Text = "Your Color :";
            this.lblFesir.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Türkiye",
            "Fransa",
            "İspanya",
            "USD"});
            this.comboBox1.Location = new System.Drawing.Point(200, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(200, 176);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(200, 119);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(100, 20);
            this.textSurname.TabIndex = 5;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(200, 67);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Country :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBirtday
            // 
            this.lblBirtday.AutoSize = true;
            this.lblBirtday.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirtday.ForeColor = System.Drawing.Color.White;
            this.lblBirtday.Location = new System.Drawing.Point(69, 176);
            this.lblBirtday.Name = "lblBirtday";
            this.lblBirtday.Size = new System.Drawing.Size(93, 18);
            this.lblBirtday.TabIndex = 2;
            this.lblBirtday.Text = "Birthday :";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(69, 119);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(98, 18);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(69, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Show Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(170, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Your Information";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(107, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(345, 324);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(610, 571);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TabControlApplication";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBirtday;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label lblFesir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSent;
        private System.Windows.Forms.RadioButton BtnGender2;
        private System.Windows.Forms.RadioButton BtnGender1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}


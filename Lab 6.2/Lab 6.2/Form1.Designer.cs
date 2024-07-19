namespace Lab_6._2
{
    partial class FormRegex
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckEmail = new System.Windows.Forms.Button();
            this.btnDeleteExtra = new System.Windows.Forms.Button();
            this.btnValidatePC = new System.Windows.Forms.Button();
            this.btnDeleteLetters = new System.Windows.Forms.Button();
            this.btnValid = new System.Windows.Forms.Button();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the text to validate:";
            // 
            // btnCheckEmail
            // 
            this.btnCheckEmail.Location = new System.Drawing.Point(42, 77);
            this.btnCheckEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckEmail.Name = "btnCheckEmail";
            this.btnCheckEmail.Size = new System.Drawing.Size(112, 64);
            this.btnCheckEmail.TabIndex = 1;
            this.btnCheckEmail.Text = "Check\r\n&E-mail";
            this.btnCheckEmail.UseVisualStyleBackColor = true;
            this.btnCheckEmail.Click += new System.EventHandler(this.btnCheckEmail_Click);
            // 
            // btnDeleteExtra
            // 
            this.btnDeleteExtra.Location = new System.Drawing.Point(171, 77);
            this.btnDeleteExtra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteExtra.Name = "btnDeleteExtra";
            this.btnDeleteExtra.Size = new System.Drawing.Size(112, 64);
            this.btnDeleteExtra.TabIndex = 2;
            this.btnDeleteExtra.Text = "Delete Extra\r\n&Spaces\r\n";
            this.btnDeleteExtra.UseVisualStyleBackColor = true;
            this.btnDeleteExtra.Click += new System.EventHandler(this.btnDeleteExtra_Click);
            // 
            // btnValidatePC
            // 
            this.btnValidatePC.Location = new System.Drawing.Point(300, 77);
            this.btnValidatePC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValidatePC.Name = "btnValidatePC";
            this.btnValidatePC.Size = new System.Drawing.Size(112, 64);
            this.btnValidatePC.TabIndex = 3;
            this.btnValidatePC.Text = "Validate\r\n&Postal Code\r\n";
            this.btnValidatePC.UseVisualStyleBackColor = true;
            this.btnValidatePC.Click += new System.EventHandler(this.btnValidatePC_Click);
            // 
            // btnDeleteLetters
            // 
            this.btnDeleteLetters.Location = new System.Drawing.Point(429, 77);
            this.btnDeleteLetters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteLetters.Name = "btnDeleteLetters";
            this.btnDeleteLetters.Size = new System.Drawing.Size(112, 64);
            this.btnDeleteLetters.TabIndex = 4;
            this.btnDeleteLetters.Text = "Delete &Letters\r\na,b,c and d";
            this.btnDeleteLetters.UseVisualStyleBackColor = true;
            this.btnDeleteLetters.Click += new System.EventHandler(this.btnDeleteLetters_Click);
            // 
            // btnValid
            // 
            this.btnValid.Location = new System.Drawing.Point(395, 173);
            this.btnValid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(105, 165);
            this.btnValid.TabIndex = 12;
            this.btnValid.Text = "&Validate \r\nUser Name \r\nAddress \r\nCity \r\nProvince \r\nPostal Code \r\nTelephone ";
            this.btnValid.UseVisualStyleBackColor = true;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(558, 77);
            this.btnCreateArray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(112, 64);
            this.btnCreateArray.TabIndex = 5;
            this.btnCreateArray.Text = "Create an\r\n&Array of\r\nWords";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "User name:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(134, 173);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(230, 23);
            this.txtUser.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(134, 201);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 23);
            this.txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(134, 229);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(230, 23);
            this.txtCity.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Province:";
            // 
            // txtProv
            // 
            this.txtProv.Location = new System.Drawing.Point(134, 257);
            this.txtProv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(230, 23);
            this.txtProv.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 287);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Postal Code:";
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(134, 285);
            this.txtPC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(230, 23);
            this.txtPC.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telephone:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(134, 313);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(230, 23);
            this.txtTel.TabIndex = 11;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(595, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(705, 371);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnCreateArray);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.btnDeleteLetters);
            this.Controls.Add(this.btnValidatePC);
            this.Controls.Add(this.btnDeleteExtra);
            this.Controls.Add(this.btnCheckEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRegex";
            this.Text = "Form Regex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckEmail;
        private System.Windows.Forms.Button btnDeleteExtra;
        private System.Windows.Forms.Button btnValidatePC;
        private System.Windows.Forms.Button btnDeleteLetters;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btnExit;
    }
}


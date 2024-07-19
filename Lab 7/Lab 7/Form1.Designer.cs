namespace Lab_7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_writeDataToText = new System.Windows.Forms.Button();
            this.btn_writeDataToBinary = new System.Windows.Forms.Button();
            this.btn_readDataToText = new System.Windows.Forms.Button();
            this.btn_readDataToBinary = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(58, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btn_writeDataToText
            // 
            this.btn_writeDataToText.Location = new System.Drawing.Point(27, 177);
            this.btn_writeDataToText.Name = "btn_writeDataToText";
            this.btn_writeDataToText.Size = new System.Drawing.Size(100, 50);
            this.btn_writeDataToText.TabIndex = 7;
            this.btn_writeDataToText.Text = "Write data into text file";
            this.btn_writeDataToText.UseVisualStyleBackColor = true;
            this.btn_writeDataToText.Click += new System.EventHandler(this.btn_writeDataToText_Click);
            // 
            // btn_writeDataToBinary
            // 
            this.btn_writeDataToBinary.Location = new System.Drawing.Point(27, 236);
            this.btn_writeDataToBinary.Name = "btn_writeDataToBinary";
            this.btn_writeDataToBinary.Size = new System.Drawing.Size(100, 50);
            this.btn_writeDataToBinary.TabIndex = 8;
            this.btn_writeDataToBinary.Text = "Write data into binary file";
            this.btn_writeDataToBinary.UseVisualStyleBackColor = true;
            this.btn_writeDataToBinary.Click += new System.EventHandler(this.btn_writeDataToBinary_Click);
            // 
            // btn_readDataToText
            // 
            this.btn_readDataToText.Location = new System.Drawing.Point(141, 177);
            this.btn_readDataToText.Name = "btn_readDataToText";
            this.btn_readDataToText.Size = new System.Drawing.Size(100, 50);
            this.btn_readDataToText.TabIndex = 9;
            this.btn_readDataToText.Text = "read data from text file";
            this.btn_readDataToText.UseVisualStyleBackColor = true;
            this.btn_readDataToText.Click += new System.EventHandler(this.btn_readDataToText_Click);
            // 
            // btn_readDataToBinary
            // 
            this.btn_readDataToBinary.Location = new System.Drawing.Point(141, 236);
            this.btn_readDataToBinary.Name = "btn_readDataToBinary";
            this.btn_readDataToBinary.Size = new System.Drawing.Size(100, 50);
            this.btn_readDataToBinary.TabIndex = 10;
            this.btn_readDataToBinary.Text = "Read data from binary file";
            this.btn_readDataToBinary.UseVisualStyleBackColor = true;
            this.btn_readDataToBinary.Click += new System.EventHandler(this.btn_readDataToBinary_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(263, 263);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(376, 298);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_readDataToBinary);
            this.Controls.Add(this.btn_readDataToText);
            this.Controls.Add(this.btn_writeDataToBinary);
            this.Controls.Add(this.btn_writeDataToText);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Working with FileStream, StreamWriter and StreamReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_writeDataToText;
        private System.Windows.Forms.Button btn_writeDataToBinary;
        private System.Windows.Forms.Button btn_readDataToText;
        private System.Windows.Forms.Button btn_readDataToBinary;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox textBox4;
    }
}


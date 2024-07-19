namespace Lab_6._1
{
    partial class StringHandling
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_parse_name = new System.Windows.Forms.Button();
            this.btn_phone_number = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter full name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter phone number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_parse_name
            // 
            this.btn_parse_name.Location = new System.Drawing.Point(365, 46);
            this.btn_parse_name.Name = "btn_parse_name";
            this.btn_parse_name.Size = new System.Drawing.Size(110, 23);
            this.btn_parse_name.TabIndex = 5;
            this.btn_parse_name.Text = "&Parse Name";
            this.btn_parse_name.UseVisualStyleBackColor = true;
            this.btn_parse_name.Click += new System.EventHandler(this.btn_parse_name_Click);
            // 
            // btn_phone_number
            // 
            this.btn_phone_number.Location = new System.Drawing.Point(365, 83);
            this.btn_phone_number.Name = "btn_phone_number";
            this.btn_phone_number.Size = new System.Drawing.Size(110, 23);
            this.btn_phone_number.TabIndex = 6;
            this.btn_phone_number.Text = "&Edit Phone Number";
            this.btn_phone_number.UseVisualStyleBackColor = true;
            this.btn_phone_number.Click += new System.EventHandler(this.btn_phone_number_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(383, 131);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // StringHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 188);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_phone_number);
            this.Controls.Add(this.btn_parse_name);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StringHandling";
            this.Text = "String Handling";
            this.Load += new System.EventHandler(this.StringHandling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_parse_name;
        private System.Windows.Forms.Button btn_phone_number;
        private System.Windows.Forms.Button btn_exit;
    }
}


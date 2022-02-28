namespace userlogin
{
    partial class Edit_Details
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
            this.txt_out_name = new System.Windows.Forms.TextBox();
            this.txt_out_email = new System.Windows.Forms.TextBox();
            this.txt_out_phone = new System.Windows.Forms.TextBox();
            this.txt_out_city = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.signout_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "City :";
            // 
            // txt_out_name
            // 
            this.txt_out_name.Location = new System.Drawing.Point(221, 46);
            this.txt_out_name.Name = "txt_out_name";
            this.txt_out_name.Size = new System.Drawing.Size(279, 22);
            this.txt_out_name.TabIndex = 4;
            // 
            // txt_out_email
            // 
            this.txt_out_email.Location = new System.Drawing.Point(220, 102);
            this.txt_out_email.Name = "txt_out_email";
            this.txt_out_email.Size = new System.Drawing.Size(280, 22);
            this.txt_out_email.TabIndex = 5;
            // 
            // txt_out_phone
            // 
            this.txt_out_phone.Location = new System.Drawing.Point(220, 158);
            this.txt_out_phone.Name = "txt_out_phone";
            this.txt_out_phone.Size = new System.Drawing.Size(280, 22);
            this.txt_out_phone.TabIndex = 6;
            // 
            // txt_out_city
            // 
            this.txt_out_city.Location = new System.Drawing.Point(221, 215);
            this.txt_out_city.Name = "txt_out_city";
            this.txt_out_city.Size = new System.Drawing.Size(280, 22);
            this.txt_out_city.TabIndex = 7;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(221, 304);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(118, 50);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // signout_btn
            // 
            this.signout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout_btn.Location = new System.Drawing.Point(399, 304);
            this.signout_btn.Name = "signout_btn";
            this.signout_btn.Size = new System.Drawing.Size(102, 50);
            this.signout_btn.TabIndex = 9;
            this.signout_btn.Text = "Signout";
            this.signout_btn.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 421);
            this.Controls.Add(this.signout_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.txt_out_city);
            this.Controls.Add(this.txt_out_phone);
            this.Controls.Add(this.txt_out_email);
            this.Controls.Add(this.txt_out_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Edit Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_out_name;
        private System.Windows.Forms.TextBox txt_out_email;
        private System.Windows.Forms.TextBox txt_out_phone;
        private System.Windows.Forms.TextBox txt_out_city;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button signout_btn;
    }
}
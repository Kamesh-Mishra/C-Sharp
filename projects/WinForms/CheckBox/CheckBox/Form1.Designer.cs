namespace CheckBox
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
            this.SamsungChk = new System.Windows.Forms.CheckBox();
            this.IphoneChk = new System.Windows.Forms.CheckBox();
            this.NokiaChk = new System.Windows.Forms.CheckBox();
            this.OppoChk = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select your favourite mobile companies";
            // 
            // SamsungChk
            // 
            this.SamsungChk.AutoSize = true;
            this.SamsungChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamsungChk.Location = new System.Drawing.Point(57, 75);
            this.SamsungChk.Name = "SamsungChk";
            this.SamsungChk.Size = new System.Drawing.Size(108, 24);
            this.SamsungChk.TabIndex = 1;
            this.SamsungChk.Text = "Samsung";
            this.SamsungChk.UseVisualStyleBackColor = true;
            this.SamsungChk.CheckedChanged += new System.EventHandler(this.SamsungChk_CheckedChanged);
            // 
            // IphoneChk
            // 
            this.IphoneChk.AutoSize = true;
            this.IphoneChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IphoneChk.Location = new System.Drawing.Point(57, 111);
            this.IphoneChk.Name = "IphoneChk";
            this.IphoneChk.Size = new System.Drawing.Size(86, 24);
            this.IphoneChk.TabIndex = 1;
            this.IphoneChk.Text = "Iphone";
            this.IphoneChk.UseVisualStyleBackColor = true;
            this.IphoneChk.CheckedChanged += new System.EventHandler(this.IphoneChk_CheckedChanged);
            // 
            // NokiaChk
            // 
            this.NokiaChk.AutoSize = true;
            this.NokiaChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NokiaChk.Location = new System.Drawing.Point(56, 156);
            this.NokiaChk.Name = "NokiaChk";
            this.NokiaChk.Size = new System.Drawing.Size(78, 24);
            this.NokiaChk.TabIndex = 1;
            this.NokiaChk.Text = "Nokia";
            this.NokiaChk.UseVisualStyleBackColor = true;
            this.NokiaChk.CheckedChanged += new System.EventHandler(this.NokiaChk_CheckedChanged);
            // 
            // OppoChk
            // 
            this.OppoChk.AutoSize = true;
            this.OppoChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OppoChk.Location = new System.Drawing.Point(57, 195);
            this.OppoChk.Name = "OppoChk";
            this.OppoChk.Size = new System.Drawing.Size(75, 24);
            this.OppoChk.TabIndex = 1;
            this.OppoChk.Text = "Oppo";
            this.OppoChk.UseVisualStyleBackColor = true;
            this.OppoChk.CheckedChanged += new System.EventHandler(this.OppoChk_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(57, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(57, 358);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 26);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(195, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "My Button";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IphoneChk);
            this.Controls.Add(this.OppoChk);
            this.Controls.Add(this.NokiaChk);
            this.Controls.Add(this.SamsungChk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SamsungChk;
        private System.Windows.Forms.CheckBox IphoneChk;
        private System.Windows.Forms.CheckBox NokiaChk;
        private System.Windows.Forms.CheckBox OppoChk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
    }
}


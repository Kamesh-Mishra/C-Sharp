namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.MulButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Calculator Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter First Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Second Number :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(424, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(331, 22);
            this.textBox2.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(82, 228);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 43);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubButton
            // 
            this.SubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubButton.Location = new System.Drawing.Point(275, 228);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(93, 43);
            this.SubButton.TabIndex = 6;
            this.SubButton.Text = "Sub";
            this.SubButton.UseVisualStyleBackColor = true;
            this.SubButton.Click += new System.EventHandler(this.SubButton_Click);
            // 
            // MulButton
            // 
            this.MulButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MulButton.Location = new System.Drawing.Point(474, 228);
            this.MulButton.Name = "MulButton";
            this.MulButton.Size = new System.Drawing.Size(93, 43);
            this.MulButton.TabIndex = 7;
            this.MulButton.Text = "Mul";
            this.MulButton.UseVisualStyleBackColor = true;
            this.MulButton.Click += new System.EventHandler(this.MulButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivButton.Location = new System.Drawing.Point(686, 228);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(93, 43);
            this.DivButton.TabIndex = 8;
            this.DivButton.Text = "Div";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Result";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.MulButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button MulButton;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.Label label4;
    }
}


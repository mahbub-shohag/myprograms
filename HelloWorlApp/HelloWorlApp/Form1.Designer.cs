namespace HelloWorlApp
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
            this.showButton1 = new System.Windows.Forms.Button();
            this.showButton2 = new System.Windows.Forms.Button();
            this.showButton3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showButton1
            // 
            this.showButton1.Location = new System.Drawing.Point(17, 65);
            this.showButton1.Name = "showButton1";
            this.showButton1.Size = new System.Drawing.Size(75, 23);
            this.showButton1.TabIndex = 0;
            this.showButton1.Text = "Show1";
            this.showButton1.UseVisualStyleBackColor = true;
            this.showButton1.Click += new System.EventHandler(this.showButton1_Click);
            // 
            // showButton2
            // 
            this.showButton2.Location = new System.Drawing.Point(148, 65);
            this.showButton2.Name = "showButton2";
            this.showButton2.Size = new System.Drawing.Size(75, 23);
            this.showButton2.TabIndex = 1;
            this.showButton2.Text = "Show2";
            this.showButton2.UseVisualStyleBackColor = true;
            this.showButton2.Click += new System.EventHandler(this.showButton2_Click);
            // 
            // showButton3
            // 
            this.showButton3.Location = new System.Drawing.Point(285, 65);
            this.showButton3.Name = "showButton3";
            this.showButton3.Size = new System.Drawing.Size(75, 23);
            this.showButton3.TabIndex = 2;
            this.showButton3.Text = "Show3";
            this.showButton3.UseVisualStyleBackColor = true;
            this.showButton3.Click += new System.EventHandler(this.showButton3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please type your name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 108);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.showButton3);
            this.Controls.Add(this.showButton2);
            this.Controls.Add(this.showButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton1;
        private System.Windows.Forms.Button showButton2;
        private System.Windows.Forms.Button showButton3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}


namespace TicketSellingApp27sep_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customrNameTextBox = new System.Windows.Forms.TextBox();
            this.TicketQuantityTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.showDetailButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of tickets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Per ticket 10 taka";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showDetailButton);
            this.groupBox1.Controls.Add(this.TicketQuantityTextBox);
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customrNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticcket purchase Info";
            // 
            // customrNameTextBox
            // 
            this.customrNameTextBox.Location = new System.Drawing.Point(103, 39);
            this.customrNameTextBox.Name = "customrNameTextBox";
            this.customrNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customrNameTextBox.TabIndex = 0;
            // 
            // TicketQuantityTextBox
            // 
            this.TicketQuantityTextBox.Location = new System.Drawing.Point(103, 76);
            this.TicketQuantityTextBox.Name = "TicketQuantityTextBox";
            this.TicketQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.TicketQuantityTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(13, 132);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Save";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // showDetailButton
            // 
            this.showDetailButton.Location = new System.Drawing.Point(128, 132);
            this.showDetailButton.Name = "showDetailButton";
            this.showDetailButton.Size = new System.Drawing.Size(75, 23);
            this.showDetailButton.TabIndex = 3;
            this.showDetailButton.Text = "Details";
            this.showDetailButton.UseVisualStyleBackColor = true;
            this.showDetailButton.Click += new System.EventHandler(this.showDetailButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 180);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button showDetailButton;
        private System.Windows.Forms.TextBox TicketQuantityTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox customrNameTextBox;
    }
}


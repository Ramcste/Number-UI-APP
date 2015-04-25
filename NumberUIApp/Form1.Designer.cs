namespace NumberUIApp
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
            this.addNumberButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addNumberButton
            // 
            this.addNumberButton.Location = new System.Drawing.Point(228, 23);
            this.addNumberButton.Name = "addNumberButton";
            this.addNumberButton.Size = new System.Drawing.Size(75, 23);
            this.addNumberButton.TabIndex = 1;
            this.addNumberButton.Text = "Add";
            this.addNumberButton.UseVisualStyleBackColor = true;
            this.addNumberButton.Click += new System.EventHandler(this.addNumberButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(111, 26);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number";
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.Location = new System.Drawing.Point(111, 68);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(120, 160);
            this.numberListBox.TabIndex = 4;
            this.numberListBox.SelectedIndexChanged += new System.EventHandler(this.numberListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 261);
            this.Controls.Add(this.numberListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.addNumberButton);
            this.Name = "Form1";
            this.Text = "Number UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNumberButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox numberListBox;
    }
}


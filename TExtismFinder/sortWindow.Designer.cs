namespace TExtismFinder
{
    partial class sortWindow
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
            this.DisplayWordBox = new System.Windows.Forms.TextBox();
            this.GenAbbrevButton = new System.Windows.Forms.RadioButton();
            this.Cat1Button = new System.Windows.Forms.RadioButton();
            this.Cat2Button = new System.Windows.Forms.RadioButton();
            this.DisregardButton = new System.Windows.Forms.RadioButton();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayWordBox
            // 
            this.DisplayWordBox.Location = new System.Drawing.Point(12, 13);
            this.DisplayWordBox.Name = "DisplayWordBox";
            this.DisplayWordBox.ReadOnly = true;
            this.DisplayWordBox.Size = new System.Drawing.Size(260, 20);
            this.DisplayWordBox.TabIndex = 0;
            // 
            // GenAbbrevButton
            // 
            this.GenAbbrevButton.AutoSize = true;
            this.GenAbbrevButton.Location = new System.Drawing.Point(12, 60);
            this.GenAbbrevButton.Name = "GenAbbrevButton";
            this.GenAbbrevButton.Size = new System.Drawing.Size(124, 17);
            this.GenAbbrevButton.TabIndex = 1;
            this.GenAbbrevButton.Text = "General Abbreviation";
            this.GenAbbrevButton.UseVisualStyleBackColor = true;
            // 
            // Cat1Button
            // 
            this.Cat1Button.AutoSize = true;
            this.Cat1Button.Location = new System.Drawing.Point(12, 83);
            this.Cat1Button.Name = "Cat1Button";
            this.Cat1Button.Size = new System.Drawing.Size(76, 17);
            this.Cat1Button.TabIndex = 2;
            this.Cat1Button.Text = "Category 1";
            this.Cat1Button.UseVisualStyleBackColor = true;
            // 
            // Cat2Button
            // 
            this.Cat2Button.AutoSize = true;
            this.Cat2Button.Location = new System.Drawing.Point(12, 106);
            this.Cat2Button.Name = "Cat2Button";
            this.Cat2Button.Size = new System.Drawing.Size(76, 17);
            this.Cat2Button.TabIndex = 3;
            this.Cat2Button.Text = "Category 2";
            this.Cat2Button.UseVisualStyleBackColor = true;
            // 
            // DisregardButton
            // 
            this.DisregardButton.AutoSize = true;
            this.DisregardButton.Checked = true;
            this.DisregardButton.Location = new System.Drawing.Point(12, 129);
            this.DisregardButton.Name = "DisregardButton";
            this.DisregardButton.Size = new System.Drawing.Size(70, 17);
            this.DisregardButton.TabIndex = 4;
            this.DisregardButton.TabStop = true;
            this.DisregardButton.Text = "Disregard";
            this.DisregardButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(13, 166);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // sortWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DisregardButton);
            this.Controls.Add(this.Cat2Button);
            this.Controls.Add(this.Cat1Button);
            this.Controls.Add(this.GenAbbrevButton);
            this.Controls.Add(this.DisplayWordBox);
            this.Name = "sortWindow";
            this.Text = "sortWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayWordBox;
        private System.Windows.Forms.RadioButton GenAbbrevButton;
        private System.Windows.Forms.RadioButton Cat1Button;
        private System.Windows.Forms.RadioButton Cat2Button;
        private System.Windows.Forms.RadioButton DisregardButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}
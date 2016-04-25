namespace TExtismFinder
{
    partial class TextismWindow
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
            this.TotalWordsBox = new System.Windows.Forms.TextBox();
            this.TotalAbbrBox = new System.Windows.Forms.TextBox();
            this.TotalCat2Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AvgLengthBox = new System.Windows.Forms.TextBox();
            this.TotalCat1Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NewFileButton = new System.Windows.Forms.Button();
            this.SaveResultsButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // TotalWordsBox
            // 
            this.TotalWordsBox.Location = new System.Drawing.Point(139, 12);
            this.TotalWordsBox.Name = "TotalWordsBox";
            this.TotalWordsBox.ReadOnly = true;
            this.TotalWordsBox.Size = new System.Drawing.Size(100, 20);
            this.TotalWordsBox.TabIndex = 0;
            // 
            // TotalAbbrBox
            // 
            this.TotalAbbrBox.Location = new System.Drawing.Point(139, 38);
            this.TotalAbbrBox.Name = "TotalAbbrBox";
            this.TotalAbbrBox.ReadOnly = true;
            this.TotalAbbrBox.Size = new System.Drawing.Size(100, 20);
            this.TotalAbbrBox.TabIndex = 1;
            // 
            // TotalCat2Box
            // 
            this.TotalCat2Box.Location = new System.Drawing.Point(139, 90);
            this.TotalCat2Box.Name = "TotalCat2Box";
            this.TotalCat2Box.ReadOnly = true;
            this.TotalCat2Box.Size = new System.Drawing.Size(100, 20);
            this.TotalCat2Box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Words";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Abbreviations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Avg. Tweet Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Category 1";
            // 
            // AvgLengthBox
            // 
            this.AvgLengthBox.Location = new System.Drawing.Point(139, 116);
            this.AvgLengthBox.Name = "AvgLengthBox";
            this.AvgLengthBox.ReadOnly = true;
            this.AvgLengthBox.Size = new System.Drawing.Size(100, 20);
            this.AvgLengthBox.TabIndex = 7;
            // 
            // TotalCat1Box
            // 
            this.TotalCat1Box.Location = new System.Drawing.Point(139, 64);
            this.TotalCat1Box.Name = "TotalCat1Box";
            this.TotalCat1Box.ReadOnly = true;
            this.TotalCat1Box.Size = new System.Drawing.Size(100, 20);
            this.TotalCat1Box.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Category 2";
            // 
            // NewFileButton
            // 
            this.NewFileButton.Location = new System.Drawing.Point(15, 157);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(224, 23);
            this.NewFileButton.TabIndex = 10;
            this.NewFileButton.Text = "Select New (*.txt*) File";
            this.NewFileButton.UseVisualStyleBackColor = true;
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // SaveResultsButton
            // 
            this.SaveResultsButton.Location = new System.Drawing.Point(15, 186);
            this.SaveResultsButton.Name = "SaveResultsButton";
            this.SaveResultsButton.Size = new System.Drawing.Size(224, 23);
            this.SaveResultsButton.TabIndex = 11;
            this.SaveResultsButton.Text = "Save Results to (*.txt*) File";
            this.SaveResultsButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text Files (*.txt*) |*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Files (*.txt*) |*.txt";
            // 
            // TextismWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 221);
            this.Controls.Add(this.SaveResultsButton);
            this.Controls.Add(this.NewFileButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalCat1Box);
            this.Controls.Add(this.AvgLengthBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalCat2Box);
            this.Controls.Add(this.TotalAbbrBox);
            this.Controls.Add(this.TotalWordsBox);
            this.Name = "TextismWindow";
            this.Text = "Textism Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TotalWordsBox;
        private System.Windows.Forms.TextBox TotalAbbrBox;
        private System.Windows.Forms.TextBox TotalCat2Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AvgLengthBox;
        private System.Windows.Forms.TextBox TotalCat1Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NewFileButton;
        private System.Windows.Forms.Button SaveResultsButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}


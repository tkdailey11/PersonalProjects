namespace FlashCardWindow
{
    partial class FlashCardWindow
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
            this.CardBox = new System.Windows.Forms.TextBox();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CardBox
            // 
            this.CardBox.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardBox.Location = new System.Drawing.Point(13, 13);
            this.CardBox.Multiline = true;
            this.CardBox.Name = "CardBox";
            this.CardBox.ReadOnly = true;
            this.CardBox.Size = new System.Drawing.Size(359, 276);
            this.CardBox.TabIndex = 0;
            // 
            // LeftButton
            // 
            this.LeftButton.Font = new System.Drawing.Font("Lucida Console", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.Location = new System.Drawing.Point(12, 295);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(182, 54);
            this.LeftButton.TabIndex = 1;
            this.LeftButton.Text = "<";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Font = new System.Drawing.Font("Lucida Console", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.Location = new System.Drawing.Point(200, 295);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(172, 55);
            this.RightButton.TabIndex = 2;
            this.RightButton.Text = ">";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // FlashCardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.CardBox);
            this.Name = "FlashCardWindow";
            this.Text = "Flash Card Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardBox;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
    }
}


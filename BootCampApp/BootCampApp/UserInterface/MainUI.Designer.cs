namespace BootCampApp.UserInterface
{
    partial class MainUI
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
            this.enrollButton = new System.Windows.Forms.Button();
            this.enterResultButton = new System.Windows.Forms.Button();
            this.showResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(80, 12);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(133, 58);
            this.enrollButton.TabIndex = 0;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // enterResultButton
            // 
            this.enterResultButton.Location = new System.Drawing.Point(80, 76);
            this.enterResultButton.Name = "enterResultButton";
            this.enterResultButton.Size = new System.Drawing.Size(133, 58);
            this.enterResultButton.TabIndex = 0;
            this.enterResultButton.Text = "Enter Result";
            this.enterResultButton.UseVisualStyleBackColor = true;
            this.enterResultButton.Click += new System.EventHandler(this.enterResultButton_Click);
            // 
            // showResultButton
            // 
            this.showResultButton.Location = new System.Drawing.Point(80, 140);
            this.showResultButton.Name = "showResultButton";
            this.showResultButton.Size = new System.Drawing.Size(133, 57);
            this.showResultButton.TabIndex = 0;
            this.showResultButton.Text = "Show Result";
            this.showResultButton.UseVisualStyleBackColor = true;
            this.showResultButton.Click += new System.EventHandler(this.showResultButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.showResultButton);
            this.Controls.Add(this.enterResultButton);
            this.Controls.Add(this.enrollButton);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Button enterResultButton;
        private System.Windows.Forms.Button showResultButton;
    }
}


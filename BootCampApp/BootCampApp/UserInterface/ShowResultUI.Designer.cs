namespace BootCampApp.UserInterface
{
    partial class ShowResultUI
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
            this.showResultDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showResultDataGridView
            // 
            this.showResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showResultDataGridView.Location = new System.Drawing.Point(12, 29);
            this.showResultDataGridView.Name = "showResultDataGridView";
            this.showResultDataGridView.Size = new System.Drawing.Size(430, 220);
            this.showResultDataGridView.TabIndex = 0;

            // 
            // ShowResultUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.showResultDataGridView);
            this.Name = "ShowResultUI";
            this.Text = "ShowResultUI";
            ((System.ComponentModel.ISupportInitialize)(this.showResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showResultDataGridView;
    }
}
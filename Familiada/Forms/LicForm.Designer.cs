namespace Familiada.Forms
{
    partial class LicForm
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
            this.LicTextBox = new System.Windows.Forms.TextBox();
            this.LicBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LicTextBox
            // 
            this.LicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LicTextBox.Location = new System.Drawing.Point(12, 12);
            this.LicTextBox.Name = "LicTextBox";
            this.LicTextBox.Size = new System.Drawing.Size(284, 29);
            this.LicTextBox.TabIndex = 0;
            // 
            // LicBtn
            // 
            this.LicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LicBtn.Location = new System.Drawing.Point(12, 47);
            this.LicBtn.Name = "LicBtn";
            this.LicBtn.Size = new System.Drawing.Size(284, 29);
            this.LicBtn.TabIndex = 1;
            this.LicBtn.Text = "Wprowadź klucz";
            this.LicBtn.UseVisualStyleBackColor = true;
            this.LicBtn.Click += new System.EventHandler(this.LicBtn_Click);
            // 
            // LicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 86);
            this.Controls.Add(this.LicBtn);
            this.Controls.Add(this.LicTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LicForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LicForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LicTextBox;
        private System.Windows.Forms.Button LicBtn;
    }
}
namespace IT_PROJECT
{
    partial class BorrowerInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowerInputForm));
            this.CancelButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.JustALabel = new System.Windows.Forms.Label();
            this.BorrowerInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CancelButton.Location = new System.Drawing.Point(12, 76);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ContinueButton.Location = new System.Drawing.Point(197, 76);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton.TabIndex = 1;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // JustALabel
            // 
            this.JustALabel.AutoSize = true;
            this.JustALabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.JustALabel.Location = new System.Drawing.Point(12, 19);
            this.JustALabel.Name = "JustALabel";
            this.JustALabel.Size = new System.Drawing.Size(121, 16);
            this.JustALabel.TabIndex = 2;
            this.JustALabel.Text = "Enter Borrower ID:";
            // 
            // BorrowerInputBox
            // 
            this.BorrowerInputBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BorrowerInputBox.Location = new System.Drawing.Point(12, 47);
            this.BorrowerInputBox.Name = "BorrowerInputBox";
            this.BorrowerInputBox.Size = new System.Drawing.Size(260, 23);
            this.BorrowerInputBox.TabIndex = 3;
            this.BorrowerInputBox.TextChanged += new System.EventHandler(this.BorrowerInputBox_TextChanged);
            // 
            // BorrowerInputForm
            // 
            this.AcceptButton = this.ContinueButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
#pragma warning disable CS1717 // Assignment made to same variable
            this.CancelButton = this.CancelButton;
#pragma warning restore CS1717 // Assignment made to same variable
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.BorrowerInputBox);
            this.Controls.Add(this.JustALabel);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.CancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BorrowerInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrower Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Label JustALabel;
        private System.Windows.Forms.TextBox BorrowerInputBox;
    }
}
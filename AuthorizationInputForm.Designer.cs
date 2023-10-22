namespace IT_PROJECT
{
    partial class AuthorizationInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationInputForm));
            this.JustALabel2 = new System.Windows.Forms.Label();
            this.AuthCodeBox = new System.Windows.Forms.TextBox();
            this.CancelButton2 = new System.Windows.Forms.Button();
            this.ContinueButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JustALabel2
            // 
            this.JustALabel2.AutoSize = true;
            this.JustALabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.JustALabel2.Location = new System.Drawing.Point(12, 19);
            this.JustALabel2.Name = "JustALabel2";
            this.JustALabel2.Size = new System.Drawing.Size(172, 16);
            this.JustALabel2.TabIndex = 0;
            this.JustALabel2.Text = "Enter Authorization Code:";
            // 
            // AuthCodeBox
            // 
            this.AuthCodeBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthCodeBox.Location = new System.Drawing.Point(12, 47);
            this.AuthCodeBox.Name = "AuthCodeBox";
            this.AuthCodeBox.Size = new System.Drawing.Size(260, 23);
            this.AuthCodeBox.TabIndex = 1;
            this.AuthCodeBox.TextChanged += new System.EventHandler(this.AuthCodeBox_TextChanged);
            // 
            // CancelButton2
            // 
            this.CancelButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CancelButton2.Location = new System.Drawing.Point(12, 76);
            this.CancelButton2.Name = "CancelButton2";
            this.CancelButton2.Size = new System.Drawing.Size(75, 23);
            this.CancelButton2.TabIndex = 2;
            this.CancelButton2.Text = "Cancel";
            this.CancelButton2.UseVisualStyleBackColor = true;
            this.CancelButton2.Click += new System.EventHandler(this.CancelButton2_Click);
            // 
            // ContinueButton2
            // 
            this.ContinueButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ContinueButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ContinueButton2.Location = new System.Drawing.Point(197, 76);
            this.ContinueButton2.Name = "ContinueButton2";
            this.ContinueButton2.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton2.TabIndex = 3;
            this.ContinueButton2.Text = "Continue";
            this.ContinueButton2.UseVisualStyleBackColor = true;
            this.ContinueButton2.Click += new System.EventHandler(this.ContinueButton2_Click);
            // 
            // AuthorizationInputForm
            // 
            this.AcceptButton = this.ContinueButton2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            this.CancelButton = this.CancelButton2;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.ContinueButton2);
            this.Controls.Add(this.CancelButton2);
            this.Controls.Add(this.AuthCodeBox);
            this.Controls.Add(this.JustALabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthorizationInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.AuthorizationInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JustALabel2;
        private System.Windows.Forms.TextBox AuthCodeBox;
        private System.Windows.Forms.Button CancelButton2;
        private System.Windows.Forms.Button ContinueButton2;
    }
}
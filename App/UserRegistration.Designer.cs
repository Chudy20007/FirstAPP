namespace App
{
    partial class UserRegistration
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
            this.UserLoginLabel = new System.Windows.Forms.Label();
            this.UserPasswordLabel = new System.Windows.Forms.Label();
            this.UserLoginTextBox = new System.Windows.Forms.TextBox();
            this.UserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLoginLabel
            // 
            this.UserLoginLabel.AutoSize = true;
            this.UserLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.UserLoginLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UserLoginLabel.Location = new System.Drawing.Point(22, 29);
            this.UserLoginLabel.Name = "UserLoginLabel";
            this.UserLoginLabel.Size = new System.Drawing.Size(44, 16);
            this.UserLoginLabel.TabIndex = 0;
            this.UserLoginLabel.Text = "Login:";
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.UserPasswordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UserPasswordLabel.Location = new System.Drawing.Point(22, 55);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(71, 16);
            this.UserPasswordLabel.TabIndex = 1;
            this.UserPasswordLabel.Text = "Password:";
            // 
            // UserLoginTextBox
            // 
            this.UserLoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.UserLoginTextBox.Location = new System.Drawing.Point(99, 25);
            this.UserLoginTextBox.Name = "UserLoginTextBox";
            this.UserLoginTextBox.Size = new System.Drawing.Size(100, 21);
            this.UserLoginTextBox.TabIndex = 2;
            // 
            // UserPasswordTextBox
            // 
            this.UserPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.UserPasswordTextBox.Location = new System.Drawing.Point(99, 51);
            this.UserPasswordTextBox.Name = "UserPasswordTextBox";
            this.UserPasswordTextBox.Size = new System.Drawing.Size(100, 21);
            this.UserPasswordTextBox.TabIndex = 3;
            this.UserPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UserCreate
            // 
            this.UserCreate.Location = new System.Drawing.Point(75, 78);
            this.UserCreate.Name = "UserCreate";
            this.UserCreate.Size = new System.Drawing.Size(75, 23);
            this.UserCreate.TabIndex = 4;
            this.UserCreate.Text = "Create";
            this.UserCreate.UseVisualStyleBackColor = true;
            this.UserCreate.Click += new System.EventHandler(this.UserCreate_Click);
            // 
            // UserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::App.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.UserCreate);
            this.Controls.Add(this.UserPasswordTextBox);
            this.Controls.Add(this.UserLoginTextBox);
            this.Controls.Add(this.UserPasswordLabel);
            this.Controls.Add(this.UserLoginLabel);
            this.MaximizeBox = false;
            this.Name = "UserRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRegistration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserRegistration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLoginLabel;
        private System.Windows.Forms.Label UserPasswordLabel;
        private System.Windows.Forms.TextBox UserLoginTextBox;
        private System.Windows.Forms.TextBox UserPasswordTextBox;
        private System.Windows.Forms.Button UserCreate;
    }
}
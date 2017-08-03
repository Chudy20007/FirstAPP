using System.Windows.Forms;

namespace App
{
    partial class Database_generator
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
            this.DatabaseNameTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseNameLabel = new System.Windows.Forms.Label();
            this.CreateDatabaseButton = new System.Windows.Forms.Button();
            this.IntegratedSecurityCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DatabaseNameTextBox
            // 
            this.DatabaseNameTextBox.Location = new System.Drawing.Point(431, 149);
            this.DatabaseNameTextBox.Name = "DatabaseNameTextBox";
            this.DatabaseNameTextBox.Size = new System.Drawing.Size(192, 20);
            this.DatabaseNameTextBox.TabIndex = 0;
            // 
            // DatabaseNameLabel
            // 
            this.DatabaseNameLabel.AutoSize = true;
            this.DatabaseNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.DatabaseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatabaseNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DatabaseNameLabel.Location = new System.Drawing.Point(428, 130);
            this.DatabaseNameLabel.Name = "DatabaseNameLabel";
            this.DatabaseNameLabel.Size = new System.Drawing.Size(118, 16);
            this.DatabaseNameLabel.TabIndex = 2;
            this.DatabaseNameLabel.Text = "Database name";
            // 
            // CreateDatabaseButton
            // 
            this.CreateDatabaseButton.BackgroundImage = global::App.Properties.Resources.create;
            this.CreateDatabaseButton.Image = global::App.Properties.Resources.build;
            this.CreateDatabaseButton.Location = new System.Drawing.Point(431, 297);
            this.CreateDatabaseButton.Name = "CreateDatabaseButton";
            this.CreateDatabaseButton.Size = new System.Drawing.Size(60, 60);
            this.CreateDatabaseButton.TabIndex = 3;
            this.CreateDatabaseButton.UseVisualStyleBackColor = true;
            this.CreateDatabaseButton.Click += new System.EventHandler(this.CreateDatabaseButton_Click);
            this.CreateDatabaseButton.MouseHover += new System.EventHandler(this.CreateDatabaseButton_MouseHover);
            // 
            // IntegratedSecurityCheckBox
            // 
            this.IntegratedSecurityCheckBox.AutoSize = true;
            this.IntegratedSecurityCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.IntegratedSecurityCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IntegratedSecurityCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.IntegratedSecurityCheckBox.Location = new System.Drawing.Point(431, 271);
            this.IntegratedSecurityCheckBox.Name = "IntegratedSecurityCheckBox";
            this.IntegratedSecurityCheckBox.Size = new System.Drawing.Size(155, 20);
            this.IntegratedSecurityCheckBox.TabIndex = 11;
            this.IntegratedSecurityCheckBox.Text = "Integrated security";
            this.IntegratedSecurityCheckBox.UseVisualStyleBackColor = false;
            this.IntegratedSecurityCheckBox.CheckedChanged += new System.EventHandler(this.IntegratedSecurityCheckBox_CheckedChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordLabel.Location = new System.Drawing.Point(428, 226);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 16);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginLabel.Location = new System.Drawing.Point(428, 181);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(46, 16);
            this.LoginLabel.TabIndex = 9;
            this.LoginLabel.Text = "Login";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(431, 245);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(192, 20);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(431, 200);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(192, 20);
            this.LoginTextBox.TabIndex = 7;
            // 
            // Database_generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.IntegratedSecurityCheckBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.CreateDatabaseButton);
            this.Controls.Add(this.DatabaseNameLabel);
            this.Controls.Add(this.DatabaseNameTextBox);
            this.Name = "Database_generator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database_generator";
            this.GenerateDatabaseToolTip = new System.Windows.Forms.ToolTip();
            this.GenerateDatabaseToolTip.SetToolTip(CreateDatabaseButton, "Create a DB");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DatabaseNameTextBox;
        private System.Windows.Forms.Label DatabaseNameLabel;
        private System.Windows.Forms.Button CreateDatabaseButton;
        private System.Windows.Forms.CheckBox IntegratedSecurityCheckBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private ToolTip GenerateDatabaseToolTip;
    }
}
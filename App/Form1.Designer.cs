using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace App
{
    partial class LoginForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DatabaseComboBox = new System.Windows.Forms.ComboBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.IntegratedSecurityCheckBox = new System.Windows.Forms.CheckBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.BuildButton = new System.Windows.Forms.Button();
            this.LoginToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RefreshToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BuildToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseComboBox
            // 
            this.DatabaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatabaseComboBox.FormattingEnabled = true;
            this.DatabaseComboBox.Location = new System.Drawing.Point(378, 269);
            this.DatabaseComboBox.Name = "DatabaseComboBox";
            this.DatabaseComboBox.Size = new System.Drawing.Size(192, 21);
            this.DatabaseComboBox.TabIndex = 0;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(378, 322);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(192, 20);
            this.LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(378, 367);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(192, 20);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.DatabaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatabaseLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DatabaseLabel.Location = new System.Drawing.Point(375, 250);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(76, 16);
            this.DatabaseLabel.TabIndex = 3;
            this.DatabaseLabel.Text = "Database";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginLabel.Location = new System.Drawing.Point(375, 303);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(46, 16);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordLabel.Location = new System.Drawing.Point(375, 348);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 16);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // IntegratedSecurityCheckBox
            // 
            this.IntegratedSecurityCheckBox.AutoSize = true;
            this.IntegratedSecurityCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.IntegratedSecurityCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IntegratedSecurityCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.IntegratedSecurityCheckBox.Location = new System.Drawing.Point(378, 394);
            this.IntegratedSecurityCheckBox.Name = "IntegratedSecurityCheckBox";
            this.IntegratedSecurityCheckBox.Size = new System.Drawing.Size(155, 20);
            this.IntegratedSecurityCheckBox.TabIndex = 6;
            this.IntegratedSecurityCheckBox.Text = "Integrated security";
            this.IntegratedSecurityCheckBox.UseVisualStyleBackColor = false;
            this.IntegratedSecurityCheckBox.CheckedChanged += new System.EventHandler(this.IntegratedSecurityCheckBox_CheckedChanged);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LogoLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LogoLabel.Location = new System.Drawing.Point(373, 210);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(157, 29);
            this.LogoLabel.TabIndex = 7;
            this.LogoLabel.Text = "ERP System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::App.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::App.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(378, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.BackgroundImage = global::App.Properties.Resources.login;
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginButton.ForeColor = System.Drawing.Color.Transparent;
            this.LoginButton.Location = new System.Drawing.Point(510, 449);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(60, 60);
            this.LoginButton.TabIndex = 9;
            this.LoginToolTip.SetToolTip(this.LoginButton, "Enter your login to log in");
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::App.Properties.Resources.refresh;
            this.RefreshButton.ForeColor = System.Drawing.Color.Transparent;
            this.RefreshButton.Location = new System.Drawing.Point(444, 449);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(60, 60);
            this.RefreshButton.TabIndex = 10;
            this.RefreshToolTip.SetToolTip(this.RefreshButton, "Refresh list of DB");
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // BuildButton
            // 
            this.BuildButton.BackgroundImage = global::App.Properties.Resources.build;
            this.BuildButton.ForeColor = System.Drawing.Color.Transparent;
            this.BuildButton.Location = new System.Drawing.Point(378, 449);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(60, 60);
            this.BuildButton.TabIndex = 11;
            this.BuildToolTip.SetToolTip(this.BuildButton, "Build DB");
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.IntegratedSecurityCheckBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.DatabaseLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.DatabaseComboBox);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ComboBox DatabaseComboBox;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label DatabaseLabel;
        private Label LoginLabel;
        private Label PasswordLabel;
        private CheckBox IntegratedSecurityCheckBox;
        private Label LogoLabel;
        private PictureBox pictureBox1;
        private Button LoginButton;
        private Button RefreshButton;
        private Button BuildButton;
        private ToolTip LoginToolTip;
        private ToolTip RefreshToolTip;
        private ToolTip BuildToolTip;
        
    }
}


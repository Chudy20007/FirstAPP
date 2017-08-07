namespace App
{
    partial class PositionRegistration
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
            this.PositionCreate = new System.Windows.Forms.Button();
            this.PositionNameTextBox = new System.Windows.Forms.TextBox();
            this.PositionNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PositionCreate
            // 
            this.PositionCreate.Location = new System.Drawing.Point(15, 66);
            this.PositionCreate.Name = "PositionCreate";
            this.PositionCreate.Size = new System.Drawing.Size(75, 23);
            this.PositionCreate.TabIndex = 9;
            this.PositionCreate.Text = "Create";
            this.PositionCreate.UseVisualStyleBackColor = true;
            this.PositionCreate.Click += new System.EventHandler(this.PositionCreate_Click);
            // 
            // PositionNameTextBox
            // 
            this.PositionNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PositionNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PositionNameTextBox.Location = new System.Drawing.Point(89, 22);
            this.PositionNameTextBox.Name = "PositionNameTextBox";
            this.PositionNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.PositionNameTextBox.TabIndex = 7;
            // 
            // PositionNameLabel
            // 
            this.PositionNameLabel.AutoSize = true;
            this.PositionNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PositionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.PositionNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PositionNameLabel.Location = new System.Drawing.Point(12, 26);
            this.PositionNameLabel.Name = "PositionNameLabel";
            this.PositionNameLabel.Size = new System.Drawing.Size(59, 16);
            this.PositionNameLabel.TabIndex = 5;
            this.PositionNameLabel.Text = "Position:";
            // 
            // PositionRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PositionCreate);
            this.Controls.Add(this.PositionNameTextBox);
            this.Controls.Add(this.PositionNameLabel);
            this.Name = "PositionRegistration";
            this.Text = "PositionRegistration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PositionRegistration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PositionCreate;
        private System.Windows.Forms.TextBox PositionNameTextBox;
        private System.Windows.Forms.Label PositionNameLabel;
    }
}
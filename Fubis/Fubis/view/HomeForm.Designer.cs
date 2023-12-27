﻿namespace Fubis
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.rentButton = new System.Windows.Forms.Button();
            this.deliverButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rentButton
            // 
            this.rentButton.BackColor = System.Drawing.Color.Transparent;
            this.rentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentButton.FlatAppearance.BorderSize = 0;
            this.rentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentButton.Location = new System.Drawing.Point(302, 403);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(420, 53);
            this.rentButton.TabIndex = 0;
            this.rentButton.UseVisualStyleBackColor = false;
            // 
            // deliverButton
            // 
            this.deliverButton.BackColor = System.Drawing.Color.Transparent;
            this.deliverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deliverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deliverButton.FlatAppearance.BorderSize = 0;
            this.deliverButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deliverButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deliverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deliverButton.Location = new System.Drawing.Point(302, 473);
            this.deliverButton.Name = "deliverButton";
            this.deliverButton.Size = new System.Drawing.Size(420, 54);
            this.deliverButton.TabIndex = 1;
            this.deliverButton.UseVisualStyleBackColor = false;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Location = new System.Drawing.Point(901, 21);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(30, 28);
            this.registerButton.TabIndex = 2;
            this.registerButton.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.deliverButton);
            this.Controls.Add(this.rentButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rentButton;
        private System.Windows.Forms.Button deliverButton;
        private System.Windows.Forms.Button registerButton;
    }
}


﻿namespace FlightReservationSys
{
    partial class main_form
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
            this.disconnected_button_id = new System.Windows.Forms.Button();
            this.crystal_button_id = new System.Windows.Forms.Button();
            this.connected_button_id = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disconnected_button_id
            // 
            this.disconnected_button_id.BackColor = System.Drawing.Color.Transparent;
            this.disconnected_button_id.Location = new System.Drawing.Point(357, 154);
            this.disconnected_button_id.Name = "disconnected_button_id";
            this.disconnected_button_id.Size = new System.Drawing.Size(87, 40);
            this.disconnected_button_id.TabIndex = 2;
            this.disconnected_button_id.Text = "disconnected";
            this.disconnected_button_id.UseVisualStyleBackColor = false;
            // 
            // crystal_button_id
            // 
            this.crystal_button_id.BackColor = System.Drawing.Color.Transparent;
            this.crystal_button_id.Location = new System.Drawing.Point(463, 154);
            this.crystal_button_id.Name = "crystal_button_id";
            this.crystal_button_id.Size = new System.Drawing.Size(87, 40);
            this.crystal_button_id.TabIndex = 3;
            this.crystal_button_id.Text = "crystal";
            this.crystal_button_id.UseVisualStyleBackColor = false;
            // 
            // connected_button_id
            // 
            this.connected_button_id.BackColor = System.Drawing.Color.Transparent;
            this.connected_button_id.FlatAppearance.BorderSize = 0;
            this.connected_button_id.Location = new System.Drawing.Point(250, 154);
            this.connected_button_id.Name = "connected_button_id";
            this.connected_button_id.Size = new System.Drawing.Size(87, 40);
            this.connected_button_id.TabIndex = 1;
            this.connected_button_id.Text = "connected";
            this.connected_button_id.UseVisualStyleBackColor = false;
            this.connected_button_id.Click += new System.EventHandler(this.connected_button_id_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystal_button_id);
            this.Controls.Add(this.disconnected_button_id);
            this.Controls.Add(this.connected_button_id);
            this.Name = "main_form";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_form_id_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button disconnected_button_id;
        private System.Windows.Forms.Button crystal_button_id;
        private System.Windows.Forms.Button connected_button_id;
    }
}


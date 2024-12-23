using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CourtManagement
{
    partial class FmMain
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClientCard = new System.Windows.Forms.Button();
            this.PanelFooter = new System.Windows.Forms.Panel();
            this.PanelMainMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnStormCourt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.button1);
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Controls.Add(this.BtnClientCard);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(131, 292);
            this.PanelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::CourtManagement.Properties.Resources.User128;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClientCard
            // 
            this.BtnClientCard.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnClientCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientCard.Location = new System.Drawing.Point(9, 95);
            this.BtnClientCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnClientCard.Name = "BtnClientCard";
            this.BtnClientCard.Size = new System.Drawing.Size(82, 34);
            this.BtnClientCard.TabIndex = 0;
            this.BtnClientCard.Text = "Karta członkowska\r\n";
            this.BtnClientCard.UseVisualStyleBackColor = false;
            // 
            // PanelFooter
            // 
            this.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelFooter.Location = new System.Drawing.Point(131, 267);
            this.PanelFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelFooter.Name = "PanelFooter";
            this.PanelFooter.Size = new System.Drawing.Size(339, 25);
            this.PanelFooter.TabIndex = 1;
            // 
            // PanelMainMenu
            // 
            this.PanelMainMenu.BackColor = System.Drawing.Color.DimGray;
            this.PanelMainMenu.Controls.Add(this.pictureBox2);
            this.PanelMainMenu.Controls.Add(this.BtnStormCourt);
            this.PanelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMainMenu.Location = new System.Drawing.Point(131, 0);
            this.PanelMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelMainMenu.Name = "PanelMainMenu";
            this.PanelMainMenu.Size = new System.Drawing.Size(339, 267);
            this.PanelMainMenu.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(15, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 94);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // BtnStormCourt
            // 
            this.BtnStormCourt.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnStormCourt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStormCourt.Location = new System.Drawing.Point(3, 15);
            this.BtnStormCourt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnStormCourt.Name = "BtnStormCourt";
            this.BtnStormCourt.Size = new System.Drawing.Size(164, 121);
            this.BtnStormCourt.TabIndex = 1;
            this.BtnStormCourt.Text = "Storm Court";
            this.BtnStormCourt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnStormCourt.UseVisualStyleBackColor = false;
            this.BtnStormCourt.Click += new System.EventHandler(this.BtnStormCourt_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(131, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 11);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(470, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMainMenu);
            this.Controls.Add(this.PanelFooter);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FmMain";
            this.Text = "FmMain";
            this.Load += new System.EventHandler(this.FmMain_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelFooter;
        private Panel PanelMainMenu;
        private Button BtnClientCard;
        private PictureBox pictureBox1;
        private Button BtnStormCourt;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button1;
    }
}
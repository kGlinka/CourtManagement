using System.Drawing;
using System.Windows.Forms;

namespace CourtManagement.Login
{
    partial class FmRegistration
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
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.lbZipCode = new System.Windows.Forms.Label();
            this.txbZipCode = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.lbStreet = new System.Windows.Forms.Label();
            this.txbStreet = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.PBUserImage = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txbLogin
            // 
            this.txbLogin.BackColor = System.Drawing.Color.Silver;
            this.txbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLogin.Location = new System.Drawing.Point(157, 10);
            this.txbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(125, 15);
            this.txbLogin.TabIndex = 0;
            this.txbLogin.Leave += new System.EventHandler(this.txbLogin_Leave);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(12, 7);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(123, 16);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Nazwa użytkownika\r\n";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(95, 30);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(46, 32);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Hasło\r\n\r\n";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.Silver;
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Location = new System.Drawing.Point(157, 30);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(125, 15);
            this.txbPassword.TabIndex = 1;
            this.txbPassword.Leave += new System.EventHandler(this.txbPassword_Leave);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(104, 51);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(32, 16);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Imię\r\n";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.Silver;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbName.Location = new System.Drawing.Point(157, 51);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(125, 15);
            this.txbName.TabIndex = 2;
            this.txbName.Leave += new System.EventHandler(this.txbName_Leave);
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(70, 72);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(65, 16);
            this.lbLastName.TabIndex = 7;
            this.lbLastName.Text = "Nazwisko\r\n";
            // 
            // txbLastName
            // 
            this.txbLastName.BackColor = System.Drawing.Color.Silver;
            this.txbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLastName.Location = new System.Drawing.Point(157, 72);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(125, 15);
            this.txbLastName.TabIndex = 3;
            this.txbLastName.Leave += new System.EventHandler(this.txbLastName_Leave);
            // 
            // lbZipCode
            // 
            this.lbZipCode.AutoSize = true;
            this.lbZipCode.Location = new System.Drawing.Point(10, 120);
            this.lbZipCode.Name = "lbZipCode";
            this.lbZipCode.Size = new System.Drawing.Size(90, 16);
            this.lbZipCode.TabIndex = 9;
            this.lbZipCode.Text = "Kod pocztowy\r\n";
            // 
            // txbZipCode
            // 
            this.txbZipCode.BackColor = System.Drawing.Color.Silver;
            this.txbZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbZipCode.Location = new System.Drawing.Point(120, 120);
            this.txbZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbZipCode.Name = "txbZipCode";
            this.txbZipCode.Size = new System.Drawing.Size(81, 15);
            this.txbZipCode.TabIndex = 4;
            this.txbZipCode.Leave += new System.EventHandler(this.txbZipCode_Leave);
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(207, 120);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(47, 16);
            this.lbCity.TabIndex = 11;
            this.lbCity.Text = "Miasto";
            // 
            // txbCity
            // 
            this.txbCity.BackColor = System.Drawing.Color.Silver;
            this.txbCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCity.Location = new System.Drawing.Point(267, 120);
            this.txbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(154, 15);
            this.txbCity.TabIndex = 5;
            this.txbCity.Leave += new System.EventHandler(this.txbCity_Leave);
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Location = new System.Drawing.Point(70, 141);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(38, 16);
            this.lbStreet.TabIndex = 13;
            this.lbStreet.Text = "Ulica";
            // 
            // txbStreet
            // 
            this.txbStreet.BackColor = System.Drawing.Color.Silver;
            this.txbStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbStreet.Location = new System.Drawing.Point(120, 141);
            this.txbStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.Size = new System.Drawing.Size(303, 15);
            this.txbStreet.TabIndex = 6;
            this.txbStreet.Leave += new System.EventHandler(this.txbStreet_Leave);
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(-1, 162);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(97, 16);
            this.lbPhoneNumber.TabIndex = 15;
            this.lbPhoneNumber.Text = "Numer telefonu";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(66, 182);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 16);
            this.lbEmail.TabIndex = 17;
            this.lbEmail.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEmail.BackColor = System.Drawing.Color.Silver;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmail.Location = new System.Drawing.Point(120, 182);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(222, 15);
            this.txbEmail.TabIndex = 8;
            this.txbEmail.Leave += new System.EventHandler(this.txbEmail_Leave);
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPhoneNumber.BackColor = System.Drawing.Color.Silver;
            this.txbPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPhoneNumber.Location = new System.Drawing.Point(120, 162);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(125, 15);
            this.txbPhoneNumber.TabIndex = 7;
            this.txbPhoneNumber.Leave += new System.EventHandler(this.txbPhoneNumber_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(305, 209);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 45);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PBUserImage
            // 
            this.PBUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PBUserImage.Image = global::CourtManagement.Properties.Resources.User128;
            this.PBUserImage.Location = new System.Drawing.Point(293, 7);
            this.PBUserImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PBUserImage.Name = "PBUserImage";
            this.PBUserImage.Size = new System.Drawing.Size(128, 128);
            this.PBUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PBUserImage.TabIndex = 20;
            this.PBUserImage.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.BackColor = System.Drawing.Color.Silver;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Location = new System.Drawing.Point(12, 209);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(116, 45);
            this.BtnCancel.TabIndex = 21;
            this.BtnCancel.Text = "Anuluj";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // FmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(428, 263);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.PBUserImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.txbPhoneNumber);
            this.Controls.Add(this.lbStreet);
            this.Controls.Add(this.txbStreet);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.lbZipCode);
            this.Controls.Add(this.txbZipCode);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.txbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FmRegistration";
            this.Text = "Rejestracja";
            ((System.ComponentModel.ISupportInitialize)(this.PBUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbLogin;
        private Label lbLogin;
        private Label lbPassword;
        private TextBox txbPassword;
        private Label lbName;
        private TextBox txbName;
        private Label lbLastName;
        private TextBox txbLastName;
        private Label lbZipCode;
        private TextBox txbZipCode;
        private Label lbCity;
        private TextBox txbCity;
        private Label lbStreet;
        private TextBox txbStreet;
        private Label lbPhoneNumber;
        private Label lbEmail;
        private TextBox txbEmail;
        private TextBox txbPhoneNumber;
        private Button btnSave;
        private PictureBox PBUserImage;
        private Button BtnCancel;
    }
}
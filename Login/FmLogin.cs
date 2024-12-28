using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtManagement.Login
{
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
        }

        

        private void txbLogin_Leave(object sender, EventArgs e)
        {
            if(!validateteLogin())
            {
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane", "Nazwa użytkownika");
            }
        }
         private bool validateteLogin()
          {
             if (txbLogin.Text.Length <= 0)
             {
                 txbLogin.BackColor = Color.PaleVioletRed;
                 return false;
             }
             else
             {
                 txbLogin.BackColor = Color.White;
                 return true;
             }
         }
        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (!validatePassword())
            {
                Fmtoast.AddToQueue("ERROR", "To pole jest wymagane", "Hasło");
            }
            
        }

        private bool validatePassword()
        {
            if (txbPassword.Text.Length <= 0)
            {
                txbPassword.BackColor = Color.PaleVioletRed;
                return false;
            }
            else
            {
                txbPassword.BackColor = Color.White;
                return true;
            }
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FmRegistration fmRegistration = new FmRegistration();
            fmRegistration.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((validateteLogin() || validatePassword()) == false)
            {
                Fmtoast.AddToQueue("ERROR", "Fromularz zawiera błędy", "Logowanie");
                return;
            }
            int? userRole = null, userId = null, clientId = null;
            string clientName = string.Empty, clientLastName = string.Empty;

            DsLoginTableAdapters.QueriesTableAdapter dsLoginQueriesTableAdapter = new DsLoginTableAdapters.QueriesTableAdapter();
            dsLoginQueriesTableAdapter.user_clientSelect(txbLogin.Text, txbPassword.Text, ref userRole, ref userId, ref clientId, ref clientName, ref clientLastName);
            if (userRole == null
                || userRole == 0)
            {
                Fmtoast.AddToQueue("ERROR", "Błędny login lub hasło", "logowanie");
                return;
            }

            SystemUser systemUser = new SystemUser()
            {
                UserId = userId.Value,
                UserRole = userRole.Value,
                ClientId = clientId.Value,
                ClientName = clientName,
                ClinetLastName = clientLastName
            };

            GlobalVariables.System_User = systemUser;

            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

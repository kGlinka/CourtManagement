using CourtManagement.Reservation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtManagement
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
        }

        private void BtnClientCard_Click(object sender, EventArgs e)
        {

        }

        private void BtnStormCourt_Click(object sender, EventArgs e)
        {
            FmReservation reservation = new FmReservation();
            reservation.Show();
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            button1.Visible = GlobalVariables.System_User.UserRole == 2 ? true : false; // 2 - rola administrator

        }
    }
}

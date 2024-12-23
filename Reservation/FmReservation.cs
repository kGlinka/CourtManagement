using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtManagement.Reservation
{
    public partial class FmReservation : Form
    {
        public FmReservation()
        {
            InitializeComponent();
        }

        private void FmReservation_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            string formattedDate = dateTimePickerReservation.Value.ToString("yyyy-MM-dd");
            this.reservationSelectByDateTableAdapter.Fill(this.dsReservation.reservationSelectByDate, DateTime.Parse(formattedDate));
            foreach (DataGridViewRow row in DgvReservation.Rows)
            {
                // Pobieramy wartości z kolumn za pomocą indeksów
                var isReserved = row.Cells[1].Value;  // Indeks 1 to kolumna "is_reserved"
                var clientId = row.Cells[2].Value;    // Indeks 2 to kolumna "id_client"

                // Sprawdzamy, czy rezerwacja jest ustawiona (is_reserved == 1)
                if (isReserved != null && Convert.ToInt32(isReserved) == 1)
                {
                    if (clientId != null && Convert.ToInt32(clientId) == GlobalVariables.System_User.UserId)
                    {
                        // Kolorujemy na zielono, jeśli rezerwacja należy do zalogowanego użytkownika
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        // Kolorujemy na czerwono, jeśli rezerwacja nie należy do zalogowanego użytkownika
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void dateTimePickerReservation_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void toolStripMenuItemAddReservation_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemDeleteReservation_Click(object sender, EventArgs e)
        {

        }
    }
}

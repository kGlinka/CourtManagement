using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CourtManagement.Reservation
{
    public partial class FmReservation : Form
    {
        private int idCourt {  get; set; }
        public FmReservation(int idCourt)
        {
            this.idCourt = idCourt;

            InitializeComponent();
        }

        private void FmReservation_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            //Poprawic dodac do procedury aby przyjmowała id kortu i aby selektowałą tylk orezerwacje dla tego kortu, nastepnie zaktualizowac dataset i dodac id ckortu tu w Fill(....
            this.reservationSelectByDateTableAdapter.Fill(this.dsReservation.reservationSelectByDate, dateTimePickerReservation.Value.ToString("yyyy-MM-dd"));
            foreach (DataGridViewRow row in DgvReservation.Rows)
            {
                // Pobieramy wartości z kolumn za pomocą indeksów
                var isReserved = row.Cells[1].Value;  // Indeks 1 to kolumna "is_reserved"
                var clientId = row.Cells[2].Value;    // Indeks 2 to kolumna "id_client"

                // Sprawdzamy, czy rezerwacja jest ustawiona (is_reserved == 1)
                if (isReserved != null && isReserved != DBNull.Value && Convert.ToInt32(isReserved) == 1)
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
            AddReservation();
        }

        private void toolStripMenuItemDeleteReservation_Click(object sender, EventArgs e)
        {

        }

        private void AddReservation()
        {
            if (DgvReservation.SelectedRows.Count == 0)
            {
                Fmtoast.AddToQueue("WARRNING", "Proszę zaznaczyć godziny rezerwacji.", "Rezerwacja");
                return;
            }

            // Sortujemy zaznaczone wiersze według widocznej kolejności
            var selectedRows = DgvReservation.SelectedRows
                .Cast<DataGridViewRow>()
                .OrderBy(row => row.Index)
                .ToList();

            // Sprawdzamy, czy w którymkolwiek zaznaczonym wierszu isReserved == 1
            foreach (var row in selectedRows)
            {
                var isReserved = row.Cells[1].Value; // Kolumna "is_reserved" (indeks 1)

                if (isReserved != null && isReserved != DBNull.Value && Convert.ToInt32(isReserved) == 1)
                {
                    Fmtoast.AddToQueue("WARRNING", "Ten termin jest już zajęty.", "Rezerwacja");
                    return;
                }
            }

            try
            {
                // Pobieramy pierwszy i ostatni wiersz
                var firstRow = selectedRows.First();
                var lastRow = selectedRows.Last();

                // Pobieramy wartości time_slot z pierwszego i ostatniego wiersza
                string firstTimeSlot = firstRow.Cells[0].Value?.ToString(); // Kolumna "time_slot" (indeks 0)
                string lastTimeSlot = lastRow.Cells[0].Value?.ToString();

                if (string.IsNullOrEmpty(firstTimeSlot) || string.IsNullOrEmpty(lastTimeSlot))
                {
                    Fmtoast.AddToQueue("WARRNING", "Błąd rezerwacji, spróbuj ponownie.", "Rezerwacja");
                    return;
                }

                // Tworzymy zmienne DateTime dla reservationStart i reservationEnd
                DateTime reservationStart = DateTime.ParseExact(
                    $"{DateTime.Now:yyyy-MM-dd} {firstTimeSlot}",
                    "yyyy-MM-dd HH:mm",
                    System.Globalization.CultureInfo.InvariantCulture
                );

                DateTime reservationEnd = DateTime.ParseExact(
                    $"{DateTime.Now:yyyy-MM-dd} {lastTimeSlot}",
                    "yyyy-MM-dd HH:mm",
                    System.Globalization.CultureInfo.InvariantCulture
                );

                using (var dsLoginQueriesTableAdapter = new DsReservationTableAdapters.QueriesTableAdapter())
                {
                    dsLoginQueriesTableAdapter.reservationInsert(
                        idCourt,
                        GlobalVariables.System_User.ClientId,
                        reservationStart,
                        reservationEnd
                    );
                }

                RefreshData();

                // Wyświetlamy komunikat sukcesu
                Fmtoast.AddToQueue("SUCCESS", "Dodano rezerwację.", "Rezerwacja");
            }
            catch (Exception ex)
            {
                Fmtoast.AddToQueue("WARRNING", "Błąd rezerwacji, spróbuj ponownie.", "Rezerwacja");
            }
        }
    }
}

using System.Drawing;

namespace CourtManagement.Reservation
{
    partial class FmReservation
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvReservation = new System.Windows.Forms.DataGridView();
            this.contextMenuStripReservation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteReservation = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDate = new System.Windows.Forms.Panel();
            this.dateTimePickerReservation = new System.Windows.Forms.DateTimePicker();
            this.reservationSelectByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReservation = new CourtManagement.Reservation.DsReservation();
            this.reservationSelectByDateTableAdapter = new CourtManagement.Reservation.DsReservationTableAdapters.reservationSelectByDateTableAdapter();
            this.time_slot_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isreservedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_slot_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservation)).BeginInit();
            this.contextMenuStripReservation.SuspendLayout();
            this.panelDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationSelectByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvReservation
            // 
            this.DgvReservation.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time_slot_from,
            this.isreservedDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn,
            this.id_reservation,
            this.time_slot_to});
            this.DgvReservation.ContextMenuStrip = this.contextMenuStripReservation;
            this.DgvReservation.DataSource = this.reservationSelectByDateBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvReservation.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvReservation.Location = new System.Drawing.Point(0, 60);
            this.DgvReservation.Name = "DgvReservation";
            this.DgvReservation.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvReservation.RowHeadersWidth = 51;
            this.DgvReservation.RowTemplate.Height = 24;
            this.DgvReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReservation.Size = new System.Drawing.Size(288, 390);
            this.DgvReservation.TabIndex = 0;
            // 
            // contextMenuStripReservation
            // 
            this.contextMenuStripReservation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddReservation,
            this.toolStripMenuItemDeleteReservation});
            this.contextMenuStripReservation.Name = "contextMenuStripReservation";
            this.contextMenuStripReservation.Size = new System.Drawing.Size(164, 48);
            this.contextMenuStripReservation.Text = "Dodaj rezerwacje";
            // 
            // toolStripMenuItemAddReservation
            // 
            this.toolStripMenuItemAddReservation.Name = "toolStripMenuItemAddReservation";
            this.toolStripMenuItemAddReservation.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItemAddReservation.Text = "Dodaj rezerwacje";
            this.toolStripMenuItemAddReservation.Click += new System.EventHandler(this.toolStripMenuItemAddReservation_Click);
            // 
            // toolStripMenuItemDeleteReservation
            // 
            this.toolStripMenuItemDeleteReservation.Name = "toolStripMenuItemDeleteReservation";
            this.toolStripMenuItemDeleteReservation.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItemDeleteReservation.Text = "Usuń rezerwację";
            this.toolStripMenuItemDeleteReservation.Click += new System.EventHandler(this.toolStripMenuItemDeleteReservation_Click);
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.dateTimePickerReservation);
            this.panelDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDate.Location = new System.Drawing.Point(0, 0);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(288, 60);
            this.panelDate.TabIndex = 1;
            // 
            // dateTimePickerReservation
            // 
            this.dateTimePickerReservation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerReservation.Location = new System.Drawing.Point(33, 22);
            this.dateTimePickerReservation.Name = "dateTimePickerReservation";
            this.dateTimePickerReservation.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReservation.TabIndex = 0;
            this.dateTimePickerReservation.ValueChanged += new System.EventHandler(this.dateTimePickerReservation_ValueChanged);
            // 
            // reservationSelectByDateBindingSource
            // 
            this.reservationSelectByDateBindingSource.DataMember = "reservationSelectByDate";
            this.reservationSelectByDateBindingSource.DataSource = this.dsReservation;
            // 
            // dsReservation
            // 
            this.dsReservation.DataSetName = "DsReservation";
            this.dsReservation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationSelectByDateTableAdapter
            // 
            this.reservationSelectByDateTableAdapter.ClearBeforeFill = true;
            // 
            // time_slot_from
            // 
            this.time_slot_from.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time_slot_from.DataPropertyName = "time_slot_from";
            this.time_slot_from.HeaderText = "Godzina od";
            this.time_slot_from.Name = "time_slot_from";
            this.time_slot_from.ReadOnly = true;
            // 
            // isreservedDataGridViewTextBoxColumn
            // 
            this.isreservedDataGridViewTextBoxColumn.DataPropertyName = "is_reserved";
            this.isreservedDataGridViewTextBoxColumn.HeaderText = "is_reserved";
            this.isreservedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isreservedDataGridViewTextBoxColumn.Name = "isreservedDataGridViewTextBoxColumn";
            this.isreservedDataGridViewTextBoxColumn.ReadOnly = true;
            this.isreservedDataGridViewTextBoxColumn.Visible = false;
            this.isreservedDataGridViewTextBoxColumn.Width = 125;
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "id_client";
            this.idclientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclientDataGridViewTextBoxColumn.Visible = false;
            this.idclientDataGridViewTextBoxColumn.Width = 125;
            // 
            // id_reservation
            // 
            this.id_reservation.DataPropertyName = "id_reservation";
            this.id_reservation.HeaderText = "id_reservation";
            this.id_reservation.Name = "id_reservation";
            this.id_reservation.ReadOnly = true;
            this.id_reservation.Visible = false;
            // 
            // time_slot_to
            // 
            this.time_slot_to.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time_slot_to.DataPropertyName = "time_slot_to";
            this.time_slot_to.HeaderText = "Godzina do";
            this.time_slot_to.Name = "time_slot_to";
            this.time_slot_to.ReadOnly = true;
            // 
            // FmReservation
            // 
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(288, 450);
            this.Controls.Add(this.DgvReservation);
            this.Controls.Add(this.panelDate);
            this.Name = "FmReservation";
            this.Text = "FmReservation";
            this.Load += new System.EventHandler(this.FmReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReservation)).EndInit();
            this.contextMenuStripReservation.ResumeLayout(false);
            this.panelDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationSelectByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvReservation;
        private System.Windows.Forms.BindingSource reservationSelectByDateBindingSource;
        private DsReservation dsReservation;
        private DsReservationTableAdapters.reservationSelectByDateTableAdapter reservationSelectByDateTableAdapter;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReservation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripReservation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddReservation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDeleteReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_slot_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn isreservedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_slot_to;
    }
}
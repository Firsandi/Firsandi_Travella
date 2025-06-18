using Firsandi_Travella.Interfaces;
using Firsandi_Travella.Models;
using Firsandi_Travella.Presenter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Firsandi_Travella.Views.V_Users
{
    public partial class V_Pemesanan : Form, IPemesananView
    {
        private PemesananPresenter _presenter;
        private PaketTripModels _paket;
        private int _userId = 2; // ganti sesuai sesi login

        private ComboBox comboMetode;
        private ComboBox comboBank;
        private PictureBox qrBox, gambarPaket;
        private Label lblRekening, lblDeskripsi;
        private DateTimePicker dateKeberangkatan;

        public V_Pemesanan(PaketTripModels paket)
        {
            InitializeComponent();
            _paket = paket;

            this.Text = "Form Pemesanan";
            this.Size = new Size(600, 660);
            this.StartPosition = FormStartPosition.CenterScreen;

            _presenter = new PemesananPresenter(this);
            InisialisasiKomponen();
            _presenter.LoadMetodePembayaran();

        }

        private void InisialisasiKomponen()
        {
            var lblNama = new Label { Text = $"📦 {_paket.Nama}", Font = new Font("Segoe UI", 11, FontStyle.Bold), Location = new Point(30, 20), AutoSize = true };
            lblDeskripsi = new Label
            {
                Text = _paket.Deskripsi,
                Location = new Point(30, 50),
                Size = new Size(300, 60),
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray
            };
            var lblHarga = new Label
            {
                Text = $"💰 Harga: Rp {_paket.Harga:N0}",
                Location = new Point(30, 115),
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                ForeColor = Color.DarkGreen
            };

            var lblTanggal = new Label { Text = "Tanggal Keberangkatan:", Location = new Point(30, 165), AutoSize = true };
            dateKeberangkatan = new DateTimePicker { Location = new Point(250, 160), Format = DateTimePickerFormat.Short };

            var lblMetode = new Label { Text = "Metode Pembayaran:", Location = new Point(30, 205), AutoSize = true };
            comboMetode = new ComboBox { Location = new Point(250, 200), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            comboMetode.SelectedIndexChanged += ComboMetode_SelectedIndexChanged;

            var lblBank = new Label { Text = "Bank Transfer:", Location = new Point(30, 245), AutoSize = true };
            comboBank = new ComboBox { Location = new Point(250, 240), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
            comboBank.Visible = false; lblBank.Visible = false;

            lblRekening = new Label
            {
                Text = "",
                Location = new Point(250, 275),
                AutoSize = true,
                ForeColor = Color.DarkBlue,
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                Visible = false
            };

            qrBox = new PictureBox
            {
                Location = new Point(250, 310),
                Size = new Size(200, 200),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Visible = false
            };

            var btnPesan = new Button
            {
                Text = "Pesan Sekarang",
                Location = new Point(180, 540),
                Size = new Size(220, 45),
                BackColor = Color.ForestGreen,
                ForeColor = Color.White
            };
            btnPesan.Click += BtnPesan_Click;

            Controls.AddRange(new Control[] {
                gambarPaket, lblNama, lblDeskripsi, lblHarga,
                lblTanggal, dateKeberangkatan,
                lblMetode, comboMetode,
                lblBank, comboBank, lblRekening,
                qrBox, btnPesan
            });

            lblBank.Name = "lblBank";
        }

        private void ComboMetode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMetode.SelectedItem is MetodePembayaranModels metode)
            {
                if (metode.Jenis.ToLower() == "transfer")
                {
                    comboBank.Visible = true;
                    Controls["lblBank"].Visible = true;
                    lblRekening.Visible = false;
                    qrBox.Visible = false;
                    _presenter.AmbilDaftarBank(metode.Id);

                    comboBank.SelectedIndexChanged += (s, ev) =>
                    {
                        if (comboBank.SelectedItem is BankTransferModels bank)
                        {
                            lblRekening.Text = $"No. Rekening: {bank.NomorRekening}";
                            lblRekening.Visible = true;
                        }
                    };
                }
                else if (metode.Jenis.ToLower() == "qris")
                {
                    comboBank.Visible = false;
                    Controls["lblBank"].Visible = false;
                    lblRekening.Visible = false;
                    qrBox.Visible = true;
                    qrBox.ImageLocation = $"https://yourcdn.com/qris/{metode.Id}.png";
                }
            }
        }

        private void BtnPesan_Click(object sender, EventArgs e)
        {
            var model = new PemesananModels
            {
                UserId = _userId,
                PaketId = _paket.Id,
                GuideId = _paket.GuideId,
                TanggalKeberangkatan = dateKeberangkatan.Value,
                MetodeId = (int)comboMetode.SelectedValue,
                StatusPemesanan = "Menunggu Pembayaran"
            };

            _presenter.SubmitPemesanan(model);
            this.Hide();
        }

        public void TampilkanMetode(List<MetodePembayaranModels> metodeList)
        {
            comboMetode.DataSource = metodeList;
            comboMetode.DisplayMember = "Nama";
            comboMetode.ValueMember = "Id";
        }

        public void TampilkanDaftarBank(List<BankTransferModels> bankList)
        {
            comboBank.DataSource = bankList;
            comboBank.DisplayMember = "NamaBank";
            comboBank.ValueMember = "NomorRekening";
        }

        public void ShowSuccess(string msg) => MessageBox.Show(msg, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public void ShowError(string msg) => MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
        public void CloseForm() => this.Close();
    }
}

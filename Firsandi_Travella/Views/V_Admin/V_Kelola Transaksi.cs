using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Firsandi_Travella.Models;
using Firsandi_Travella.Interfaces;
using Firsandi_Travella.Presenter;

namespace Travella_TA.Views.V_Admin
{
    public partial class V_Kelola_Transaksi : Form, ITransaksiView
    {
        private readonly TransaksiPresenter _presenter;
        private FlowLayoutPanel flowPanel;

        public V_Kelola_Transaksi()
        {
            InitializeComponent();
            this.Text = "📋 Kelola Transaksi Pengguna";
            this.Size = new Size(950, 580);
            this.StartPosition = FormStartPosition.CenterScreen;

            flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(10)
            };

            this.Controls.Add(flowPanel);

            _presenter = new TransaksiPresenter(this);
            _presenter.TampilkanSemuaTransaksiAdmin();
        }

        public void TampilkanTransaksiAdmin(List<TransaksiModels> data)
        {
            flowPanel.Controls.Clear();

            foreach (var trx in data)
            {
                Panel card = new Panel
                {
                    Size = new Size(860, 120),
                    BackColor = Color.WhiteSmoke,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    Padding = new Padding(10)
                };


                Label lblUser = new Label
                {
                    Text = $"👤 Pengguna ID: {trx.UserId}",
                    Location = new Point(10, 35),
                    AutoSize = true
                };

                Label lblJumlah = new Label
                {
                    Text = $"💰 Jumlah: Rp {trx.Jumlah:N0}",
                    Location = new Point(10, 55),
                    AutoSize = true
                };

            

                Label lblStatus = new Label
                {
                    Text = $"📌 Status: {trx.Status}",
                    Location = new Point(300, 10),
                    AutoSize = true,
                    ForeColor = trx.Status.ToLower().Contains("menunggu") ? Color.OrangeRed : Color.ForestGreen
                };

                Button btnKonfirmasi = new Button
                {
                    Text = "✅ Konfirmasi",
                    Size = new Size(130, 35),
                    Location = new Point(700, 30),
                    BackColor = Color.ForestGreen,
                    ForeColor = Color.White,
                    Visible = trx.Status.ToLower().Contains("menunggu"),
                    Tag = trx.TransaksiId
                };
                btnKonfirmasi.Click += BtnKonfirmasi_Click;

                //card.Controls.Add(lblPaket);
                card.Controls.Add(lblUser);
                card.Controls.Add(lblJumlah);
                //card.Controls.Add(lblMetode);
                card.Controls.Add(lblStatus);
                card.Controls.Add(btnKonfirmasi);

                flowPanel.Controls.Add(card);
            }
        }

        private void BtnKonfirmasi_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            int transaksiId = (int)btn.Tag;

            var confirm = MessageBox.Show("Konfirmasi transaksi ini?", "Verifikasi", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _presenter.KonfirmasiTransaksi(transaksiId);
                this.Hide();
            }
        }

        public void TampilkanRiwayatTransaksi(List<TransaksiModels> _) { }
        public void ShowSuccess(string msg) => MessageBox.Show(msg, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public void ShowError(string msg) => MessageBox.Show(msg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void Kembali_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin v_DashboardAdmin = new V_DashboardAdmin();
            v_DashboardAdmin.Show();
            this.Hide();
        }
    }
}

using Firsandi_Travella.Interfaces;
using Firsandi_Travella.Models;
using Firsandi_Travella.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travella_TA.Views;

namespace Firsandi_Travella.Views.V_Admin
{
    public partial class V_KelolaGuide : Form, IGuideView
    {
        private readonly GuidePresenter _presenter;
        private FlowLayoutPanel flowLayoutPanelGuides;

        public V_KelolaGuide()
        {
            InitializeComponent();

            flowLayoutPanelGuides = new FlowLayoutPanel
            {
                Dock = DockStyle.None,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                //Size = new Size(100, 100),
                Location = new Point(400, 180) // 🔥 Posisi lebih ke kanan
            };

            this.Controls.Add(flowLayoutPanelGuides);

            _presenter = new GuidePresenter(this);
            _presenter.LoadGuides();
        }

        public void ShowGuides(List<GuideModels> guides)
        {
            flowLayoutPanelGuides.Controls.Clear();

            foreach (var guide in guides)
            {
                Panel card = new Panel
                {
                    Size = new Size(600, 100),
                    BackColor = Color.FromArgb(173, 205, 255),
                    Padding = new Padding(10),
                    Margin = new Padding(15),
                    BorderStyle = BorderStyle.FixedSingle,
                    //Left = 1300
                };

                Label lblNama = new Label
                {
                    Text = guide.Nama,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    AutoSize = true,    
                    Location = new Point(15, 50)

                };

                Label lblKontak = new Label
                {
                    Text = $"📞 {guide.Kontak}",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                    Location = new Point(10, 30)

                };

                Button btnEdit = new Button
                {
                    Text = "Edit",
                    Tag = guide,
                    Location = new Point(450, 20),

                };
                btnEdit.Click += BtnEdit_Click;

                Button btnDelete = new Button
                {
                    Text = "🗑",
                    Tag = guide,
                    Location = new Point(520, 20),

                };
                btnDelete.Click += BtnDelete_Click;

               
                card.Controls.Add(lblNama);
                card.Controls.Add(lblKontak);
                card.Controls.Add(btnEdit);
                card.Controls.Add(btnDelete);

                flowLayoutPanelGuides.Controls.Add(card);
            }
            //flowLayoutPanelGuides.Left = (this.ClientSize.Width - flowLayoutPanelGuides.Width) / 2;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var guide = (GuideModels)((Button)sender).Tag;
            V_EditGuide editGuide = new V_EditGuide();
            if (editGuide.ShowDialog() == DialogResult.OK)
            {
                _presenter.LoadGuides();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var guide = (GuideModels)((Button)sender).Tag;
            var confirm = MessageBox.Show($"Yakin ingin menghapus guide {guide.Nama}?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _presenter.DeleteGuide(guide.Id);
                _presenter.LoadGuides();
            }
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TambahGuide_Click(object sender, EventArgs e)
        {
            V_TambahkanGuide v_TambahGuide = new V_TambahkanGuide();
            v_TambahGuide.Show();
            this.Hide();
        }

        private void Beranda_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin v_DashboardAdmin = new V_DashboardAdmin();
            v_DashboardAdmin.Show();
            this.Hide();
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin v_DashboardAdmin = new V_DashboardAdmin();
            v_DashboardAdmin.Show();
            this.Hide();
        }
    }
}

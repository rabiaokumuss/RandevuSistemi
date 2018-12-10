using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randevu_Sistemi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Form5 frm5 = new Form5();

        private void Form4_Load(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Form2 frm2 = (Form2)Application.OpenForms["Form2"];
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];

            lblHosgeldinizAciklama.Text = "Sn.  " + frm1.ad + " " + frm1.soyad + ", e-randevu sistemine hoşgeldiniz.";


            monthCalendar_randevuTarihleri.MinDate = DateTime.Now;
            monthCalendar_randevuTarihleri.MaxDate = new DateTime(2021, 12, 31);

            DateTime frm3deSecilenTarih = frm3.monthCalendar_randevuTarihleri.SelectionStart.Date;

            lblTarih1.Text = frm3deSecilenTarih.ToLongDateString();
            lblTarih2.Text = frm3deSecilenTarih.ToLongDateString();

            if (DateTime.Compare(frm3.monthCalendar_randevuTarihleri.SelectionRange.Start, DateTime.Today.Date) == 1)
                monthCalendar_randevuTarihleri.SelectionStart = frm3.monthCalendar_randevuTarihleri.SelectionStart;

          
        }

        private void picBoxGeri_Click(object sender, EventArgs e)
        {
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];

            this.Visible = false;

            frm3.Refresh();
            frm3.Visible = true;
        }

        private void picBoxBölüm_Click(object sender, EventArgs e)
        {
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];

            frm5.lblBransAdi1.Text = lblBransAdi1.Text;

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
                frm5.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hs.";  
            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
                frm5.lblBransAdi2.Text = "Plastik ve Estetik Cerra.";
            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
                frm5.lblBransAdi2.Text = "Kadın Hast. ve Doğum";
            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
                frm5.lblBransAdi2.Text = "Endokronoloji ve Metab.";
            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
                frm5.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";
            else
                frm5.lblBransAdi2.Text = lblBransAdi2.Text;


            frm5.picBoxSaatDokuz.Visible = true;
            frm5.lblSaatDokuz.Visible = true;
            frm5.picBoxSaatDokuzBucuk.Visible = true;
            frm5.lblSaatDokuzBucuk.Visible = true;

            frm5.picBoxSaatOn.Visible = true;
            frm5.lblSaatOn.Visible = true;
            frm5.picBoxSaatOnBucuk.Visible = true;
            frm5.lblSaatOnBucuk.Visible = true;

            frm5.picBoxSaatOnBir.Visible = true;
            frm5.lblSaatOnBir.Visible = true;
            frm5.picBoxSaatOnBirBucuk.Visible = true;
            frm5.lblSaatOnBirBucuk.Visible = true;


            frm5.picBoxSaatOnİki.Visible = true;
            frm5.lblSaatOnİki.Visible = true;
            frm5.picBoxSaatOnİkiOtuz.Visible = true;
            frm5.lblSaatOnİkiBucuk.Visible = true;

            frm5.picBoxSaatOnUc.Visible = true;
            frm5.lblSaatOnUc.Visible = true;
            frm5.picBoxSaatOnUcOtuz.Visible = true;
            frm5.lblSaatOnUcOtuz.Visible = true;

            frm5.picBoxSaatOnDört.Visible = true;
            frm5.lblSaatOnDört.Visible = true;
            frm5.picBoxSaatOnDörtOtuz.Visible = true;
            frm5.lblSaatOnDörtOtuz.Visible = true;

            frm5.picBoxSaatOnBes.Visible = true;
            frm5.lblSaatOnBes.Visible = true;
            frm5.picBoxSaatOnBesOtuz.Visible = true;
            frm5.lblSaatOnBesOtuz.Visible = true;

            frm5.picBoxSaatOnAltı.Visible = true;
            frm5.lblSaatOnAltı.Visible = true;

            this.Refresh();
            frm3.Refresh();

            this.Visible = false;

            frm5.ShowDialog();

        }

        private void btnRandevularım_Click(object sender, EventArgs e)
        {
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];

            this.Refresh();
            frm3.Refresh();

            this.Visible = false;

            Form frm8 = new Form8();

            frm8.ShowDialog();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

            Application.Restart();
        }

        private void btnRandevularım_MouseMove(object sender, MouseEventArgs e)
        {
            btnRandevularım.BackColor = SystemColors.WindowFrame;
        }

        private void btnRandevularım_MouseLeave(object sender, EventArgs e)
        {
            btnRandevularım.BackColor = Color.Orange;
        }

        private void btnCikis_MouseMove(object sender, MouseEventArgs e)
        {
            btnCikis.BackColor = SystemColors.WindowFrame;
       
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.BackColor = Color.Orange;
        }
    }
}

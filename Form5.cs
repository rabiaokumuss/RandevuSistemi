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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        Form6 frm6 = new Form6();

        private void Form5_Load(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Form2 frm2 = (Form2)Application.OpenForms["Form2"];
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            lblHosgeldinizAciklama.Text = "Sn.  " + frm1.ad + " " + frm1.soyad + ", e-randevu sistemine hoşgeldiniz.";


            monthCalendar_randevuTarihleri.MinDate = DateTime.Now;
            monthCalendar_randevuTarihleri.MaxDate = new DateTime(2021, 12, 31);

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;

            lblTarih1.Text = frm4deSecilenTarih.ToLongDateString();
            lblTarih2.Text = frm4deSecilenTarih.ToLongDateString();

            if (DateTime.Compare(frm4.monthCalendar_randevuTarihleri.SelectionRange.Start, DateTime.Today.Date) == 1)
                monthCalendar_randevuTarihleri.SelectionStart = frm4.monthCalendar_randevuTarihleri.SelectionStart;


            SqlConnection sqlConn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\DBHastaneRandevuSistemiOtomasyonu.mdf; Integrated Security = True;");

            sqlConn.Open();


            #region Polikliniklerin Saat Ayarlamaları

            #region Beyin ve Sinir Cerrahisi Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Beyin ve Sinir\nCerrahisi")
            {
                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucBeyinveSinirCerrahisi = (int)sqlCommSaatDokuzBeyinveSinirCerrahisi.ExecuteScalar();

                if (saatDokuzSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatDokuzBucukBeyinveSinirCerrahisi.ExecuteScalar();

                if (saatDokuzBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnBucukBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnBirBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnBirSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnBirBucukBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnBirBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnİkiBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnİkiSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnİkiBucukBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnİkiBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnUcBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnUcSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnUcBucukBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnUcBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnDörtBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnDörtSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnDörtBucukBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnDörtBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnBesBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnBesSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnBesOtuzBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnBesOtuzSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnAltıBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnAltıSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Kardiyoloji Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Kardiyoloji")
            {
                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucKardiyoloji = (int)sqlCommSaatDokuzKardiyoloji.ExecuteScalar();

                if (saatDokuzSonucKardiyoloji >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucKardiyoloji = (int)sqlCommSaatDokuzBucukKardiyoloji.ExecuteScalar();

                if (saatDokuzBucukSonucKardiyoloji >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucKardiyoloji = (int)sqlCommSaatOnKardiyoloji.ExecuteScalar();

                if (SaatOnSonucKardiyoloji >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucKardiyoloji = (int)sqlCommSaatOnBucukKardiyoloji.ExecuteScalar();

                if (SaatOnBucukSonucKardiyoloji >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucKardiyoloji = (int)sqlCommSaatOnBirKardiyoloji.ExecuteScalar();

                if (SaatOnBirSonucKardiyoloji >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucKardiyoloji = (int)sqlCommSaatOnBirBucukKardiyoloji.ExecuteScalar();

                if (SaatOnBirBucukSonucKardiyoloji >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucKardiyoloji = (int)sqlCommSaatOnİkiKardiyoloji.ExecuteScalar();

                if (SaatOnİkiSonucKardiyoloji >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucKardiyoloji = (int)sqlCommSaatOnİkiBucukKardiyoloji.ExecuteScalar();

                if (SaatOnİkiBucukSonucKardiyoloji >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucKardiyoloji = (int)sqlCommSaatOnUcKardiyoloji.ExecuteScalar();

                if (SaatOnUcSonucKardiyoloji >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucKardiyoloji = (int)sqlCommSaatOnUcBucukKardiyoloji.ExecuteScalar();

                if (SaatOnUcBucukSonucKardiyoloji >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucKardiyoloji = (int)sqlCommSaatOnDörtKardiyoloji.ExecuteScalar();

                if (SaatOnDörtSonucKardiyoloji >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucKardiyoloji = (int)sqlCommSaatOnDörtBucukKardiyoloji.ExecuteScalar();

                if (SaatOnDörtBucukSonucKardiyoloji >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucKardiyoloji = (int)sqlCommSaatOnBesKardiyoloji.ExecuteScalar();

                if (SaatOnBesSonucKardiyoloji >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucKardiyoloji = (int)sqlCommSaatOnBesOtuzKardiyoloji.ExecuteScalar();

                if (SaatOnBesOtuzSonucKardiyoloji >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıKardiyoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kardiyoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucKardiyoloji = (int)sqlCommSaatOnAltıKardiyoloji.ExecuteScalar();

                if (SaatOnAltıSonucKardiyoloji >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion

            }

            #endregion

            #region Nöroloji Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Nöroloji")
            {

                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucNöroloji = (int)sqlCommSaatDokuzNöroloji.ExecuteScalar();

                if (saatDokuzSonucNöroloji >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucNöroloji = (int)sqlCommSaatDokuzBucukNöroloji.ExecuteScalar();

                if (saatDokuzBucukSonucNöroloji >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucNöroloji = (int)sqlCommSaatOnNöroloji.ExecuteScalar();

                if (SaatOnSonucNöroloji >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucNöroloji = (int)sqlCommSaatOnBucukNöroloji.ExecuteScalar();

                if (SaatOnBucukSonucNöroloji >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucNöroloji = (int)sqlCommSaatOnBirNöroloji.ExecuteScalar();

                if (SaatOnBirSonucNöroloji >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucNöroloji = (int)sqlCommSaatOnBirBucukNöroloji.ExecuteScalar();

                if (SaatOnBirBucukSonucNöroloji >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucNöroloji = (int)sqlCommSaatOnİkiNöroloji.ExecuteScalar();

                if (SaatOnİkiSonucNöroloji >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucNöroloji = (int)sqlCommSaatOnİkiBucukNöroloji.ExecuteScalar();

                if (SaatOnİkiBucukSonucNöroloji >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucNöroloji = (int)sqlCommSaatOnUcNöroloji.ExecuteScalar();

                if (SaatOnUcSonucNöroloji >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucNöroloji = (int)sqlCommSaatOnUcBucukNöroloji.ExecuteScalar();

                if (SaatOnUcBucukSonucNöroloji >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucNöroloji = (int)sqlCommSaatOnDörtNöroloji.ExecuteScalar();

                if (SaatOnDörtSonucNöroloji >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucNöroloji = (int)sqlCommSaatOnDörtBucukNöroloji.ExecuteScalar();

                if (SaatOnDörtBucukSonucNöroloji >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucNöroloji = (int)sqlCommSaatOnBesNöroloji.ExecuteScalar();

                if (SaatOnBesSonucNöroloji >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucNöroloji = (int)sqlCommSaatOnBesOtuzNöroloji.ExecuteScalar();

                if (SaatOnBesOtuzSonucNöroloji >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıNöroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nöroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucNöroloji = (int)sqlCommSaatOnAltıNöroloji.ExecuteScalar();

                if (SaatOnAltıSonucNöroloji >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Psikiyatri Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Psikiyatri")
            {

                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucPsikiyatri = (int)sqlCommSaatDokuzPsikiyatri.ExecuteScalar();

                if (saatDokuzSonucPsikiyatri >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucPsikiyatri = (int)sqlCommSaatDokuzBucukPsikiyatri.ExecuteScalar();

                if (saatDokuzBucukSonucPsikiyatri >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucPsikiyatri = (int)sqlCommSaatOnPsikiyatri.ExecuteScalar();

                if (SaatOnSonucPsikiyatri >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucPsikiyatri = (int)sqlCommSaatOnBucukPsikiyatri.ExecuteScalar();

                if (SaatOnBucukSonucPsikiyatri >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucPsikiyatri = (int)sqlCommSaatOnBirPsikiyatri.ExecuteScalar();

                if (SaatOnBirSonucPsikiyatri >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucPsikiyatri = (int)sqlCommSaatOnBirBucukPsikiyatri.ExecuteScalar();

                if (SaatOnBirBucukSonucPsikiyatri >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucPsikiyatri = (int)sqlCommSaatOnİkiPsikiyatri.ExecuteScalar();

                if (SaatOnİkiSonucPsikiyatri >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucPsikiyatri = (int)sqlCommSaatOnİkiBucukPsikiyatri.ExecuteScalar();

                if (SaatOnİkiBucukSonucPsikiyatri >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucPsikiyatri = (int)sqlCommSaatOnUcPsikiyatri.ExecuteScalar();

                if (SaatOnUcSonucPsikiyatri >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucPsikiyatri = (int)sqlCommSaatOnUcBucukPsikiyatri.ExecuteScalar();

                if (SaatOnUcBucukSonucPsikiyatri >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucPsikiyatri = (int)sqlCommSaatOnDörtPsikiyatri.ExecuteScalar();

                if (SaatOnDörtSonucPsikiyatri >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucPsikiyatri = (int)sqlCommSaatOnDörtBucukPsikiyatri.ExecuteScalar();

                if (SaatOnDörtBucukSonucPsikiyatri >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucPsikiyatri = (int)sqlCommSaatOnBesPsikiyatri.ExecuteScalar();

                if (SaatOnBesSonucPsikiyatri >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucPsikiyatri = (int)sqlCommSaatOnBesOtuzPsikiyatri.ExecuteScalar();

                if (SaatOnBesOtuzSonucPsikiyatri >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıPsikiyatri = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Psikiyatri' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucPsikiyatri = (int)sqlCommSaatOnAltıPsikiyatri.ExecuteScalar();

                if (SaatOnAltıSonucPsikiyatri >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region İç Hastalıkları Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "İç Hastalıkları")
            {

                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucİcHastaliklari = (int)sqlCommSaatDokuzİcHastaliklari.ExecuteScalar();

                if (saatDokuzSonucİcHastaliklari >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucİcHastaliklari = (int)sqlCommSaatDokuzBucukİcHastaliklari.ExecuteScalar();

                if (saatDokuzBucukSonucİcHastaliklari >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucİcHastaliklari = (int)sqlCommSaatOnİcHastaliklari.ExecuteScalar();

                if (SaatOnSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucİcHastaliklari = (int)sqlCommSaatOnBucukİcHastaliklari.ExecuteScalar();

                if (SaatOnBucukSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucİcHastaliklari = (int)sqlCommSaatOnBirİcHastaliklari.ExecuteScalar();

                if (SaatOnBirSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucİcHastaliklari = (int)sqlCommSaatOnBirBucukİcHastaliklari.ExecuteScalar();

                if (SaatOnBirBucukSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucİcHastaliklari = (int)sqlCommSaatOnİkiİcHastaliklari.ExecuteScalar();

                if (SaatOnİkiSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucİcHastaliklari = (int)sqlCommSaatOnİkiBucukİcHastaliklari.ExecuteScalar();

                if (SaatOnİkiBucukSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucİcHastaliklari = (int)sqlCommSaatOnUcİcHastaliklari.ExecuteScalar();

                if (SaatOnUcSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucİcHastaliklari = (int)sqlCommSaatOnUcBucukİcHastaliklari.ExecuteScalar();

                if (SaatOnUcBucukSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucİcHastaliklari = (int)sqlCommSaatOnDörtİcHastaliklari.ExecuteScalar();

                if (SaatOnDörtSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucİcHastaliklari = (int)sqlCommSaatOnDörtBucukİcHastaliklari.ExecuteScalar();

                if (SaatOnDörtBucukSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucİcHastaliklari = (int)sqlCommSaatOnBesİcHastaliklari.ExecuteScalar();

                if (SaatOnBesSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucİcHastaliklari = (int)sqlCommSaatOnBesOtuzİcHastaliklari.ExecuteScalar();

                if (SaatOnBesOtuzSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'İç Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucİcHastaliklari = (int)sqlCommSaatOnAltıİcHastaliklari.ExecuteScalar();

                if (SaatOnAltıSonucİcHastaliklari >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Göz Hastalıkları Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Göz Hastalıkları")
            {
                
                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucGözHastaliklari = (int)sqlCommSaatDokuzGözHastaliklari.ExecuteScalar();

                if (saatDokuzSonucGözHastaliklari >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucGözHastaliklari = (int)sqlCommSaatDokuzBucukGözHastaliklari.ExecuteScalar();

                if (saatDokuzBucukSonucGözHastaliklari >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucGözHastaliklari = (int)sqlCommSaatOnGözHastaliklari.ExecuteScalar();

                if (SaatOnSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucGözHastaliklari = (int)sqlCommSaatOnBucukGözHastaliklari.ExecuteScalar();

                if (SaatOnBucukSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucGözHastaliklari = (int)sqlCommSaatOnBirGözHastaliklari.ExecuteScalar();

                if (SaatOnBirSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucGözHastaliklari = (int)sqlCommSaatOnBirBucukGözHastaliklari.ExecuteScalar();

                if (SaatOnBirBucukSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucGözHastaliklari = (int)sqlCommSaatOnİkiGözHastaliklari.ExecuteScalar();

                if (SaatOnİkiSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucGözHastaliklari = (int)sqlCommSaatOnİkiBucukGözHastaliklari.ExecuteScalar();

                if (SaatOnİkiBucukSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucGözHastaliklari = (int)sqlCommSaatOnUcGözHastaliklari.ExecuteScalar();

                if (SaatOnUcSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucGözHastaliklari = (int)sqlCommSaatOnUcBucukGözHastaliklari.ExecuteScalar();

                if (SaatOnUcBucukSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucGözHastaliklari = (int)sqlCommSaatOnDörtGözHastaliklari.ExecuteScalar();

                if (SaatOnDörtSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucGözHastaliklari = (int)sqlCommSaatOnDörtBucukGözHastaliklari.ExecuteScalar();

                if (SaatOnDörtBucukSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucGözHastaliklari = (int)sqlCommSaatOnBesGözHastaliklari.ExecuteScalar();

                if (SaatOnBesSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucGözHastaliklari = (int)sqlCommSaatOnBesOtuzGözHastaliklari.ExecuteScalar();

                if (SaatOnBesOtuzSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucGözHastaliklari = (int)sqlCommSaatOnAltıGözHastaliklari.ExecuteScalar();

                if (SaatOnAltıSonucGözHastaliklari >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Kulak-Burun-Boğaz Hastalıkları Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Kulak-Burun-Boğaz\nHastalıkları")
            {

                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucKulakBurunBoğaz = (int)sqlCommSaatDokuzKulakBurunBogaz.ExecuteScalar();

                if (saatDokuzSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucKulakBurunBoğaz = (int)sqlCommSaatDokuzBucukKulakBurunBogaz.ExecuteScalar();

                if (saatDokuzBucukSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucKulakBurunBoğaz = (int)sqlCommSaatOnKulakBurunBogaz.ExecuteScalar();

                if (SaatOnSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucKulakBurunBoğaz = (int)sqlCommSaatOnBucukKulakBurunBogaz.ExecuteScalar();

                if (SaatOnBucukSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucKulakBurunBoğaz = (int)sqlCommSaatOnBirKulakBurunBogaz.ExecuteScalar();

                if (SaatOnBirSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucKulakBurunBoğaz = (int)sqlCommSaatOnBirBucukKulakBurunBogaz.ExecuteScalar();

                if (SaatOnBirBucukSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucKulakBurunBoğaz = (int)sqlCommSaatOnİkiKulakBurunBogaz.ExecuteScalar();

                if (SaatOnİkiSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucKulakBurunBoğaz = (int)sqlCommSaatOnİkiBucukKulakBurunBogaz.ExecuteScalar();

                if (SaatOnİkiBucukSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucKulakBurunBoğaz = (int)sqlCommSaatOnUcKulakBurunBogaz.ExecuteScalar();

                if (SaatOnUcSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucKulakBurunBoğaz = (int)sqlCommSaatOnUcBucukKulakBurunBogaz.ExecuteScalar();

                if (SaatOnUcBucukSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucKulakBurunBoğaz = (int)sqlCommSaatOnDörtKulakBurunBogaz.ExecuteScalar();

                if (SaatOnDörtSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucKulakBurunBoğaz = (int)sqlCommSaatOnDörtBucukKulakBurunBogaz.ExecuteScalar();

                if (SaatOnDörtBucukSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucKulakBurunBoğaz = (int)sqlCommSaatOnBesKulakBurunBogaz.ExecuteScalar();

                if (SaatOnBesSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucKulakBurunBoğaz = (int)sqlCommSaatOnBesOtuzKulakBurunBogaz.ExecuteScalar();

                if (SaatOnBesOtuzSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucKulakBurunBoğaz = (int)sqlCommSaatOnAltıKulakBurunBogaz.ExecuteScalar();

                if (SaatOnAltıSonucKulakBurunBoğaz >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Göğüs Hastalıkları Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Göğüs Hastalıkları")
            {
                
                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucGögüs = (int)sqlCommSaatDokuzGögüs.ExecuteScalar();

                if (saatDokuzSonucGögüs >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucGögüs = (int)sqlCommSaatDokuzBucukGögüs.ExecuteScalar();

                if (saatDokuzBucukSonucGögüs >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucGögüs = (int)sqlCommSaatOnGögüs.ExecuteScalar();

                if (SaatOnSonucGögüs >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucGögüs = (int)sqlCommSaatOnBucukGögüs.ExecuteScalar();

                if (SaatOnBucukSonucGögüs >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucGögüs = (int)sqlCommSaatOnBirGögüs.ExecuteScalar();

                if (SaatOnBirSonucGögüs >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucGögüs = (int)sqlCommSaatOnBirBucukGögüs.ExecuteScalar();

                if (SaatOnBirBucukSonucGögüs >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucGögüs = (int)sqlCommSaatOnİkiGögüs.ExecuteScalar();

                if (SaatOnİkiSonucGögüs >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucGögüs = (int)sqlCommSaatOnİkiBucukGögüs.ExecuteScalar();

                if (SaatOnİkiBucukSonucGögüs >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucGögüs = (int)sqlCommSaatOnUcGögüs.ExecuteScalar();

                if (SaatOnUcSonucGögüs >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucGögüs = (int)sqlCommSaatOnUcBucukGögüs.ExecuteScalar();

                if (SaatOnUcBucukSonucGögüs >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucGögüs = (int)sqlCommSaatOnDörtGögüs.ExecuteScalar();

                if (SaatOnDörtSonucGögüs >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucGögüs = (int)sqlCommSaatOnDörtBucukGögüs.ExecuteScalar();

                if (SaatOnDörtBucukSonucGögüs >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucGögüs = (int)sqlCommSaatOnBesGögüs.ExecuteScalar();

                if (SaatOnBesSonucGögüs >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucGögüs = (int)sqlCommSaatOnBesOtuzGögüs.ExecuteScalar();

                if (SaatOnBesOtuzSonucGögüs >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıGögüs = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Göğüs Hastalıkları' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucGögüs = (int)sqlCommSaatOnAltıGögüs.ExecuteScalar();

                if (SaatOnAltıSonucGögüs >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Kalp ve Damar Cerrahisi Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Kalp ve Damar\nCerrahisi")
            {
                
                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucKalpveDamar = (int)sqlCommSaatDokuzKalpveDamar.ExecuteScalar();

                if (saatDokuzSonucKalpveDamar >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukKalpveDamar  = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucKalpveDamar = (int)sqlCommSaatDokuzBucukKalpveDamar.ExecuteScalar();

                if (saatDokuzBucukSonucKalpveDamar >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucKalpveDamar = (int)sqlCommSaatOnKalpveDamar.ExecuteScalar();

                if (SaatOnSonucKalpveDamar >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucKalpveDamar = (int)sqlCommSaatOnBucukKalpveDamar.ExecuteScalar();

                if (SaatOnBucukSonucKalpveDamar >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucKalpveDamar = (int)sqlCommSaatOnBirKalpveDamar.ExecuteScalar();

                if (SaatOnBirSonucKalpveDamar >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucKalpveDamar = (int)sqlCommSaatOnBirBucukKalpveDamar.ExecuteScalar();

                if (SaatOnBirBucukSonucKalpveDamar >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucKalpveDamar = (int)sqlCommSaatOnİkiKalpveDamar.ExecuteScalar();

                if (SaatOnİkiSonucKalpveDamar >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucKalpveDamar = (int)sqlCommSaatOnİkiBucukKalpveDamar.ExecuteScalar();

                if (SaatOnİkiBucukSonucKalpveDamar >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucKalpveDamar = (int)sqlCommSaatOnUcKalpveDamar.ExecuteScalar();

                if (SaatOnUcSonucKalpveDamar >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucKalpveDamar = (int)sqlCommSaatOnUcBucukKalpveDamar.ExecuteScalar();

                if (SaatOnUcBucukSonucKalpveDamar >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucKalpveDamar = (int)sqlCommSaatOnDörtKalpveDamar.ExecuteScalar();

                if (SaatOnDörtSonucKalpveDamar >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucKalpveDamar = (int)sqlCommSaatOnDörtBucukKalpveDamar.ExecuteScalar();

                if (SaatOnDörtBucukSonucKalpveDamar >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucKalpveDamar = (int)sqlCommSaatOnBesKalpveDamar.ExecuteScalar();

                if (SaatOnBesSonucKalpveDamar >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucKalpveDamar = (int)sqlCommSaatOnBesOtuzKalpveDamar.ExecuteScalar();

                if (SaatOnBesOtuzSonucKalpveDamar >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıKalpveDamar = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kalp ve Damar Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucKalpveDamar = (int)sqlCommSaatOnAltıKalpveDamar.ExecuteScalar();

                if (SaatOnAltıSonucKalpveDamar >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Gastroenteroloji Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Gastroenteroloji")
            {

                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucGastroenteroloji = (int)sqlCommSaatDokuzGastroenteroloji.ExecuteScalar();

                if (saatDokuzSonucGastroenteroloji >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucGastroenteroloji = (int)sqlCommSaatDokuzBucukGastroenteroloji.ExecuteScalar();

                if (saatDokuzBucukSonucGastroenteroloji >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucGastroenteroloji = (int)sqlCommSaatOnGastroenteroloji.ExecuteScalar();

                if (SaatOnSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucGastroenteroloji = (int)sqlCommSaatOnBucukGastroenteroloji.ExecuteScalar();

                if (SaatOnBucukSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucGastroenteroloji = (int)sqlCommSaatOnBirGastroenteroloji.ExecuteScalar();

                if (SaatOnBirSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucGastroenteroloji = (int)sqlCommSaatOnBirBucukGastroenteroloji.ExecuteScalar();

                if (SaatOnBirBucukSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucGastroenteroloji = (int)sqlCommSaatOnİkiGastroenteroloji.ExecuteScalar();

                if (SaatOnİkiSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucGastroenteroloji = (int)sqlCommSaatOnİkiBucukGastroenteroloji.ExecuteScalar();

                if (SaatOnİkiBucukSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucGastroenteroloji = (int)sqlCommSaatOnUcGastroenteroloji.ExecuteScalar();

                if (SaatOnUcSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucGastroenteroloji = (int)sqlCommSaatOnUcBucukGastroenteroloji.ExecuteScalar();

                if (SaatOnUcBucukSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucGastroenteroloji = (int)sqlCommSaatOnDörtGastroenteroloji.ExecuteScalar();

                if (SaatOnDörtSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucGastroenteroloji = (int)sqlCommSaatOnDörtBucukGastroenteroloji.ExecuteScalar();

                if (SaatOnDörtBucukSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucGastroenteroloji = (int)sqlCommSaatOnBesGastroenteroloji.ExecuteScalar();

                if (SaatOnBesSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucGastroenteroloji = (int)sqlCommSaatOnBesOtuzGastroenteroloji.ExecuteScalar();

                if (SaatOnBesOtuzSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Gastroenteroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucGastroenteroloji = (int)sqlCommSaatOnAltıGastroenteroloji.ExecuteScalar();

                if (SaatOnAltıSonucGastroenteroloji >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Plastik ve Estetik Cerrahisi Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Plastik ve Estetik\nCerrahisi")
            {
                
                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucPlastikveEstetik = (int)sqlCommSaatDokuzPlastikveEstetik.ExecuteScalar();

                if (saatDokuzSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucPlastikveEstetik = (int)sqlCommSaatDokuzBucukPlastikveEstetik.ExecuteScalar();

                if (saatDokuzBucukSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucPlastikveEstetik = (int)sqlCommSaatOnPlastikveEstetik.ExecuteScalar();

                if (SaatOnSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucPlastikveEstetik = (int)sqlCommSaatOnBucukPlastikveEstetik.ExecuteScalar();

                if (SaatOnBucukSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucPlastikveEstetik = (int)sqlCommSaatOnBirPlastikveEstetik.ExecuteScalar();

                if (SaatOnBirSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucPlastikveEstetik = (int)sqlCommSaatOnBirBucukPlastikveEstetik.ExecuteScalar();

                if (SaatOnBirBucukSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucPlastikveEstetik = (int)sqlCommSaatOnİkiPlastikveEstetik.ExecuteScalar();

                if (SaatOnİkiSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucPlastikveEstetik = (int)sqlCommSaatOnİkiBucukPlastikveEstetik.ExecuteScalar();

                if (SaatOnİkiBucukSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucPlastikveEstetik = (int)sqlCommSaatOnUcPlastikveEstetik.ExecuteScalar();

                if (SaatOnUcSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucPlastikveEstetik = (int)sqlCommSaatOnUcBucukPlastikveEstetik.ExecuteScalar();

                if (SaatOnUcBucukSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucPlastikveEstetik = (int)sqlCommSaatOnDörtPlastikveEstetik.ExecuteScalar();

                if (SaatOnDörtSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucPlastikveEstetik = (int)sqlCommSaatOnDörtBucukPlastikveEstetik.ExecuteScalar();

                if (SaatOnDörtBucukSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucPlastikveEstetik = (int)sqlCommSaatOnBesPlastikveEstetik.ExecuteScalar();

                if (SaatOnBesSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucPlastikveEstetik = (int)sqlCommSaatOnBesOtuzPlastikveEstetik.ExecuteScalar();

                if (SaatOnBesOtuzSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Plastik ve Estetik Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucPlastikveEstetik = (int)sqlCommSaatOnAltıPlastikveEstetik.ExecuteScalar();

                if (SaatOnAltıSonucPlastikveEstetik >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Kadın Hastalıkları ve Doğum Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Kadın Hastalıkları\nve Doğum")
            {

                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucKadinHastaliklariveDogum = (int)sqlCommSaatDokuzKadinHastaliklariveDogum.ExecuteScalar();

                if (saatDokuzSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucKadinHastaliklariveDogum = (int)sqlCommSaatDokuzBucukKadinHastaliklariveDogum.ExecuteScalar();

                if (saatDokuzBucukSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnBucukKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnBucukSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnBirKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnBirSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnBirBucukKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnBirBucukSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnİkiKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnİkiSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnİkiBucukKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnİkiBucukSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnUcKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnUcSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnUcBucukKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnUcBucukSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnDörtKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnDörtSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnDörtBucukKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnDörtBucukSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnBesKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnBesSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnBesOtuzKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnBesOtuzSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Kadın Hastalıkları ve Doğum' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucKadinHastaliklariveDogum = (int)sqlCommSaatOnAltıKadinHastaliklariveDogum.ExecuteScalar();

                if (SaatOnAltıSonucKadinHastaliklariveDogum >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Endokronoloji ve Metabolizma Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Endokronoloji ve\nMetabolizma")
            {
                
                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucEndokronolojiveMetabolizma = (int)sqlCommSaatDokuzEndokronolojiveMetabolizma.ExecuteScalar();

                if (saatDokuzSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucEndokronolojiveMetabolizma = (int)sqlCommSaatDokuzBucukEndokronolojiveMetabolizma.ExecuteScalar();

                if (saatDokuzBucukSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnBucukEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnBucukSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnBirEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnBirSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnBirBucukEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnBirBucukSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnİkiEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnİkiSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukEndokronolojiveMetabolizma  = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnİkiBucukEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnİkiBucukSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnUcEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnUcSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnUcBucukEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnUcBucukSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnDörtEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnDörtSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnDörtBucukEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnDörtBucukSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnBesEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnBesSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnBesOtuzEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnBesOtuzSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Endokronoloji ve Metabolizma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucEndokronolojiveMetabolizma = (int)sqlCommSaatOnAltıEndokronolojiveMetabolizma.ExecuteScalar();

                if (SaatOnAltıSonucEndokronolojiveMetabolizma >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Dermatoloji Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Dermatoloji")
            {

                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucDermatoloji = (int)sqlCommSaatDokuzDermatoloji.ExecuteScalar();

                if (saatDokuzSonucDermatoloji >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucDermatoloji = (int)sqlCommSaatDokuzBucukDermatoloji.ExecuteScalar();

                if (saatDokuzBucukSonucDermatoloji >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucDermatoloji = (int)sqlCommSaatOnDermatoloji.ExecuteScalar();

                if (SaatOnSonucDermatoloji >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucDermatoloji = (int)sqlCommSaatOnBucukDermatoloji.ExecuteScalar();

                if (SaatOnBucukSonucDermatoloji >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucDermatoloji = (int)sqlCommSaatOnBirDermatoloji.ExecuteScalar();

                if (SaatOnBirSonucDermatoloji >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucDermatoloji = (int)sqlCommSaatOnBirBucukDermatoloji.ExecuteScalar();

                if (SaatOnBirBucukSonucDermatoloji >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucDermatoloji = (int)sqlCommSaatOnİkiDermatoloji.ExecuteScalar();

                if (SaatOnİkiSonucDermatoloji >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucDermatoloji = (int)sqlCommSaatOnİkiBucukDermatoloji.ExecuteScalar();

                if (SaatOnİkiBucukSonucDermatoloji >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucDermatoloji = (int)sqlCommSaatOnUcDermatoloji.ExecuteScalar();

                if (SaatOnUcSonucDermatoloji >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucDermatoloji = (int)sqlCommSaatOnUcBucukDermatoloji.ExecuteScalar();

                if (SaatOnUcBucukSonucDermatoloji >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucDermatoloji = (int)sqlCommSaatOnDörtDermatoloji.ExecuteScalar();

                if (SaatOnDörtSonucDermatoloji >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucDermatoloji = (int)sqlCommSaatOnDörtBucukDermatoloji.ExecuteScalar();

                if (SaatOnDörtBucukSonucDermatoloji >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucDermatoloji = (int)sqlCommSaatOnBesDermatoloji.ExecuteScalar();

                if (SaatOnBesSonucDermatoloji >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucDermatoloji = (int)sqlCommSaatOnBesOtuzDermatoloji.ExecuteScalar();

                if (SaatOnBesOtuzSonucDermatoloji >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıDermatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Dermatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucDermatoloji = (int)sqlCommSaatOnAltıDermatoloji.ExecuteScalar();

                if (SaatOnAltıSonucDermatoloji >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Ortopedi ve Travma Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Ortopedi ve\nTravma")
            {
                
                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucOrtopediveTravma = (int)sqlCommSaatDokuzOrtopediveTravma.ExecuteScalar();

                if (saatDokuzSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucOrtopediveTravma = (int)sqlCommSaatDokuzBucukOrtopediveTravma.ExecuteScalar();

                if (saatDokuzBucukSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucOrtopediveTravma = (int)sqlCommSaatOnOrtopediveTravma.ExecuteScalar();

                if (SaatOnSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucOrtopediveTravma = (int)sqlCommSaatOnBucukOrtopediveTravma.ExecuteScalar();

                if (SaatOnBucukSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucOrtopediveTravma = (int)sqlCommSaatOnBirOrtopediveTravma.ExecuteScalar();

                if (SaatOnBirSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucOrtopediveTravma = (int)sqlCommSaatOnBirBucukOrtopediveTravma.ExecuteScalar();

                if (SaatOnBirBucukSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucOrtopediveTravma = (int)sqlCommSaatOnİkiOrtopediveTravma.ExecuteScalar();

                if (SaatOnİkiSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucOrtopediveTravma = (int)sqlCommSaatOnİkiBucukOrtopediveTravma.ExecuteScalar();

                if (SaatOnİkiBucukSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucOrtopediveTravma = (int)sqlCommSaatOnUcOrtopediveTravma.ExecuteScalar();

                if (SaatOnUcSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucOrtopediveTravma = (int)sqlCommSaatOnUcBucukOrtopediveTravma.ExecuteScalar();

                if (SaatOnUcBucukSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucOrtopediveTravma = (int)sqlCommSaatOnDörtOrtopediveTravma.ExecuteScalar();

                if (SaatOnDörtSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucOrtopediveTravma = (int)sqlCommSaatOnDörtBucukOrtopediveTravma.ExecuteScalar();

                if (SaatOnDörtBucukSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucOrtopediveTravma = (int)sqlCommSaatOnBesOrtopediveTravma.ExecuteScalar();

                if (SaatOnBesSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucOrtopediveTravma = (int)sqlCommSaatOnBesOtuzOrtopediveTravma.ExecuteScalar();

                if (SaatOnBesOtuzSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Ortopedi ve Travma' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucOrtopediveTravma = (int)sqlCommSaatOnAltıOrtopediveTravma.ExecuteScalar();

                if (SaatOnAltıSonucOrtopediveTravma >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Fiziksel Tıp ve Rehabilitasyon Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Fiziksel Tıp ve\nRehabilitasyon")
            {
                
                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatDokuzFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (saatDokuzSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatDokuzBucukFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (saatDokuzBucukSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnBucukFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnBucukSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnBirFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnBirSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnBirBucukFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnBirBucukSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnİkiFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnİkiSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnİkiBucukFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnİkiBucukSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnUcFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnUcSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnUcBucukFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnUcBucukSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnDörtFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnDörtSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnDörtBucukFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnDörtBucukSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnBesFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnBesSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnBesOtuzFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnBesOtuzSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucFizikselTıpveRehabilitasyon = (int)sqlCommSaatOnAltıFizikselTıpveRehabilitasyon.ExecuteScalar();

                if (SaatOnAltıSonucFizikselTıpveRehabilitasyon >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Nefroloji Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Nefroloji")
            {

                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucNefroloji = (int)sqlCommSaatDokuzNefroloji.ExecuteScalar();

                if (saatDokuzSonucNefroloji >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucNefroloji = (int)sqlCommSaatDokuzBucukNefroloji.ExecuteScalar();

                if (saatDokuzBucukSonucNefroloji >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucNefroloji = (int)sqlCommSaatOnNefroloji.ExecuteScalar();

                if (SaatOnSonucNefroloji >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucNefroloji = (int)sqlCommSaatOnBucukNefroloji.ExecuteScalar();

                if (SaatOnBucukSonucNefroloji >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucNefroloji = (int)sqlCommSaatOnBirNefroloji.ExecuteScalar();

                if (SaatOnBirSonucNefroloji >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucNefroloji = (int)sqlCommSaatOnBirBucukNefroloji.ExecuteScalar();

                if (SaatOnBirBucukSonucNefroloji >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucNefroloji = (int)sqlCommSaatOnİkiNefroloji.ExecuteScalar();

                if (SaatOnİkiSonucNefroloji >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucNefroloji = (int)sqlCommSaatOnİkiBucukNefroloji.ExecuteScalar();

                if (SaatOnİkiBucukSonucNefroloji >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucNefroloji = (int)sqlCommSaatOnUcNefroloji.ExecuteScalar();

                if (SaatOnUcSonucNefroloji >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucNefroloji = (int)sqlCommSaatOnUcBucukNefroloji.ExecuteScalar();

                if (SaatOnUcBucukSonucNefroloji >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucNefroloji = (int)sqlCommSaatOnDörtNefroloji.ExecuteScalar();

                if (SaatOnDörtSonucNefroloji >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucNefroloji = (int)sqlCommSaatOnDörtBucukNefroloji.ExecuteScalar();

                if (SaatOnDörtBucukSonucNefroloji >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucNefroloji = (int)sqlCommSaatOnBesNefroloji.ExecuteScalar();

                if (SaatOnBesSonucNefroloji >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucNefroloji = (int)sqlCommSaatOnBesOtuzNefroloji.ExecuteScalar();

                if (SaatOnBesOtuzSonucNefroloji >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıNefroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Nefroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucNefroloji = (int)sqlCommSaatOnAltıNefroloji.ExecuteScalar();

                if (SaatOnAltıSonucNefroloji >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion   

            #region Hematoloji Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Hematoloji")
            {

                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucHematoloji = (int)sqlCommSaatDokuzHematoloji.ExecuteScalar();

                if (saatDokuzSonucHematoloji >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucHematoloji = (int)sqlCommSaatDokuzBucukHematoloji.ExecuteScalar();

                if (saatDokuzBucukSonucHematoloji >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucHematoloji = (int)sqlCommSaatOnHematoloji.ExecuteScalar();

                if (SaatOnSonucHematoloji >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucHematoloji = (int)sqlCommSaatOnBucukHematoloji.ExecuteScalar();

                if (SaatOnBucukSonucHematoloji >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucHematoloji = (int)sqlCommSaatOnBirHematoloji.ExecuteScalar();

                if (SaatOnBirSonucHematoloji >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucHematoloji = (int)sqlCommSaatOnBirBucukHematoloji.ExecuteScalar();

                if (SaatOnBirBucukSonucHematoloji >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucHematoloji = (int)sqlCommSaatOnİkiHematoloji.ExecuteScalar();

                if (SaatOnİkiSonucHematoloji >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucHematoloji = (int)sqlCommSaatOnİkiBucukHematoloji.ExecuteScalar();

                if (SaatOnİkiBucukSonucHematoloji >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucHematoloji = (int)sqlCommSaatOnUcHematoloji.ExecuteScalar();

                if (SaatOnUcSonucHematoloji >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucHematoloji = (int)sqlCommSaatOnUcBucukHematoloji.ExecuteScalar();

                if (SaatOnUcBucukSonucHematoloji >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucHematoloji = (int)sqlCommSaatOnDörtHematoloji.ExecuteScalar();

                if (SaatOnDörtSonucHematoloji >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucHematoloji = (int)sqlCommSaatOnDörtBucukHematoloji.ExecuteScalar();

                if (SaatOnDörtBucukSonucHematoloji >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucHematoloji = (int)sqlCommSaatOnBesHematoloji.ExecuteScalar();

                if (SaatOnBesSonucHematoloji >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucHematoloji = (int)sqlCommSaatOnBesOtuzHematoloji.ExecuteScalar();

                if (SaatOnBesOtuzSonucHematoloji >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıHematoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Hematoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucHematoloji = (int)sqlCommSaatOnAltıHematoloji.ExecuteScalar();

                if (SaatOnAltıSonucHematoloji >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Romatoloji Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Romatoloji")
            {

                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucRomatoloji = (int)sqlCommSaatDokuzRomatoloji.ExecuteScalar();

                if (saatDokuzSonucRomatoloji >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucRomatoloji = (int)sqlCommSaatDokuzBucukRomatoloji.ExecuteScalar();

                if (saatDokuzBucukSonucRomatoloji >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucRomatoloji = (int)sqlCommSaatOnRomatoloji.ExecuteScalar();

                if (SaatOnSonucRomatoloji >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucRomatoloji = (int)sqlCommSaatOnBucukRomatoloji.ExecuteScalar();

                if (SaatOnBucukSonucRomatoloji >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucRomatoloji = (int)sqlCommSaatOnBirRomatoloji.ExecuteScalar();

                if (SaatOnBirSonucRomatoloji >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucRomatoloji = (int)sqlCommSaatOnBirBucukRomatoloji.ExecuteScalar();

                if (SaatOnBirBucukSonucRomatoloji >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucRomatoloji = (int)sqlCommSaatOnİkiRomatoloji.ExecuteScalar();

                if (SaatOnİkiSonucRomatoloji >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucRomatoloji = (int)sqlCommSaatOnİkiBucukRomatoloji.ExecuteScalar();

                if (SaatOnİkiBucukSonucRomatoloji >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucRomatoloji = (int)sqlCommSaatOnUcRomatoloji.ExecuteScalar();

                if (SaatOnUcSonucRomatoloji >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucRomatoloji = (int)sqlCommSaatOnUcBucukRomatoloji.ExecuteScalar();

                if (SaatOnUcBucukSonucRomatoloji >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucRomatoloji = (int)sqlCommSaatOnDörtRomatoloji.ExecuteScalar();

                if (SaatOnDörtSonucRomatoloji >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucRomatoloji = (int)sqlCommSaatOnDörtBucukRomatoloji.ExecuteScalar();

                if (SaatOnDörtBucukSonucRomatoloji >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucRomatoloji = (int)sqlCommSaatOnBesRomatoloji.ExecuteScalar();

                if (SaatOnBesSonucRomatoloji >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucRomatoloji = (int)sqlCommSaatOnBesOtuzRomatoloji.ExecuteScalar();

                if (SaatOnBesOtuzSonucRomatoloji >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıRomatoloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Romatoloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucRomatoloji = (int)sqlCommSaatOnAltıRomatoloji.ExecuteScalar();

                if (SaatOnAltıSonucRomatoloji >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #region Üroloji Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Üroloji")
            {
                
                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucUroloji = (int)sqlCommSaatDokuzUroloji.ExecuteScalar();

                if (saatDokuzSonucUroloji >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucUroloji = (int)sqlCommSaatDokuzBucukUroloji.ExecuteScalar();

                if (saatDokuzBucukSonucUroloji >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucUroloji = (int)sqlCommSaatOnUroloji.ExecuteScalar();

                if (SaatOnSonucUroloji >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucUroloji = (int)sqlCommSaatOnBucukUroloji.ExecuteScalar();

                if (SaatOnBucukSonucUroloji >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucUroloji = (int)sqlCommSaatOnBirUroloji.ExecuteScalar();

                if (SaatOnBirSonucUroloji >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucUroloji = (int)sqlCommSaatOnBirBucukUroloji.ExecuteScalar();

                if (SaatOnBirBucukSonucUroloji >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucUroloji = (int)sqlCommSaatOnİkiUroloji.ExecuteScalar();

                if (SaatOnİkiSonucUroloji >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucUroloji = (int)sqlCommSaatOnİkiBucukUroloji.ExecuteScalar();

                if (SaatOnİkiBucukSonucUroloji >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucUroloji = (int)sqlCommSaatOnUcUroloji.ExecuteScalar();

                if (SaatOnUcSonucUroloji >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucUroloji = (int)sqlCommSaatOnUcBucukUroloji.ExecuteScalar();

                if (SaatOnUcBucukSonucUroloji >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucUroloji = (int)sqlCommSaatOnDörtUroloji.ExecuteScalar();

                if (SaatOnDörtSonucUroloji >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucUroloji = (int)sqlCommSaatOnDörtBucukUroloji.ExecuteScalar();

                if (SaatOnDörtBucukSonucUroloji >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucUroloji = (int)sqlCommSaatOnBesUroloji.ExecuteScalar();

                if (SaatOnBesSonucUroloji >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucUroloji = (int)sqlCommSaatOnBesOtuzUroloji.ExecuteScalar();

                if (SaatOnBesOtuzSonucUroloji >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıUroloji = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Üroloji' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucUroloji = (int)sqlCommSaatOnAltıUroloji.ExecuteScalar();

                if (SaatOnAltıSonucUroloji >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


            }

            #endregion

            #endregion


        }

        private void picBoxGeri_Click(object sender, EventArgs e)
        {
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            this.Visible = false;

            frm3.Refresh();
            frm4.Refresh();
            frm4.Visible = true;
        }

        private void btnRandevularım_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form frm8 = new Form8();

            frm8.ShowDialog();
        }


        #region PicBox'ların Saat Ayarlamaları

        private void picBoxSaatDokuz_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";
              
                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }
            

            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion


            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatDokuz.Text;

            frm6.ShowDialog();

            
        }

        private void picBoxSaatDokuzBucuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatDokuzBucuk.Text;

            

            frm6.ShowDialog();

        }

        private void picBoxSaatOn_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOn.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnBucuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnBucuk.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatSaatOnBir_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnBir.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnBirBucuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnBirBucuk.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnİki_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnİki.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnİkiOtuz_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnİkiBucuk.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnUc_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnUc.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnUcOtuz_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnUcOtuz.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnDört_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnDört.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnDörtOtuz_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnDörtOtuz.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnBes_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnBes.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnBesOtuz_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnBesOtuz.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnAltı_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnAltı.Text;

            frm6.ShowDialog();
        }



        #endregion

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

            Application.Restart();

        }

        private void btnRandevularım_MouseLeave(object sender, EventArgs e)
        {
            btnRandevularım.BackColor = Color.Orange;
        }

        private void btnRandevularım_MouseMove(object sender, MouseEventArgs e)
        {
            btnRandevularım.BackColor = SystemColors.WindowFrame;
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

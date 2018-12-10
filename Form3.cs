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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string secilenTarih;

        Form4 frm4 = new Form4();


        private void Form3_Load(object sender, EventArgs e)
        {

            lblBeyinveSinirCerrahisi.Text = "Beyin ve Sinir\nCerrahisi";
            lblKulakBurunBogazHastaliklari.Text = "Kulak-Burun-Boğaz\nHastalıkları";
            lblKalpveDamarCerrahisi.Text = "Kalp ve Damar\nCerrahisi";
            lblPlastikveEstetikCerrahisi.Text = "Plastik ve Estetik\nCerrahisi";
            lblKadınHastaliklariveDogum.Text = "Kadın Hastalıkları\nve Doğum";
            lblEndokronolojiveMetabolizma.Text = "Endokronoloji ve\nMetabolizma";
            lblOrtopediveTravma.Text = "Ortopedi ve\nTravma";
            lblFizikselTıpveRehabilitasyon.Text = "Fiziksel Tıp ve\nRehabilitasyon";

            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Form2 frm2 = (Form2)Application.OpenForms["Form2"];

            lblHosgeldinizAciklama.Text = "Sn.  " + frm1.ad + " " + frm1.soyad + ", e-randevu sistemine hoşgeldiniz.";

            monthCalendar_randevuTarihleri.MinDate = DateTime.Now;
            monthCalendar_randevuTarihleri.MaxDate = new DateTime(2021, 12, 31);

            DateTime frm2deSecilenTarih = frm2.monthCalendar_randevuTarihleri.SelectionStart.Date;

            lblTarih1.Text = frm2deSecilenTarih.ToLongDateString();
            lblTarih2.Text = frm2deSecilenTarih.ToLongDateString();

            if (DateTime.Compare(frm2.monthCalendar_randevuTarihleri.SelectionRange.Start, DateTime.Today.Date) == 1)
                monthCalendar_randevuTarihleri.SelectionStart = frm2.monthCalendar_randevuTarihleri.SelectionStart;

            SqlConnection sqlConn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\DBHastaneRandevuSistemiOtomasyonu.mdf; Integrated Security = True;");

            sqlConn.Open();

            #region Polikliniklerin Boş ve Dolu Ayarlaması

            #region Beyin ve Sinir Cerrahisi Boş ve Dolu Ayarlaması

            int ToplamBosBeyinveSinirCerrahisi = 15;
            int ToplamDoluBeyinveSinirCerrahisi = 0;

            SqlCommand sqlCommBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Beyin ve Sinir Cerrahisi' ", sqlConn);

            int toplamRandevuSayisiBeyinveSinirCerrahisi = (int)sqlCommBeyinveSinirCerrahisi.ExecuteScalar();

            ToplamBosBeyinveSinirCerrahisi -= toplamRandevuSayisiBeyinveSinirCerrahisi;
            ToplamDoluBeyinveSinirCerrahisi = toplamRandevuSayisiBeyinveSinirCerrahisi;


            lblBosBeyinveSinirCerrahisi.Text = ToplamBosBeyinveSinirCerrahisi.ToString();
            lblDoluBeyinveSinirCerrahisi.Text = ToplamDoluBeyinveSinirCerrahisi.ToString();

            #endregion

            #region Kardiyoloji Boş ve Dolu Ayarlaması

            int ToplamBosKardiyoloji = 15;
            int ToplamDoluKardiyoloji = 0;

            SqlCommand sqlCommKardiyoloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Kardiyoloji' ", sqlConn);

            int toplamRandevuSayisiKardiyoloji = (int)sqlCommKardiyoloji.ExecuteScalar();

            ToplamBosKardiyoloji -= toplamRandevuSayisiKardiyoloji;
            ToplamDoluKardiyoloji = toplamRandevuSayisiKardiyoloji;


            lblBosKardiyoloji.Text = ToplamBosKardiyoloji.ToString();
            lblDoluKardiyoloji.Text = ToplamDoluKardiyoloji.ToString();

            #endregion

            #region Nöroloji Boş ve Dolu Ayarlaması

            int ToplamBosNöroloji = 15;
            int ToplamDoluNöroloji = 0;

            SqlCommand sqlCommNöroloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Nöroloji' ", sqlConn);

            int toplamRandevuSayisiNöroloji = (int)sqlCommNöroloji.ExecuteScalar();

            ToplamBosNöroloji -= toplamRandevuSayisiNöroloji;
            ToplamDoluNöroloji = toplamRandevuSayisiNöroloji;


            lblBosNöroloji.Text = ToplamBosNöroloji.ToString();
            lblDoluNöroloji.Text = ToplamDoluNöroloji.ToString();

            #endregion

            #region Psikiyatri Boş ve Dolu Ayarlaması

            int ToplamBosPsikiyatri = 15;
            int ToplamDoluPsikiyatri = 0;

            SqlCommand sqlCommPsikiyatri = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Psikiyatri' ", sqlConn);

            int toplamRandevuSayisiPsikiyatri = (int)sqlCommPsikiyatri.ExecuteScalar();

            ToplamBosPsikiyatri -= toplamRandevuSayisiPsikiyatri;
            ToplamDoluPsikiyatri = toplamRandevuSayisiPsikiyatri;

            lblBosPsikiyatri.Text = ToplamBosPsikiyatri.ToString();
            lblDoluPsikiyatri.Text = ToplamDoluPsikiyatri.ToString();

            #endregion

            #region İç Hastaliklari Boş ve Dolu Ayarlaması

            int ToplamBosİcHastaliklari = 15;
            int ToplamDoluİcHastaliklari = 0;

            SqlCommand sqlCommİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'İç Hastalıkları' ", sqlConn);

            int toplamRandevuSayisiİcHastaliklari = (int)sqlCommİcHastaliklari.ExecuteScalar();

            ToplamBosİcHastaliklari -= toplamRandevuSayisiİcHastaliklari;
            ToplamDoluİcHastaliklari = toplamRandevuSayisiİcHastaliklari;

            lblBosİcHastaliklari.Text = ToplamBosİcHastaliklari.ToString();
            lblDoluİcHastaliklari.Text = ToplamDoluİcHastaliklari.ToString();

            #endregion

            #region Göz Hastaliklari Boş ve Dolu Ayarlaması

            int ToplamBosGözHastaliklari = 15;
            int ToplamDoluGözHastaliklari = 0;

            SqlCommand sqlCommGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Göz Hastalıkları' ", sqlConn);

            int toplamRandevuSayisiGözHastaliklari = (int)sqlCommGözHastaliklari.ExecuteScalar();

            ToplamBosGözHastaliklari -= toplamRandevuSayisiGözHastaliklari;
            ToplamDoluGözHastaliklari = toplamRandevuSayisiGözHastaliklari;

            lblBosGözHastalıkları.Text = ToplamBosGözHastaliklari.ToString();
            lblDoluGözHastalıkları.Text = ToplamDoluGözHastaliklari.ToString();

            #endregion

            #region Kulak-Burun-Boğaz Hastaliklari Boş ve Dolu Ayarlaması

            int ToplamBosKulakBurunBogaz = 15;
            int ToplamDoluKulakBurunBogaz = 0;

            SqlCommand sqlCommKulakBurunBoğaz = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' ", sqlConn);

            int toplamRandevuSayisiKulakBurunBoğaz = (int)sqlCommKulakBurunBoğaz.ExecuteScalar();

            ToplamBosKulakBurunBogaz -= toplamRandevuSayisiKulakBurunBoğaz;
            ToplamDoluKulakBurunBogaz = toplamRandevuSayisiKulakBurunBoğaz;

            lblBosKulakBurunBogazHastaliklari.Text = ToplamBosKulakBurunBogaz.ToString();
            lblDoluKulakBurunBogazHastaliklari.Text = ToplamDoluKulakBurunBogaz.ToString();

            #endregion

            #region Göğüs Hastalıklari Boş ve Dolu Ayarlaması

            int ToplamBosGögüs = 15;
            int ToplamDoluGögüs = 0;

            SqlCommand sqlCommGögüs = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Göğüs Hastalıkları' ", sqlConn);

            int toplamRandevuSayisiGögüs = (int)sqlCommGögüs.ExecuteScalar();

            ToplamBosGögüs -= toplamRandevuSayisiGögüs;
            ToplamDoluGögüs = toplamRandevuSayisiGögüs;

            lblBosGögüsHastaliklari.Text = ToplamBosGögüs.ToString();
            lblDoluGögüsHastaliklari.Text = ToplamDoluGögüs.ToString();

            #endregion

            #region Kalp ve Damar Cerrahisi Boş ve Dolu Ayarlaması

            int ToplamBosKalpveDamar = 15;
            int ToplamDoluKalpveDamar = 0;

            SqlCommand sqlCommKalpveDamar = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Kalp ve Damar Cerrahisi' ", sqlConn);

            int toplamRandevuSayisiKalpveDamar = (int)sqlCommKalpveDamar.ExecuteScalar();

            ToplamBosKalpveDamar -= toplamRandevuSayisiKalpveDamar;
            ToplamDoluKalpveDamar = toplamRandevuSayisiKalpveDamar;

            lblBosKalpveDamarCerrahisi.Text = ToplamBosKalpveDamar.ToString();
            lblDoluKalpveDamarCerrahisi.Text = ToplamDoluKalpveDamar.ToString();

            #endregion

            #region Gastroenteroloji Boş ve Dolu Ayarlaması

            int ToplamBosGastroenteroloji = 15;
            int ToplamDoluGastroenteroloji = 0;

            SqlCommand sqlCommGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Gastroenteroloji' ", sqlConn);

            int toplamRandevuSayisiGastroenteroloji = (int)sqlCommGastroenteroloji.ExecuteScalar();

            ToplamBosGastroenteroloji -= toplamRandevuSayisiGastroenteroloji;
            ToplamDoluGastroenteroloji = toplamRandevuSayisiGastroenteroloji;

            lblBosGastroenteroloji.Text = ToplamBosGastroenteroloji.ToString();
            lblDoluGastroenteroloji.Text = ToplamDoluGastroenteroloji.ToString();

            #endregion

            #region Plastik ve Estetik Cerrahisi Boş ve Dolu Ayarlaması

            int ToplamBosPlastikveEstetik = 15;
            int ToplamDoluPlastikveEstetik = 0;

            SqlCommand sqlCommPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Plastik ve Estetik Cerrahisi' ", sqlConn);

            int toplamRandevuSayisiPlastikveEstetik = (int)sqlCommPlastikveEstetik.ExecuteScalar();

            ToplamBosPlastikveEstetik -= toplamRandevuSayisiPlastikveEstetik;
            ToplamDoluPlastikveEstetik = toplamRandevuSayisiPlastikveEstetik;

            lblBosPlastikveEstetikCerrahisi.Text = ToplamBosPlastikveEstetik.ToString();
            lblDoluPlastikveEstetikCerrahisi.Text = ToplamDoluPlastikveEstetik.ToString();

            #endregion

            #region Kadın Hastalıkları ve Doğum Boş ve Dolu Ayarlaması

            int ToplamBosKadinHastaliklariveDogum = 15;
            int ToplamDoluKadinHastaliklariveDogum = 0;

            SqlCommand sqlCommKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Kadın Hastalıkları ve Doğum' ", sqlConn);

            int toplamRandevuSayisiKadinHastaliklariveDogum = (int)sqlCommKadinHastaliklariveDogum.ExecuteScalar();

            ToplamBosKadinHastaliklariveDogum -= toplamRandevuSayisiKadinHastaliklariveDogum;
            ToplamDoluKadinHastaliklariveDogum = toplamRandevuSayisiKadinHastaliklariveDogum;

            lblBosKadınHastaliklariveDogum.Text = ToplamBosKadinHastaliklariveDogum.ToString();
            lblDoluKadınHastaliklariveDogum.Text = ToplamDoluKadinHastaliklariveDogum.ToString();

            #endregion

            #region Endokronoloji ve Metabolizma Boş ve Dolu Ayarlaması

            int ToplamBosEndokronolojiveMetabolizma = 15;
            int ToplamDoluEndokronolojiveMetabolizma = 0;

            SqlCommand sqlCommEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Endokronoloji ve Metabolizma' ", sqlConn);

            int toplamRandevuSayisiEndokronolojiveMetabolizma = (int)sqlCommEndokronolojiveMetabolizma.ExecuteScalar();

            ToplamBosEndokronolojiveMetabolizma -= toplamRandevuSayisiEndokronolojiveMetabolizma;
            ToplamDoluEndokronolojiveMetabolizma = toplamRandevuSayisiEndokronolojiveMetabolizma;

            lblBosEndokronolojiveMetabolizma.Text = ToplamBosEndokronolojiveMetabolizma.ToString();
            lblDoluEndokronolojiveMetabolizma.Text = ToplamDoluEndokronolojiveMetabolizma.ToString();

            #endregion

            #region Dermatoloji Boş ve Dolu Ayarlaması

            int ToplamBosDermatoloji = 15;
            int ToplamDoluDermatoloji = 0;

            SqlCommand sqlCommDermatoloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Dermatoloji' ", sqlConn);

            int toplamRandevuSayisiDermatoloji = (int)sqlCommDermatoloji.ExecuteScalar();

            ToplamBosDermatoloji -= toplamRandevuSayisiDermatoloji;
            ToplamDoluDermatoloji = toplamRandevuSayisiDermatoloji;

            lblBosDermatoloji.Text = ToplamBosDermatoloji.ToString();
            lblDoluDermatoloji.Text = ToplamDoluDermatoloji.ToString();

            #endregion

            #region Ortopedi ve Travma Boş ve Dolu Ayarlaması

            int ToplamBosOrtopediveTravma = 15;
            int ToplamDoluOrtopediveTravma = 0;

            SqlCommand sqlCommOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Ortopedi ve Travma' ", sqlConn);

            int toplamRandevuSayisiOrtopediveTravma = (int)sqlCommOrtopediveTravma.ExecuteScalar();

            ToplamBosOrtopediveTravma -= toplamRandevuSayisiOrtopediveTravma;
            ToplamDoluOrtopediveTravma = toplamRandevuSayisiOrtopediveTravma;

            lblBosOrtopediveTravma.Text = ToplamBosOrtopediveTravma.ToString();
            lblDoluOrtopediveTravma.Text = ToplamDoluOrtopediveTravma.ToString();

            #endregion

            #region Fiziksel Tıp ve Rehabilitasyon Boş ve Dolu Ayarlaması

            int ToplamBosFizikselTıpveRehabilitasyon = 15;
            int ToplamDoluFizikselTıpveRehabilitasyon = 0;

            SqlCommand sqlCommFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' ", sqlConn);

            int toplamRandevuSayisiFizikselTıpveRehabilitasyon = (int)sqlCommFizikselTıpveRehabilitasyon.ExecuteScalar();

            ToplamBosFizikselTıpveRehabilitasyon -= toplamRandevuSayisiFizikselTıpveRehabilitasyon;
            ToplamDoluFizikselTıpveRehabilitasyon = toplamRandevuSayisiFizikselTıpveRehabilitasyon;

            lblBosFizikselTıpveRehabilitasyon.Text = ToplamBosFizikselTıpveRehabilitasyon.ToString();
            lblDoluFizikselTıpveRehabilitasyon.Text = ToplamDoluFizikselTıpveRehabilitasyon.ToString();

            #endregion

            #region Nefroloji Boş ve Dolu Ayarlaması

            int ToplamBosNefroloji = 15;
            int ToplamDoluNefroloji = 0;

            SqlCommand sqlCommNefroloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Nefroloji' ", sqlConn);

            int toplamRandevuSayisiNefroloji = (int)sqlCommNefroloji.ExecuteScalar();

            ToplamBosNefroloji -= toplamRandevuSayisiNefroloji;
            ToplamDoluNefroloji = toplamRandevuSayisiNefroloji;

            lblBosNefroloji.Text = ToplamBosNefroloji.ToString();
            lblDoluNefroloji.Text = ToplamDoluNefroloji.ToString();

            #endregion

            #region Hematoloji Boş ve Dolu Ayarlaması

            int ToplamBosHematoloji = 15;
            int ToplamDoluHematoloji = 0;

            SqlCommand sqlCommHematoloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Hematoloji' ", sqlConn);

            int toplamRandevuSayisiHematoloji = (int)sqlCommHematoloji.ExecuteScalar();

            ToplamBosHematoloji -= toplamRandevuSayisiHematoloji;
            ToplamDoluHematoloji = toplamRandevuSayisiHematoloji;

            lblBosHematoloji.Text = ToplamBosHematoloji.ToString();
            lblDoluHematoloji.Text = ToplamDoluHematoloji.ToString();

            #endregion

            #region Romatoloji Boş ve Dolu Ayarlaması

            int ToplamBosRomatoloji = 15;
            int ToplamDoluRomatoloji = 0;

            SqlCommand sqlCommRomatoloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Romatoloji' ", sqlConn);

            int toplamRandevuSayisiRomatoloji = (int)sqlCommRomatoloji.ExecuteScalar();

            ToplamBosRomatoloji -= toplamRandevuSayisiRomatoloji;
            ToplamDoluRomatoloji = toplamRandevuSayisiRomatoloji;

            lblBosRomatoloji.Text = ToplamBosRomatoloji.ToString();
            lblDoluRomatoloji.Text = ToplamDoluRomatoloji.ToString();

            #endregion

            #region Üroloji Boş ve Dolu Ayarlaması

            int ToplamBosUroloji = 15;
            int ToplamDoluUroloji = 0;

            SqlCommand sqlCommUroloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + frm2.secilenTarih + "' AND Poliklinik = 'Üroloji' ", sqlConn);

            int toplamRandevuSayisiUroloji = (int)sqlCommUroloji.ExecuteScalar();

            ToplamBosUroloji -= toplamRandevuSayisiUroloji;
            ToplamDoluUroloji = toplamRandevuSayisiUroloji;

            lblBosÜroloji.Text = ToplamBosUroloji.ToString();
            lblDoluÜroloji.Text = ToplamDoluUroloji.ToString();

            #endregion


            #endregion


        }

        private void btnRandevularım_Click(object sender, EventArgs e)
        {
            this.Refresh();
            this.Visible = false;

            Form frm8 = new Form8();
            frm8.ShowDialog();
        }

        private void monthCalendar_randevuTarihleri_DateChanged(object sender, DateRangeEventArgs e)
        {
            secilenTarih = e.Start.ToShortDateString();

            DateTime frm3deSecilenTarih = monthCalendar_randevuTarihleri.SelectionStart.Date;

            lblTarih1.Text = frm3deSecilenTarih.ToLongDateString();
            lblTarih2.Text = frm3deSecilenTarih.ToLongDateString();

            SqlConnection sqlConn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\DBHastaneRandevuSistemiOtomasyonu.mdf; Integrated Security = True;");

            sqlConn.Open();

            #region Polikliniklerin Boş ve Dolu Ayarlaması

            #region Beyin ve Sinir Cerrahisi Boş ve Dolu Ayarlaması

            int ToplamBosBeyinveSinirCerrahisi = 15;
            int ToplamDoluBeyinveSinirCerrahisi = 0;

            SqlCommand sqlCommBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Beyin ve Sinir Cerrahisi' ", sqlConn);

            int toplamRandevuSayisi = (int)sqlCommBeyinveSinirCerrahisi.ExecuteScalar();

            ToplamBosBeyinveSinirCerrahisi -= toplamRandevuSayisi;
            ToplamDoluBeyinveSinirCerrahisi = toplamRandevuSayisi;


            lblBosBeyinveSinirCerrahisi.Text = ToplamBosBeyinveSinirCerrahisi.ToString();
            lblDoluBeyinveSinirCerrahisi.Text = ToplamDoluBeyinveSinirCerrahisi.ToString();

            #endregion

            #region Kardiyoloji Boş ve Dolu Ayarlaması

            int ToplamBosKardiyoloji = 15;
            int ToplamDoluKardiyoloji = 0;

            SqlCommand sqlCommKardiyoloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Kardiyoloji' ", sqlConn);

            int toplamRandevuSayisiKardiyoloji = (int)sqlCommKardiyoloji.ExecuteScalar();

            ToplamBosKardiyoloji -= toplamRandevuSayisiKardiyoloji;
            ToplamDoluKardiyoloji = toplamRandevuSayisiKardiyoloji;


            lblBosKardiyoloji.Text = ToplamBosKardiyoloji.ToString();
            lblDoluKardiyoloji.Text = ToplamDoluKardiyoloji.ToString();

            #endregion

            #region Nöroloji Boş ve Dolu Ayarlaması

            int ToplamBosNöroloji = 15;
            int ToplamDoluNöroloji = 0;

            SqlCommand sqlCommNöroloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Nöroloji' ", sqlConn);

            int toplamRandevuSayisiNöroloji = (int)sqlCommNöroloji.ExecuteScalar();

            ToplamBosNöroloji -= toplamRandevuSayisiNöroloji;
            ToplamDoluNöroloji = toplamRandevuSayisiNöroloji;
           
            lblBosNöroloji.Text = ToplamBosNöroloji.ToString();
            lblDoluNöroloji.Text = ToplamDoluNöroloji.ToString();

            #endregion

            #region Psikiyatri Boş ve Dolu Ayarlaması

            int ToplamBosPsikiyatri = 15;
            int ToplamDoluPsikiyatri = 0;

            SqlCommand sqlCommPsikiyatri = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Psikiyatri' ", sqlConn);

            int toplamRandevuSayisiPsikiyatri = (int)sqlCommPsikiyatri.ExecuteScalar();

            ToplamBosPsikiyatri -= toplamRandevuSayisiPsikiyatri;
            ToplamDoluPsikiyatri = toplamRandevuSayisiPsikiyatri;

            lblBosPsikiyatri.Text = ToplamBosPsikiyatri.ToString();
            lblDoluPsikiyatri.Text = ToplamDoluPsikiyatri.ToString();

            #endregion

            #region İç Hastaliklari Boş ve Dolu Ayarlaması

            int ToplamBosİcHastaliklari = 15;
            int ToplamDoluİcHastaliklari = 0;

            SqlCommand sqlCommİcHastaliklari = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'İç Hastalıkları' ", sqlConn);

            int toplamRandevuSayisiİcHastaliklari = (int)sqlCommİcHastaliklari.ExecuteScalar();

            ToplamBosİcHastaliklari -= toplamRandevuSayisiİcHastaliklari;
            ToplamDoluİcHastaliklari = toplamRandevuSayisiİcHastaliklari;

            lblBosİcHastaliklari.Text = ToplamBosİcHastaliklari.ToString();
            lblDoluİcHastaliklari.Text = ToplamDoluİcHastaliklari.ToString();

            #endregion

            #region Göz Hastaliklari Boş ve Dolu Ayarlaması

            int ToplamBosGözHastaliklari = 15;
            int ToplamDoluGözHastaliklari = 0;

            SqlCommand sqlCommGözHastaliklari = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Göz Hastalıkları' ", sqlConn);

            int toplamRandevuSayisiGözHastaliklari = (int)sqlCommGözHastaliklari.ExecuteScalar();

            ToplamBosGözHastaliklari -= toplamRandevuSayisiGözHastaliklari;
            ToplamDoluGözHastaliklari = toplamRandevuSayisiGözHastaliklari;

            lblBosGözHastalıkları.Text = ToplamBosGözHastaliklari.ToString();
            lblDoluGözHastalıkları.Text = ToplamDoluGözHastaliklari.ToString();

            #endregion

            #region Kulak-Burun-Boğaz Hastalıklari Boş ve Dolu Ayarlaması

            int ToplamBosKulakBurunBogaz = 15;
            int ToplamDoluKulakBurunBogaz = 0;

            SqlCommand sqlCommKulakBurunBogaz = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Kulak-Burun-Boğaz Hastalıkları' ", sqlConn);

            int toplamRandevuSayisiKulakBurunBoğaz = (int)sqlCommKulakBurunBogaz.ExecuteScalar();

            ToplamBosKulakBurunBogaz -= toplamRandevuSayisiKulakBurunBoğaz;
            ToplamDoluKulakBurunBogaz = toplamRandevuSayisiKulakBurunBoğaz;

            lblBosKulakBurunBogazHastaliklari.Text = ToplamBosKulakBurunBogaz.ToString();
            lblDoluKulakBurunBogazHastaliklari.Text = ToplamDoluKulakBurunBogaz.ToString();

            #endregion

            #region Göğüs Hastalıklari Boş ve Dolu Ayarlaması

            int ToplamBosGögüs = 15;
            int ToplamDoluGögüs = 0;

            SqlCommand sqlCommGögüs = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Göğüs Hastalıkları' ", sqlConn);

            int toplamRandevuSayisiGögüs = (int)sqlCommGögüs.ExecuteScalar();

            ToplamBosGögüs -= toplamRandevuSayisiGögüs;
            ToplamDoluGögüs = toplamRandevuSayisiGögüs;

            lblBosGögüsHastaliklari.Text = ToplamBosGögüs.ToString();
            lblDoluGögüsHastaliklari.Text = ToplamDoluGögüs.ToString();

            #endregion

            #region Kalp ve Damar Cerrahisi Boş ve Dolu Ayarlaması

            int ToplamBosKalpveDamar = 15;
            int ToplamDoluKalpveDamar = 0;

            SqlCommand sqlCommKalpveDamar = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Kalp ve Damar Cerrahisi' ", sqlConn);

            int toplamRandevuSayisiKalpveDamar = (int)sqlCommKalpveDamar.ExecuteScalar();

            ToplamBosKalpveDamar -= toplamRandevuSayisiKalpveDamar;
            ToplamDoluKalpveDamar = toplamRandevuSayisiKalpveDamar;

            lblBosKalpveDamarCerrahisi.Text = ToplamBosKalpveDamar.ToString();
            lblDoluKalpveDamarCerrahisi.Text = ToplamDoluKalpveDamar.ToString();

            #endregion,

            #region Gastroenteroloji Boş ve Dolu Ayarlaması

            int ToplamBosGastroenteroloji = 15;
            int ToplamDoluGastroenteroloji = 0;

            SqlCommand sqlCommGastroenteroloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Gastroenteroloji' ", sqlConn);

            int toplamRandevuSayisiGastroenteroloji = (int)sqlCommGastroenteroloji.ExecuteScalar();

            ToplamBosGastroenteroloji -= toplamRandevuSayisiGastroenteroloji;
            ToplamDoluGastroenteroloji = toplamRandevuSayisiGastroenteroloji;

            lblBosGastroenteroloji.Text = ToplamBosGastroenteroloji.ToString();
            lblDoluGastroenteroloji.Text = ToplamDoluGastroenteroloji.ToString();

            #endregion

            #region Plastik ve Estetik Cerrahisi Boş ve Dolu Ayarlaması

            int ToplamBosPlastikveEstetik = 15;
            int ToplamDoluPlastikveEstetik = 0;

            SqlCommand sqlCommPlastikveEstetik = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Plastik ve Estetik Cerrahisi' ", sqlConn);

            int toplamRandevuSayisiPlastikveEstetik = (int)sqlCommPlastikveEstetik.ExecuteScalar();

            ToplamBosPlastikveEstetik -= toplamRandevuSayisiPlastikveEstetik;
            ToplamDoluPlastikveEstetik = toplamRandevuSayisiPlastikveEstetik;

            lblBosPlastikveEstetikCerrahisi.Text = ToplamBosPlastikveEstetik.ToString();
            lblDoluPlastikveEstetikCerrahisi.Text = ToplamDoluPlastikveEstetik.ToString();

            #endregion

            #region Kadın Hastalıkları ve Doğum Boş ve Dolu Ayarlaması

            int ToplamBosKadinHastaliklariveDogum = 15;
            int ToplamDoluKadinHastaliklariveDogum = 0;

            SqlCommand sqlCommKadinHastaliklariveDogum = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Kadın Hastalıkları ve Doğum' ", sqlConn);

            int toplamRandevuSayisiKadinHastaliklariveDogum = (int)sqlCommKadinHastaliklariveDogum.ExecuteScalar();

            ToplamBosKadinHastaliklariveDogum -= toplamRandevuSayisiKadinHastaliklariveDogum;
            ToplamDoluKadinHastaliklariveDogum = toplamRandevuSayisiKadinHastaliklariveDogum;

            lblBosKadınHastaliklariveDogum.Text = ToplamBosKadinHastaliklariveDogum.ToString();
            lblDoluKadınHastaliklariveDogum.Text = ToplamDoluKadinHastaliklariveDogum.ToString();

            #endregion

            #region Endokronoloji ve Metabolizma Boş ve Dolu Ayarlaması

            int ToplamBosEndokronolojiveMetabolizma = 15;
            int ToplamDoluEndokronolojiveMetabolizma = 0;

            SqlCommand sqlCommEndokronolojiveMetabolizma = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Endokronoloji ve Metabolizma' ", sqlConn);

            int toplamRandevuSayisiEndokronolojiveMetabolizma = (int)sqlCommEndokronolojiveMetabolizma.ExecuteScalar();

            ToplamBosEndokronolojiveMetabolizma -= toplamRandevuSayisiEndokronolojiveMetabolizma;
            ToplamDoluEndokronolojiveMetabolizma = toplamRandevuSayisiEndokronolojiveMetabolizma;

            lblBosEndokronolojiveMetabolizma.Text = ToplamBosEndokronolojiveMetabolizma.ToString();
            lblDoluEndokronolojiveMetabolizma.Text = ToplamDoluEndokronolojiveMetabolizma.ToString();

            #endregion

            #region Dermatoloji Boş ve Dolu Ayarlaması

            int ToplamBosDermatoloji = 15;
            int ToplamDoluDermatoloji = 0;

            SqlCommand sqlCommDermatoloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Dermatoloji' ", sqlConn);

            int toplamRandevuSayisiDermatoloji = (int)sqlCommDermatoloji.ExecuteScalar();

            ToplamBosDermatoloji -= toplamRandevuSayisiDermatoloji;
            ToplamDoluDermatoloji = toplamRandevuSayisiDermatoloji;

            lblBosDermatoloji.Text = ToplamBosDermatoloji.ToString();
            lblDoluDermatoloji.Text = ToplamDoluDermatoloji.ToString();

            #endregion

            #region Ortopedi ve Travma Boş ve Dolu Ayarlaması
            
            int ToplamBosOrtopediveTravma = 15;
            int ToplamDoluOrtopediveTravma = 0;

            SqlCommand sqlCommOrtopediveTravma = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Ortopedi ve Travma' ", sqlConn);

            int toplamRandevuSayisiOrtopediveTravma = (int)sqlCommOrtopediveTravma.ExecuteScalar();

            ToplamBosOrtopediveTravma -= toplamRandevuSayisiOrtopediveTravma;
            ToplamDoluOrtopediveTravma = toplamRandevuSayisiOrtopediveTravma;

            lblBosOrtopediveTravma.Text = ToplamBosOrtopediveTravma.ToString();
            lblDoluOrtopediveTravma.Text = ToplamDoluOrtopediveTravma.ToString();

            #endregion

            #region Fiziksel Tıp ve Rehabilitasyon Boş ve Dolu Ayarlaması

            int ToplamBosFizikselTıpveRehabilitasyon = 15;
            int ToplamDoluFizikselTıpveRehabilitasyon = 0;

            SqlCommand sqlCommFizikselTıpveRehabilitasyon = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Fiziksel Tıp ve Rehabilitasyon' ", sqlConn);

            int toplamRandevuSayisiFizikselTıpveRehabilitasyon = (int)sqlCommFizikselTıpveRehabilitasyon.ExecuteScalar();

            ToplamBosFizikselTıpveRehabilitasyon -= toplamRandevuSayisiFizikselTıpveRehabilitasyon;
            ToplamDoluFizikselTıpveRehabilitasyon = toplamRandevuSayisiFizikselTıpveRehabilitasyon;

            lblBosFizikselTıpveRehabilitasyon.Text = ToplamBosFizikselTıpveRehabilitasyon.ToString();
            lblDoluFizikselTıpveRehabilitasyon.Text = ToplamDoluFizikselTıpveRehabilitasyon.ToString();

            #endregion

            #region Nefroloji Boş ve Dolu Ayarlaması

            int ToplamBosNefroloji = 15;
            int ToplamDoluNefroloji = 0;

            SqlCommand sqlCommNefroloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Nefroloji' ", sqlConn);

            int toplamRandevuSayisiNefroloji = (int)sqlCommNefroloji.ExecuteScalar();

            ToplamBosNefroloji -= toplamRandevuSayisiNefroloji;
            ToplamDoluNefroloji = toplamRandevuSayisiNefroloji;

            lblBosNefroloji.Text = ToplamBosNefroloji.ToString();
            lblDoluNefroloji.Text = ToplamDoluNefroloji.ToString();

            #endregion

            #region Hematoloji Boş ve Dolu Ayarlaması

            int ToplamBosHematoloji = 15;
            int ToplamDoluHematoloji = 0;

            SqlCommand sqlCommHematoloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Hematoloji' ", sqlConn);

            int toplamRandevuSayisiHematoloji = (int)sqlCommHematoloji.ExecuteScalar();

            ToplamBosHematoloji -= toplamRandevuSayisiHematoloji;
            ToplamDoluHematoloji = toplamRandevuSayisiHematoloji;

            lblBosHematoloji.Text = ToplamBosHematoloji.ToString();
            lblDoluHematoloji.Text = ToplamDoluHematoloji.ToString();

            #endregion

            #region Romatoloji Boş ve Dolu Ayarlaması

            int ToplamBosRomatoloji = 15;
            int ToplamDoluRomatoloji = 0;

            SqlCommand sqlCommRomatoloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Romatoloji' ", sqlConn);

            int toplamRandevuSayisiRomatoloji = (int)sqlCommRomatoloji.ExecuteScalar();

            ToplamBosRomatoloji -= toplamRandevuSayisiRomatoloji;
            ToplamDoluRomatoloji = toplamRandevuSayisiRomatoloji;

            lblBosRomatoloji.Text = ToplamBosRomatoloji.ToString();
            lblDoluRomatoloji.Text = ToplamDoluRomatoloji.ToString();

            #endregion

            #region Üroloji Boş ve Dolu Ayarlaması

            int ToplamBosUroloji = 15;
            int ToplamDoluUroloji = 0;

            SqlCommand sqlCommUroloji = new SqlCommand("SELECT COUNT(RandevuTarihi) FROM TB_HastaneRandevuSistemi WHERE RandevuTarihi = '" + e.Start.ToShortDateString() + "' AND Poliklinik = 'Üroloji' ", sqlConn);

            int toplamRandevuSayisiUroloji = (int)sqlCommUroloji.ExecuteScalar();

            ToplamBosUroloji -= toplamRandevuSayisiUroloji;
            ToplamDoluUroloji = toplamRandevuSayisiUroloji;

            lblBosÜroloji.Text = ToplamBosUroloji.ToString();
            lblDoluÜroloji.Text = ToplamDoluUroloji.ToString();

            #endregion

            #endregion

        }


        #region picBox'ların Click Event'leri

        private void picBoxBeyinveSinirCerrahisi_Click(object sender, EventArgs e)
        {
            if (lblDoluBeyinveSinirCerrahisi.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Beyin ve Sinir Cerrahisi";
                frm4.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";
                frm4.lblBolumİsmi.Text = lblBeyinveSinirCerrahisi.Text;

                frm4.lblBos.Text = lblBosBeyinveSinirCerrahisi.Text;
                frm4.lblDolu.Text = lblDoluBeyinveSinirCerrahisi.Text;

                this.Refresh();

                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxBeyinveSinirCerrahisi.Enabled = false;
            }
        }
        
        private void picBoxKardiyoloji_Click(object sender, EventArgs e)
        {
            if (lblDoluKardiyoloji.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Kardiyoloji";
                frm4.lblBransAdi2.Text = "Kardiyoloji";
                frm4.lblBolumİsmi.Text = lblKardiyoloji.Text;

                frm4.lblBos.Text = lblBosKardiyoloji.Text;
                frm4.lblDolu.Text = lblDoluKardiyoloji.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxKardiyoloji.Enabled = false;
            }
        }

        private void picBoxNöroloji_Click(object sender, EventArgs e)
        {
            if (lblDoluNöroloji.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Nöroloji";
                frm4.lblBransAdi2.Text = "Nöroloji";
                frm4.lblBolumİsmi.Text = lblNöroloji.Text;

                frm4.lblBos.Text = lblBosNöroloji.Text;
                frm4.lblDolu.Text = lblDoluNöroloji.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxNöroloji.Enabled = false;
            }
        }

        private void picBoxPsikiyatri_Click(object sender, EventArgs e)
        {
            if (lblDoluPsikiyatri.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Psikiyatri";
                frm4.lblBransAdi2.Text = "Psikiyatri";
                frm4.lblBolumİsmi.Text = lblPsikiyatri.Text;

                frm4.lblBos.Text = lblBosPsikiyatri.Text;
                frm4.lblDolu.Text = lblDoluPsikiyatri.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxPsikiyatri.Enabled = false;
            }

        }

        private void picBoxİcHastalıkları_Click(object sender, EventArgs e)
        {
            if (lblDoluİcHastaliklari.Text != "15")
            {

                frm4.lblBransAdi1.Text = "İç Hastalıkları";
                frm4.lblBransAdi2.Text = "İç Hastalıkları";
                frm4.lblBolumİsmi.Text = lblİcHastaliklari.Text;

                frm4.lblBos.Text = lblBosİcHastaliklari.Text;
                frm4.lblDolu.Text = lblDoluİcHastaliklari.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxİcHastalıkları.Enabled = false;
            }
        }

        private void picBoxGözHastalıkları_Click(object sender, EventArgs e)
        {
            if (lblDoluGözHastalıkları.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Göz Hastalıkları";
                frm4.lblBransAdi2.Text = "Göz Hastalıkları";
                frm4.lblBolumİsmi.Text = lblGözHastaliklari.Text;

                frm4.lblBos.Text = lblBosGözHastalıkları.Text;
                frm4.lblDolu.Text = lblDoluGözHastalıkları.Text;

                this.Refresh();
                this.Visible = false;


                frm4.ShowDialog();

            }
            else
            {
                picBoxGözHastalıkları.Enabled = false;
            }
        }

        private void picBoxKulakBurunBoğazHastalıkları_Click(object sender, EventArgs e)
        {
            if (lblDoluKulakBurunBogazHastaliklari.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hastalıkları";
                frm4.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";
                frm4.lblBolumİsmi.Text = "Kulak-Burun-Boğaz\nHastalıkları";

                frm4.lblBos.Text = lblBosKulakBurunBogazHastaliklari.Text;
                frm4.lblDolu.Text = lblDoluKulakBurunBogazHastaliklari.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxKulakBurunBoğazHastalıkları.Enabled = false;
            }
        }

        private void picBoxGögüsHastalıkları_Click(object sender, EventArgs e)
        {
            if (lblDoluGögüsHastaliklari.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm4.lblBransAdi2.Text = "Göğüs Hastalıkları";
                frm4.lblBolumİsmi.Text = lblGögüsHastaliklari.Text;

                frm4.lblBos.Text = lblBosGögüsHastaliklari.Text;
                frm4.lblDolu.Text = lblDoluGögüsHastaliklari.Text;

                this.Refresh();
                this.Visible = false;


                frm4.ShowDialog();

            }
            else
            {
                picBoxGögüsHastalıkları.Enabled = false;
            }
        }

        private void picBoxKalpveDamarCerrahisi_Click(object sender, EventArgs e)
        {
            if (lblDoluKalpveDamarCerrahisi.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm4.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";
                frm4.lblBolumİsmi.Text = "Kalp ve Damar\nCerrahisi";

                frm4.lblBos.Text = lblBosKalpveDamarCerrahisi.Text;
                frm4.lblDolu.Text = lblDoluKalpveDamarCerrahisi.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxKalpveDamarCerrahisi.Enabled = false;
            }
        }

        private void picBoxGastroenteroloji_Click(object sender, EventArgs e)
        {
            if (lblDoluGastroenteroloji.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Gastroenteroloji";
                frm4.lblBransAdi2.Text = "Gastroenteroloji";
                frm4.lblBolumİsmi.Text = lblGastroenteroloji.Text;

                frm4.lblBos.Text = lblBosGastroenteroloji.Text;
                frm4.lblDolu.Text = lblDoluGastroenteroloji.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxGastroenteroloji.Enabled = false;
            }
        }

        private void picBoxPlastikveEstetikCerrahisi_Click(object sender, EventArgs e)
        {
            if (lblDoluPlastikveEstetikCerrahisi.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Plastik ve Estetik Cerrahisi";
                frm4.lblBransAdi2.Text = "Plastik ve Estetik Cerrah.";
                frm4.lblBolumİsmi.Text = lblPlastikveEstetikCerrahisi.Text;

                frm4.lblBos.Text = lblBosPlastikveEstetikCerrahisi.Text;
                frm4.lblDolu.Text = lblDoluPlastikveEstetikCerrahisi.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxPlastikveEstetikCerrahisi.Enabled = false;
            }
        }

        private void picBoxKadınHastalıklarıveDogum_Click(object sender, EventArgs e)
        {
            if (lblDoluKadınHastaliklariveDogum.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Kadın Hastalıkları ve Doğum";
                frm4.lblBransAdi2.Text = "Kadın Hastalıkları ve Doğ.";
                frm4.lblBolumİsmi.Text = lblKadınHastaliklariveDogum.Text;

                frm4.lblBos.Text = lblBosKadınHastaliklariveDogum.Text;
                frm4.lblDolu.Text = lblDoluKadınHastaliklariveDogum.Text;

                this.Refresh();
                this.Visible = false;


                frm4.ShowDialog();

            }
            else
            {
                picBoxKadınHastalıklarıveDogum.Enabled = false;
            }
        }

        private void picBoxEndokronolojiveMetabolizma_Click(object sender, EventArgs e)
        {           
            if (lblDoluEndokronolojiveMetabolizma.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Endokronoloji ve Metabolizma";
                frm4.lblBransAdi2.Text = "Endokronoloji ve Metabo.";
                frm4.lblBolumİsmi.Text = lblEndokronolojiveMetabolizma.Text;

                frm4.lblBos.Text = lblBosEndokronolojiveMetabolizma.Text;
                frm4.lblDolu.Text = lblDoluEndokronolojiveMetabolizma.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxEndokronolojiveMetabolizma.Enabled = false;
            }
        }

        private void picBoxDermatoloji_Click(object sender, EventArgs e)
        {       
            if (lblDoluDermatoloji.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Dermatoloji";
                frm4.lblBransAdi2.Text = "Dermatoloji";
                frm4.lblBolumİsmi.Text = lblDermatoloji.Text;

                frm4.lblBos.Text = lblBosDermatoloji.Text;
                frm4.lblDolu.Text = lblDoluDermatoloji.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxDermatoloji.Enabled = false;
            }
        }

        private void picBoxOrtopediveTravma_Click(object sender, EventArgs e)
        {
            if (lblDoluOrtopediveTravma.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm4.lblBransAdi2.Text = "Ortopedi ve Travma";
                frm4.lblBolumİsmi.Text = lblOrtopediveTravma.Text;

                frm4.lblBos.Text = lblBosOrtopediveTravma.Text;
                frm4.lblDolu.Text = lblDoluOrtopediveTravma.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxOrtopediveTravma.Enabled = false;
            }
        }

        private void picBoxFizikselTıpveRehabilitasyon_Click(object sender, EventArgs e)
        {
            if (lblDoluFizikselTıpveRehabilitasyon.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilitasyon";
                frm4.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";
                frm4.lblBolumİsmi.Text = lblFizikselTıpveRehabilitasyon.Text;

                frm4.lblBos.Text = lblBosFizikselTıpveRehabilitasyon.Text;
                frm4.lblDolu.Text = lblDoluFizikselTıpveRehabilitasyon.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxFizikselTıpveRehabilitasyon.Enabled = false;
            }
        }

        private void picBoxNefroloji_Click(object sender, EventArgs e)
        {
            if (lblDoluNefroloji.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Nefroloji";
                frm4.lblBransAdi2.Text = "Nefroloji";
                frm4.lblBolumİsmi.Text = lblNefroloji.Text;

                frm4.lblBos.Text = lblBosNefroloji.Text;
                frm4.lblDolu.Text = lblDoluNefroloji.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxNefroloji.Enabled = false;
            }
        }

        private void picBoxHematoloji_Click(object sender, EventArgs e)
        {
            if (lblDoluHematoloji.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Hematoloji";
                frm4.lblBransAdi2.Text = "Hematoloji";
                frm4.lblBolumİsmi.Text = lblHematoloji.Text;

                frm4.lblBos.Text = lblBosHematoloji.Text;
                frm4.lblDolu.Text = lblDoluHematoloji.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxHematoloji.Enabled = false;
            }
        }

        private void picBoxRomatoloji_Click(object sender, EventArgs e)
        {
            if (lblDoluRomatoloji.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Romatoloji";
                frm4.lblBransAdi2.Text = "Romatoloji";
                frm4.lblBolumİsmi.Text = lblRomatoloji.Text;

                frm4.lblBos.Text = lblBosRomatoloji.Text;
                frm4.lblDolu.Text = lblDoluRomatoloji.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxRomatoloji.Enabled = false;
            }
        }

        private void picBoxÜroloji_Click(object sender, EventArgs e)
        {
            if (lblDoluÜroloji.Text != "15")
            {

                frm4.lblBransAdi1.Text = "Üroloji";
                frm4.lblBransAdi2.Text = "Üroloji";
                frm4.lblBolumİsmi.Text = lblÜroloji.Text;

                frm4.lblBos.Text = lblBosÜroloji.Text;
                frm4.lblDolu.Text = lblDoluÜroloji.Text;

                this.Refresh();
                this.Visible = false;

                frm4.ShowDialog();

            }
            else
            {
                picBoxÜroloji.Enabled = false;
            }
        }



        #endregion


        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
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

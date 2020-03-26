using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QandA_Wordyy_v1._0
{
    public partial class YöneticiPanel : Form
    {
        #region Tanımlamalar

        public static OleDbConnection Bağlantı; // Bağlantı Nesnesi
        
        İngilizce İForm = new İngilizce();
        OleDbCommand Komut;
        OleDbDataAdapter Kayıt;
        DataTable Tablo = new DataTable();
        DataTable Tablo2 = new DataTable();
        Random r = new Random();

        #endregion

        #region Değişkenler

        int KelimeSayısı = 0;

        int x1;

        int i = 31;

        int x;

        int ÇKS = 0;

        #endregion

        #region Metodlar
        public void databasebağlan()
        {
            Bağlantı = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=İNGİLİZCE SÖZLÜK.accdb"); // Veri Tabanı Bağlatısı

            if (Bağlantı.State == ConnectionState.Closed)  // Bağlantı Açıkmı Kontrolü 
            {
                Bağlantı.Open(); // Bağlantı Açtık
            }

            else
            {
                Bağlantı.Close(); // Açık Bağlantı varsa kapattık.
                Bağlantı.Open();  // Bağlatıyı Açtık
            }
        }

        public void GenelVeriÇek(string sorgux, OleDbCommand komutx, OleDbDataAdapter kayıtx, DataTable tablox)
        {
            databasebağlan(); // Databasebağlan metodu çağrıldı.
            tablox.Clear(); // Tablo Verilerini Temizledik
            tablox.Dispose();
            komutx = new OleDbCommand(sorgux, Bağlantı);  // Sorgumuzun komutunu çalıştırdık.
            kayıtx = new OleDbDataAdapter(komutx); // Komutla çağrılan değerler kayda alındı.
            kayıtx.Fill(tablox); // Kayıda gelen değerler tabloya aktarıldı.
            kayıtx.Dispose(); // Kayıt Temizlendi.
            Bağlantı.Dispose(); // Bağlantı Temizlendi.
            Bağlantı.Close(); // Bağlantı Kapatıldı.
        }

        #endregion

        public YöneticiPanel()
        {
            InitializeComponent();
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RadioKelime.Checked==true)
            {
                if (i>30)
                {
                    if (ÇKS<KelimeSayısı)
                    {
                        i = 0;
                        İForm.LabelDurum.Visible = false;
                        İForm.Textİngilizce.Text = Tablo2.Rows[ÇKS]["WORD"].ToString();
                        İForm.TextTürkçe.Text = Tablo2.Rows[ÇKS]["MEANS"].ToString();
                        ÇKS++;
                        İForm.Location = new Point((width / 2) - 270, height - 200);

                        if (ÇKS==KelimeSayısı)
                        {
                            İForm.LabelDurum.Visible = true;
                            İForm.LabelDurum.Text = "Tüm Kelimeler Çalışıldı...";
                        }
                    }

                    else
                    {
                        if (CheckedTekrar.Checked==true)
                        {
                            İForm.LabelDurum.Text = "Yeniden Başlıyor...";
                            ÇKS = 0;
                        }
                    }
                }

                else
                {
                    i++;
                }
            
            }

            else
            {
                if (i>30)
                {
                    i = 0;
                    İForm.LabelDurum.Visible = false;
                    İForm.Textİngilizce.Text = Tablo.Rows[ÇKS]["WORD"].ToString();
                    İForm.TextTürkçe.Text = Tablo.Rows[ÇKS]["MEANS"].ToString();
                    İForm.Location = new Point((width / 2) - 270, height - 200);
                }

                else
                {
                    i++;
                }
            }
           
        }

        
        private void PicKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RadioKelime.Checked==true)
            {
                Tablo2.Columns.Add("WORD", typeof(string));
                Tablo2.Columns.Add("MEANS", typeof(string));
                KelimeSayısı = Convert.ToInt16(numericUpDown1.Value);


                string Sorgu = "Select * from KELİMELER";
                databasebağlan();
                GenelVeriÇek(Sorgu, Komut, Kayıt, Tablo);

                for (int i1 = 0; i1 < KelimeSayısı; i1++)
                {
                    x1 = r.Next(0, 15);
                    Tablo2.Rows.Add(Tablo.Rows[x1]["WORD"].ToString(), Tablo.Rows[x1]["MEANS"].ToString());
                }
            }


            else
            {
                string Sorgu = "Select * from IngilizceTurkce";
                databasebağlan();
                GenelVeriÇek(Sorgu, Komut, Kayıt, Tablo);
            }
            this.Hide();
            İForm.Show();
            timer1.Start();
        }

       

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int height;
        int width;

        private void YöneticiPanel_Load(object sender, EventArgs e)
        {
            RadioKelime.Checked = true;
            width = Screen.PrimaryScreen.Bounds.Width;
            height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void kelimeSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadioKelime.Checked = true;
        }

        private void çalışmaSayısıBelirleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadioÇalışma.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RadioKelime_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioKelime.Checked == true)
            {
                panel3.Enabled = true;
            }

            else
            {
                panel3.Enabled = false;
            }
        }

       
    }
}

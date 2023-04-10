using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace EntitiesHastahane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void listele()
        {
            //Entitesten yeni nesne oluştur
            Entitieshastane yeniDurum = new Entitieshastane();

            //Entites içerisinde sql'e eriş
            var sonuc = (from sorgu in yeniDurum.hastakayıt select sorgu).ToList();
            //Erişilen sqlde bilgileri dataGridViewe ekle
            dataGridView1.DataSource = sonuc;
            //4.Sütunda özelliği tl şeklinde göster "c" tl demek
            dataGridView1.Columns[4].DefaultCellStyle.Format = "c";

        }
        private void Kaydet(object sender, EventArgs e)
        {
            try
            {
                //Kaydet buttonu tıklanınca şu olsun
                //Entitiesten yeni nesne oluşturur.
                Entitieshastane yeniDurum = new Entitieshastane();
                //Entities içerisinde hastakayıt tablosundan yeni nesne oluştur
                hastakayıt hastatablosu = new hastakayıt();
                //hastatablosunda doktoradı alanına textboxtan gelen değeri yaz
                hastatablosu.DOKTORADI = Text_Doktor.Text;
                //hastatablosunda hastaadı alanına textboxtan gelen değeri yaz
                hastatablosu.HASTADI = Text_Hasta.Text;
                //Textboxa ekle datetimePickerdan gelen değeri
                Text_Tarıh.Text = dateTimePicker1.Text;
                //hastatablosunda tarih alanına dateTimePicketdan gelen değeri yaz
                hastatablosu.TARIH = dateTimePicker1.Value;
                //hastatablosunda ucrey alanına textboxtan gelen değeri yaz
                hastatablosu.UCRET = Convert.ToDecimal(Text_Ucret.Text);
                //yeniDurum objesinde hastakayıt tablasonu ekle hastatablosu objesini.
                yeniDurum.hastakayıt.Add(hastatablosu);
                //yeniDurum objesinde yapılan işlemleri kaydet.
                yeniDurum.SaveChanges();
                //Mesaj göster kayıt tamamlandı diye
                MessageBox.Show("Kayıt İşlemi Tamamlandı");
                //Listele metotunu çağır
                listele();
                //For ile dön metoto içerisinin sayısı kadar ve metot içerisinde textbox olan değerlerin içini boşalt.
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is TextBox) this.Controls[i].Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Giriş hatası");    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listele();
        }

        private void sorgu(object sender, EventArgs e)
        {
            //Entites içerisinden yeniDurum objesi oluştu
            Entitieshastane yeniDurum = new Entitieshastane();
            // sorgulama yapılıyor yeniDurum objesi içerisindeki hastakayıt tablsundan 3 alanı var doktoradı,hastaadı,ödemetutarı,
            //Sorguyu yap ve sonuca liste şeklinde ekle 
            var sonuc = from sorgu in yeniDurum.hastakayıt
                        select new
                        {
                            doktoradı = sorgu.DOKTORADI,
                            hastaadı = sorgu.HASTADI,
                            ödemetutar = sorgu.UCRET
                        };
            dataGridView1.DataSource = sonuc.ToList();
            //ödemetutaru alanına format olarak c yani tl ekle
            dataGridView1.Columns[2].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

        }

        private void listele(object sender, EventArgs e)
        {
            listele();
        }

        private void sil(object sender, EventArgs e)
        {
            try
            {
                //Entitieshastane içerisinde sil objesi oluştur.
                Entitieshastane sil = new Entitieshastane();
                // sonuc değişkenine sil objesinde hastakayıt a sorgu yap sorgu hasta adı ile Text hastaadı yazısı içerisindeki eşit ise sorguyu seç birinci veya varsayılana sorguyu uygula.
                var sonuc = (from sorgu in sil.hastakayıt where sorgu.HASTADI == Text_Hasta.Text select sorgu).FirstOrDefault();
                //Sil nesnesinden sil sonuc değişkeninde değerleri
                sil.hastakayıt.Remove(sonuc);
                // yapılan işlemleri kaydet
                sil.SaveChanges();
                // Kayıt silindi mesajı ver 
                MessageBox.Show("Kayıt silindi");
                //Listele metodu çağır
                listele();
                Text_Hasta.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı işlem .");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Text_Hasta.Text != "")
                {
                    //Linq ile silme
                    Entitieshastane sillinq = new Entitieshastane();
                    int sonuc = sillinq.Database.ExecuteSqlCommand("Delete from hastakayıt where HASTADI = @HASTADI",
                       new SqlParameter("@HASTADI", Text_Hasta.Text));
                    MessageBox.Show("Kayıt silindi");
                    listele();
                }
                else
                {
                    MessageBox.Show("Hatalı işlem");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı işlem");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //Güncelleme işlemi
                DialogResult degistir = MessageBox.Show(this, "  Bu kaydı  değiştir..", "DİKKAT", MessageBoxButtons.YesNo);
                if (degistir == DialogResult.Yes)
                {
                    Entitieshastane kayıtdegistir = new Entitieshastane();
                    var sonuc = (from sorgu in kayıtdegistir.hastakayıt
                                 where sorgu.DOKTORADI == Text_Doktor.Text
                                 select sorgu).ToList();
                    sonuc[0].HASTADI = Text_Hasta.Text;
                    sonuc[1].TARIH = Convert.ToDateTime(dateTimePicker1.Text);
                    sonuc[2].UCRET = Convert.ToDecimal(Text_Ucret.Text);
                    kayıtdegistir.SaveChanges(); // son değişikliği yap ve 
                    listele();
                    MessageBox.Show("Kayıt değişti");

                }
                else
                {
                    MessageBox.Show("Kayıt değişimi iptal edildi");
                }
            }
            catch
            {
                MessageBox.Show("Hatalı işlem");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {// Doktor  Bulma işlemi
            try
            {
                if (Text_Bul_Doktor.Text != "")
                {
                    Entitieshastane yeniDurum = new Entitieshastane();
                    var sonuc = from sorgu in yeniDurum.hastakayıt
                                where sorgu.DOKTORADI == Text_Bul_Doktor.Text
                                select new
                                {
                                    doktoradı = sorgu.DOKTORADI,
                                    hastaadı = sorgu.HASTADI,
                                    odemetutar = sorgu.UCRET
                                };
                    dataGridView1.DataSource = sonuc.ToList();
                }
                else
                {
                    MessageBox.Show("Hatalı işlem");
                }
            }
            catch
            {
                MessageBox.Show("Hatalı işlem");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (Text_Bul_Hasta.Text != "")
                {
                    // Hasta  Bulma işlemi
                    Entitieshastane yeniDurum = new Entitieshastane();
                    var sonuc = from sorgu in yeniDurum.hastakayıt
                                where sorgu.HASTADI == Text_Bul_Hasta.Text
                                select new
                                {
                                    doktoradı = sorgu.DOKTORADI,
                                    hastaadı = sorgu.HASTADI,
                                    odemetutar = sorgu.UCRET
                                };
                    dataGridView1.DataSource = sonuc.ToList();
                }
                else
                {
                    MessageBox.Show("Hatalı işlem");
                }
            }
            catch
            {
                MessageBox.Show("Hatalı işlem");
            }


        }

        private void button10_Click(object sender, EventArgs e)
        { //Ödeme toplamı
            Entitieshastane yeniDurum = new Entitieshastane();
            var sonuc = from sorgu in yeniDurum.hastakayıt
                        group sorgu by sorgu.HASTADI
                        into toplamtutar
                        select new
                        {
                            hastaadı = toplamtutar.Key,
                            toplamtutar=toplamtutar.Sum(r => r.UCRET),
                        };

            dataGridView1.DataSource = sonuc.ToList();
            dataGridView1.Columns[1].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

        }

        private void button11_Click(object sender, EventArgs e)
        {  //Order sıralamak
            Entitieshastane yeniDurum = new Entitieshastane();
            var sonuc = (from sorgu in yeniDurum.hastakayıt orderby sorgu.HASTADI ascending select sorgu).ToList();
            dataGridView1.DataSource = sonuc.ToList();
            dataGridView1.Columns[2].DefaultCellStyle.Format = "c";
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

        }
    }
    }


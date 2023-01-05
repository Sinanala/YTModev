using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ymtOtelSon
{
     
    public partial class Kayit1 : Form 
    {
       
        
        public Kayit1()
        {
            InitializeComponent();
            

        }
       
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8NKE2M3\\SQLEXPRESS;Initial Catalog=ymtOtelSon;Integrated Security=True");

        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select*from MusteriEkle1", baglanti);
            SqlDataReader oku= komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musterid"].ToString();
                ekle.SubItems.Add(oku["Adı"].ToString());
                ekle.SubItems.Add(oku["Soyadı"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);  

            }
            baglanti.Close();
        }
        private void Kayit1_Load(object sender, EventArgs e)
        {
            cmbBoxOdaNo.Items.Add("A101");
            cmbBoxOdaNo.Items.Add("A102");
            cmbBoxOdaNo.Items.Add("A103");
            cmbBoxOdaNo.Items.Add("A104");
            cmbBoxOdaNo.Items.Add("A105");
            cmbBoxOdaNo.Items.Add("A106");
            cmbBoxOdaNo.Items.Add("B201");
            cmbBoxOdaNo.Items.Add("B202");
            cmbBoxOdaNo.Items.Add("B203");
            cmbBoxOdaNo.Items.Add("B204");
            cmbBoxOdaNo.Items.Add("B205");
            cmbBoxOdaNo.Items.Add("B206");
            cmbBoxOdaNo.Items.Add("C301");
            cmbBoxOdaNo.Items.Add("C302");
            cmbBoxOdaNo.Items.Add("C303");
            cmbBoxOdaNo.Items.Add("C304");
            cmbBoxOdaNo.Items.Add("C305");
            cmbBoxOdaNo.Items.Add("C306");
            cmbBoxOdaNo.Items.Add("D401");
            cmbBoxOdaNo.Items.Add("D402");
            cmbBoxOdaNo.Items.Add("D403");
            cmbBoxOdaNo.Items.Add("D404");
            cmbBoxOdaNo.Items.Add("D405");
            cmbBoxOdaNo.Items.Add("D406");

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int ucret;

            DateTime kucukTarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime buyukTarih = Convert.ToDateTime(dateTimePicker2.Text);

            TimeSpan sonuc = buyukTarih - kucukTarih;

            label10.Text=sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label10.Text) * 150;

           txtUcret.Text=ucret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//kaydetbutonu
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle1(Adı,Soyadı,Telefon,Mail,Tc,OdaNo,Ucret,GirisTarihi,CikisTarihi)values('"+txtAdi.Text +"','"+txtSoyadi.Text+"','"+msktxtTelefon.Text +"','"+txtboxMail.Text +"','"+ txtTc.Text+"','"+cmbBoxOdaNo.Text + "','"+txtUcret.Text +"','"+dateTimePicker1.Value.ToString("yyyy-MM-dd") +"','"+ dateTimePicker2.Value.ToString("yyyy-MM-dd") +"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı");
        }

        private void button5_Click(object sender, EventArgs e)//göster butonu
        {
            verileriGoster();
        }


        int id = 0;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle1 set Adı='" + txtAdi.Text + "',Soyadı='" + txtSoyadi.Text + "',Telefon='" + msktxtTelefon.Text + "',Mail='" + txtboxMail.Text + "',Tc='" + txtTc.Text + "',OdaNo='" + cmbBoxOdaNo.Text + "',Ucret='" + txtUcret.Text + "',GirisTarihi='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' where Musterid=" + id + "", baglanti);
            komut.ExecuteNonQuery(); 
            baglanti.Close();
            verileriGoster();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle1 where Musterid=("+id+")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

       
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            msktxtTelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtboxMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtTc.Text = listView1.SelectedItems[0].SubItems[5].Text;
            cmbBoxOdaNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[9].Text;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            msktxtTelefon.Clear();
            txtboxMail.Clear();
            txtTc.Clear();
            cmbBoxOdaNo.Text = "";
            txtUcret.Clear();
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select*from MusteriEkle1 where Adı like'%"+textBox6.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musterid"].ToString();
                ekle.SubItems.Add(oku["Adı"].ToString());
                ekle.SubItems.Add(oku["Soyadı"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
    }
}

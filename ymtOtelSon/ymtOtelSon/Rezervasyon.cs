using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ymtOtelSon
{

    
    public partial class Form1 : Form
    {
        KayıtYap kayit =new KayıtYap();

        public Form1()
        {
            InitializeComponent();
            
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8NKE2M3\\SQLEXPRESS;Initial Catalog=ymtOtelSon;Integrated Security=True");

        Kayit1 kayitbir= new Kayit1();
        private void Form1_Load(object sender, EventArgs e)
        {
            odaYaz();
        }
        void odaYaz()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle1", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                switch (oku[6].ToString())
                {
                    case "A101":
                        {
                            A101.Text = oku[6].ToString();
                            A101.BackColor = Color.Gray;
                            break;
                        }
                    case "A102":
                        {
                            A102.Text = oku[6].ToString();
                            A102.BackColor = Color.Gray;
                            break;
                        }
                    case "A103":
                        {
                            A103.Text = oku[6].ToString();
                            A103.BackColor = Color.Gray;
                            break;
                        }
                    case "A104":
                        {
                            A104.Text = oku[6].ToString();
                            A104.BackColor = Color.Gray;
                            break;
                        }
                    case "A105":
                        {
                            A105.Text = oku[6].ToString();
                            A105.BackColor = Color.Gray;
                            break;
                        }
                    case "A106":
                        {
                            A106.Text = oku[6].ToString();
                            A106.BackColor = Color.Gray;
                            break;
                        }
                    case "B201":
                        {
                            B201.Text = oku[6].ToString();
                            B201.BackColor = Color.Gray;
                            break;
                        }
                    case "B202":
                        {
                            B202.Text = oku[6].ToString();
                            B202.BackColor = Color.Gray;
                            break;
                        }
                    case "B203":
                        {
                            B203.Text = oku[6].ToString();
                            B203.BackColor = Color.Gray;
                            break;
                        }
                    case "B204":
                        {
                            B204.Text = oku[6].ToString();
                            B204.BackColor = Color.Gray;
                            break;
                        }
                    case "B205":
                        {
                            B205.Text = oku[6].ToString();
                            B205.BackColor = Color.Gray;
                            break;
                        }
                    case "B206":
                        {
                            B206.Text = oku[6].ToString();
                            B206.BackColor = Color.Gray;
                            break;
                        }
                    case "C301":
                        {
                            C301.Text = oku[6].ToString();
                            C301.BackColor = Color.Gray;
                            break;
                        }
                    case "C302":
                        {
                            C302.Text = oku[6].ToString();
                            C302.BackColor = Color.Gray;
                            break;
                        }
                    case "C303":
                        {
                            C303.Text = oku[6].ToString();
                            C303.BackColor = Color.Gray;
                            break;
                        }
                    case "C304":
                        {
                            C304.Text = oku[6].ToString();
                            C304.BackColor = Color.Gray;
                            break;
                        }
                    case "C305":
                        {
                            C305.Text = oku[6].ToString();
                            C305.BackColor = Color.Gray;
                            break;
                        }
                    case "C306":
                        {
                            C306.Text = oku[6].ToString();
                            C306.BackColor = Color.Gray;
                            break;
                        }
                    case "D401":
                        {
                            D401.Text = oku[6].ToString();
                            D401.BackColor = Color.Gray;
                            break;
                        }
                    case "D402":
                        {
                            D402.Text = oku[6].ToString();
                            D402.BackColor = Color.Gray;
                            break;
                        }
                    case "D403":
                        {
                            D403.Text = oku[6].ToString();
                            D403.BackColor = Color.Gray;
                            break;
                        }
                    case "D404":
                        {
                            D404.Text = oku[6].ToString();
                            D404.BackColor = Color.Gray;
                            break;
                        }
                    case "D405":
                        {
                            D405.Text = oku[6].ToString();
                            D405.BackColor = Color.Gray;
                            break;
                        }
                    case "D406":
                        {
                            D406.Text = oku[6].ToString();
                            D406.BackColor = Color.Gray;
                            break;
                        }

                }

            }
            
            baglanti.Close();
            oku.Close();


        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void A101_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void A102_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void A103_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void A104_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void A105_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void A106_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void B201_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void B202_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void B203_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void B204_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void B205_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void B206_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void C301_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void C302_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void C303_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void C304_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();

            
        }

        private void C305_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void C306_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void D401_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void D402_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
            
           
        }

        private void D403_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void D404_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void D405_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }

        private void D406_Click(object sender, EventArgs e)
        {
            kayit.kayitGoster1();
        }
    }



    class KayıtYap
    {
        public void kayitGoster1()
        {
            Kayit1 kayit1 = new Kayit1();
            kayit1.Show();
        }
    }
}

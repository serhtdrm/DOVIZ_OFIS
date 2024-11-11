using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml;
using System.Windows.Forms;
using System.Security.Policy;

namespace doviz_ofis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SerhatDemir\SQLEXPRESS;Initial Catalog=dbofis;Integrated Security=True;");
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);
            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldolaralis.Text = dolaralis;
            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbldolarsatis.Text = dolarsatis;
            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleuroalis.Text = euroalis;
            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleurosatis.Text = eurosatis;
        }

        private void btndolaral_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolaralis.Text;
        }

        private void btndolarsat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolarsatis.Text;
        }

        private void btneuroal_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleurosatis.Text;
        }

        private void btneurosat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleuroalis.Text;
        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".", ",");
        }

        private void btnsatisyap_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtkur.Text);
            miktar = Convert.ToDouble(txtmiktar.Text);
            tutar = miktar * kur;
            txttutar.Text = tutar.ToString() + "TL";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tblofis(TL,DOLAR,EURO)  values(@P1,@P2,@P3)", baglanti);
           
            komut.Parameters.AddWithValue("@P1", txttutar.Text);
            komut.Parameters.AddWithValue("@P2", txtmiktar.Text);
            komut.Parameters.AddWithValue("@P3", txtmiktar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("HAZİNEYE  EKLENDİ ");
        }

        private void btnsatisyap2_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(txtkur.Text);
            int miktar = Convert.ToInt32(txtmiktar.Text);
            int tutar = Convert.ToInt32(miktar/kur);
            txttutar.Text = tutar.ToString()+ "birim" ;
            int kalan;
            kalan = miktar %tutar;
            txtkalan.Text = kalan.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tblofis(TL,DOLAR,EURO)  values(@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtmiktar.Text);
            komut.Parameters.AddWithValue("@P2", txttutar.Text);
            komut.Parameters.AddWithValue("@P3", txttutar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("HAZİNEYE  EKLENDİ ");


        }
    }
}

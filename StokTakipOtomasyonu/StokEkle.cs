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

namespace StokTakipOtomasyonu
{
	public partial class StokEkle : Form
	{
		public StokEkle()
		{
			InitializeComponent();
		}
		DBConnection connection = new DBConnection();
		private void StokEkle_Load(object sender, EventArgs e)
		{
			// TODO: Bu kod satırı 'stokTakipOtomasyonuDataSet12.Kategoriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.kategorilerTableAdapter1.Fill(this.stokTakipOtomasyonuDataSet12.Kategoriler);
			// TODO: Bu kod satırı 'stokTakipOtomasyonuDataSet11.Markalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
			this.markalarTableAdapter.Fill(this.stokTakipOtomasyonuDataSet11.Markalar);

		}
		public static string durum;
		LoadingForm bekle = new LoadingForm();
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			try
			{
				if ((txtUrunAdi.Text != "") || (txtAlisFiyat.Text == ""))
				{
					if (txtSatisFiyat.Text != "")
					{
						SqlCommand cmd = new SqlCommand("insert into Urunler(UrunAdi,UrunKodu,ModelAdi,MarkaId,KategoriId,StokAdeti,AlisFiyati,SatisFiyati) Values(@urunAdi,@urunKodu,@modelAdi,@markaId,@kategoriId,@stokAdeti,@alisFiyati,@satisFiyati)", connection.baglanti());
						cmd.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
						cmd.Parameters.AddWithValue("@urunKodu", txtUrunKodu.Text);
						cmd.Parameters.AddWithValue("@markaId", cmbMarka.SelectedValue);
						cmd.Parameters.AddWithValue("@modelAdi", txtModel.Text);
						cmd.Parameters.AddWithValue("@stokAdeti", numericStokAdeti.Value);
						cmd.Parameters.AddWithValue("@kategoriId", cmbKategori.SelectedValue);
						cmd.Parameters.AddWithValue("@alisFiyati", txtAlisFiyat.Text);
						cmd.Parameters.AddWithValue("@satisFiyati", txtSatisFiyat.Text);
						int id = cmd.ExecuteNonQuery();
						connection.baglanti().Close();
						durum = "success";
						bekle.ShowDialog();
					}
					else
					{
						MessageBox.Show("Doldurulması zorunlu alanları doldurunuz.", "Hata Mesajı", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
					}
				}
			}
			catch (Exception)
			{
				durum = "error";
				bekle.ShowDialog();
			}
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
	} 
	

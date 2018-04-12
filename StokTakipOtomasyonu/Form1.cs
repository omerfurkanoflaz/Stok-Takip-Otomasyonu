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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		#region Tanımlamalar
		string metinselGuvenlikKodu, parola, kullaniciAdi;
		string guvenlikKodu;
		Form2 frm2 = new Form2();
		DBConnection connection = new DBConnection();
		#endregion

		private void Form1_Load(object sender, EventArgs e)
		{
			rchtxtGuvenlikKodu.MaxLength = 4; 
			Random rnd_rastgeleGüvenlikKodu = new Random(); //rastgele sayılardan oluşan güvenlik kodu oluşturmak için Random sınıfından nesne türettim.

			int sayisalGüvenlikKodu;

			int[] diziGüvenlikKodu = new int[4]; //int tipinde 4 karaskter uzunluğunda dizi tanımladım.

			int artim = 0;

			for (int i = 1; i <= 4; i++)
			{
				sayisalGüvenlikKodu = rnd_rastgeleGüvenlikKodu.Next(1, 10); //1 ile 10 arasında sayı ürettim onu da değişkene attım.
				diziGüvenlikKodu[artim] = sayisalGüvenlikKodu;
				++artim;
			}

			metinselGuvenlikKodu = diziGüvenlikKodu[0].ToString() + diziGüvenlikKodu[1].ToString() + diziGüvenlikKodu[2].ToString() + diziGüvenlikKodu[3].ToString();
			rchtxtGuvenlikKodu.Text = metinselGuvenlikKodu;

		}

		
		private void simpleButton1_Click(object sender, EventArgs e)
		{
		
				kullaniciAdi = txtKullaniciAdi.Text;
				parola = txtParola.Text;
				guvenlikKodu = txtGuvenlikKodu.Text;


				if  ((kullaniciAdi != "") && (parola != ""))
				{
					if ((guvenlikKodu.ToString() == metinselGuvenlikKodu))
					{
					SqlCommand cmd = new SqlCommand("Select *From Kullanicilar Where KullaniciAdi=@value1 and KullaniciSifre=@value2", connection.baglanti());
					cmd.Parameters.AddWithValue("@value1", txtKullaniciAdi.Text);
					cmd.Parameters.AddWithValue("@value2", txtParola.Text);
					SqlDataReader dr = cmd.ExecuteReader();
					if (dr.Read())
					{
						this.Visible = false;
						frm2.ShowDialog();
					}
					else
					{
						MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre girdiniz.Tekrar deneyiniz.");
					}
					connection.baglanti().Close();

					}
				}
			#region Kullanici Adi KontrolüD:\stok\1\StokTakipOtomasyonu\StokTakipOtomasyonu\Form2.cs

			if (kullaniciAdi == "")
				dxErrorKullaniciAdi.SetError(txtKullaniciAdi, "Kullanıcı Adı alanı boş bırakılamaz.");
			else
				dxErrorKullaniciAdi.ClearErrors();

			#endregion

			#region Parola Kontrolü

			if (parola == "")
					dxErrorParola.SetError(txtParola, "Parola alanı boş bırakılamaz.");
				else if (parola.Length < 8)
					dxErrorParola.SetError(txtParola, "Parola en az 8 karakter uzunluğunda olmalıdır.");
				else
					dxErrorParola.ClearErrors();

				#endregion

			#region Güvenlik Kodu Kontrolü

				if ((guvenlikKodu.ToString() != metinselGuvenlikKodu)||(guvenlikKodu.ToString().Length != 4))
					dxErrorGuvenlikKodu.SetError(txtGuvenlikKodu, "Güvenlik Kodunu doğru giriniz.");

				if ((guvenlikKodu.ToString() == metinselGuvenlikKodu))
					dxErrorGuvenlikKodu.ClearErrors();

			#endregion

		
			}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace StokTakipOtomasyonu
{
	public partial class Stokİslemleri : Form
	{
		public Stokİslemleri()
		{
			InitializeComponent();
		}
		DBConnection connection = new DBConnection();
		private void StokEkle_Load(object sender, EventArgs e)
		{

			SqlCommand com = new SqlCommand(@"SELECT Urunler.UrunId AS [Ürün ID], Urunler.UrunKodu AS[Ürün Kodu],Urunler.UrunAdi AS [Ürün Adı],Kategoriler.KategoriAdi As[Kategori Adı],Urunler.StokAdeti,Urunler.ModelAdi AS[Model Adı], Markalar.MarkaAdi As [Marka Adı],Urunler.AlisFiyati AS[Alış Fiyatı],Urunler.SatisFiyati As[Satış Fiyatı] FROM Urunler inner join Markalar on Markalar.MarkaId=Urunler.MarkaId join Kategoriler on Kategoriler.KategoriId=Urunler.KategoriId", connection.baglanti());
			SqlDataAdapter da = new SqlDataAdapter(com);
			DataSet ds = new DataSet();
			da.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
			dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
			dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

		}

		
		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
			dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

			e.Graphics.DrawImage(objBmp, 20, 120);
			e.Graphics.DrawString(label1.Text, new Font("Verdana", 22, FontStyle.Bold), Brushes.Black,new Point(100,30));
		}

		private void btnYazdir_Click(object sender, EventArgs e)
		{
			printPreviewDialog1.Document = printDocument1;
			PrintDialog yazdir = new PrintDialog();
			yazdir.Document = printDocument1;
			yazdir.UseEXDialog = true;
			if (yazdir.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}
	}
}
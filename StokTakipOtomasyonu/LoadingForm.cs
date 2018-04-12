using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
	public partial class LoadingForm : Form
	{
		public LoadingForm()
		{
			InitializeComponent();
		}
		
		private void LoadingForm_Load(object sender, EventArgs e)
		{
			string durum = StokEkle.durum;
			if (durum == "success")
			{
				pictureBox1.Image =Image.FromFile(Application.StartupPath + "\\checkmark.gif");
				label1.Text = "İşlem Başarılı";
				label2.Text = "İşleminizi başarılı bir şekilde gerçekleştirdiniz.";
			}
			else
			{
				pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\error2.gif");
				label1.Text = "İşlem Başarısız";
				label2.Text = "Hata! Lütfen tekrar deneyiniz.";
			}
		}

		private void simpleButton1_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

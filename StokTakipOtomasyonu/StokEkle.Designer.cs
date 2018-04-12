namespace StokTakipOtomasyonu
{
	partial class StokEkle
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokEkle));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.numericStokAdeti = new System.Windows.Forms.NumericUpDown();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipOtomasyonuDataSet12 = new StokTakipOtomasyonu.StokTakipOtomasyonuDataSet12();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.txtAlisFiyat = new System.Windows.Forms.TextBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.markalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakipOtomasyonuDataSet11 = new StokTakipOtomasyonu.StokTakipOtomasyonuDataSet11();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.markalarTableAdapter = new StokTakipOtomasyonu.StokTakipOtomasyonuDataSet11TableAdapters.MarkalarTableAdapter();
            this.kategorilerTableAdapter1 = new StokTakipOtomasyonu.StokTakipOtomasyonuDataSet12TableAdapters.KategorilerTableAdapter();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunKodu = new System.Windows.Forms.MaskedTextBox();
            this.dxErrorUrunAdi = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorAlisFiyati = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxErrorSatisFiyati = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericStokAdeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorUrunAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorAlisFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorSatisFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürün Adı:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(107, 104);
            this.txtUrunAdi.Multiline = true;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(267, 27);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(15, 198);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 20);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Marka Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 301);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 20);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Stok Adeti:";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(107, 248);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(267, 27);
            this.txtModel.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 253);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 20);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Model Adı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 404);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 20);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Alış Fiyatı:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 352);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 20);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Kategori:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(17, 460);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 20);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Satış Fiyatı:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Location = new System.Drawing.Point(237, 506);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(137, 53);
            this.btnKaydet.TabIndex = 25;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // numericStokAdeti
            // 
            this.numericStokAdeti.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericStokAdeti.Location = new System.Drawing.Point(107, 299);
            this.numericStokAdeti.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericStokAdeti.Name = "numericStokAdeti";
            this.numericStokAdeti.Size = new System.Drawing.Size(267, 23);
            this.numericStokAdeti.TabIndex = 26;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DataSource = this.bindingSource1;
            this.cmbKategori.DisplayMember = "KategoriAdi";
            this.cmbKategori.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 18;
            this.cmbKategori.Location = new System.Drawing.Point(107, 349);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(267, 26);
            this.cmbKategori.TabIndex = 22;
            this.cmbKategori.ValueMember = "KategoriId";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Kategoriler";
            this.bindingSource1.DataSource = this.stokTakipOtomasyonuDataSet12;
            // 
            // stokTakipOtomasyonuDataSet12
            // 
            this.stokTakipOtomasyonuDataSet12.DataSetName = "StokTakipOtomasyonuDataSet12";
            this.stokTakipOtomasyonuDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyat.Location = new System.Drawing.Point(107, 454);
            this.txtSatisFiyat.Multiline = true;
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(267, 31);
            this.txtSatisFiyat.TabIndex = 28;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisFiyat.Location = new System.Drawing.Point(107, 399);
            this.txtAlisFiyat.Multiline = true;
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Size = new System.Drawing.Size(267, 31);
            this.txtAlisFiyat.TabIndex = 29;
            // 
            // cmbMarka
            // 
            this.cmbMarka.DataSource = this.markalarBindingSource;
            this.cmbMarka.DisplayMember = "MarkaAdi";
            this.cmbMarka.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(107, 195);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(267, 26);
            this.cmbMarka.TabIndex = 30;
            this.cmbMarka.ValueMember = "MarkaId";
            // 
            // markalarBindingSource
            // 
            this.markalarBindingSource.DataMember = "Markalar";
            this.markalarBindingSource.DataSource = this.stokTakipOtomasyonuDataSet11;
            // 
            // stokTakipOtomasyonuDataSet11
            // 
            this.stokTakipOtomasyonuDataSet11.DataSetName = "StokTakipOtomasyonuDataSet11";
            this.stokTakipOtomasyonuDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(287, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 86);
            this.pictureEdit1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "Stok Ekleme Paneli";
            // 
            // markalarTableAdapter
            // 
            this.markalarTableAdapter.ClearBeforeFill = true;
            // 
            // kategorilerTableAdapter1
            // 
            this.kategorilerTableAdapter1.ClearBeforeFill = true;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(15, 152);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(76, 20);
            this.labelControl8.TabIndex = 33;
            this.labelControl8.Text = "Ürün Kodu:";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunKodu.Location = new System.Drawing.Point(107, 151);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(267, 23);
            this.txtUrunKodu.TabIndex = 35;
            // 
            // dxErrorUrunAdi
            // 
            this.dxErrorUrunAdi.ContainerControl = this;
            // 
            // dxErrorAlisFiyati
            // 
            this.dxErrorAlisFiyati.ContainerControl = this;
            // 
            // dxErrorSatisFiyati
            // 
            this.dxErrorSatisFiyati.ContainerControl = this;
            // 
            // StokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 571);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.txtAlisFiyat);
            this.Controls.Add(this.txtSatisFiyat);
            this.Controls.Add(this.numericStokAdeti);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.labelControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "StokEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokEkle";
            this.Load += new System.EventHandler(this.StokEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericStokAdeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakipOtomasyonuDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorUrunAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorAlisFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorSatisFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.TextBox txtUrunAdi;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.TextBox txtModel;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.SimpleButton btnKaydet;
		private System.Windows.Forms.BindingSource stokTakipOtomasyonuDataSetBindingSource;
		private System.Windows.Forms.BindingSource kategorilerBindingSource;
		private System.Windows.Forms.NumericUpDown numericStokAdeti;
		private System.Windows.Forms.ComboBox cmbKategori;
		private System.Windows.Forms.TextBox txtSatisFiyat;
		private System.Windows.Forms.TextBox txtAlisFiyat;
		private System.Windows.Forms.ComboBox cmbMarka;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private System.Windows.Forms.Label label1;
		private StokTakipOtomasyonuDataSet11 stokTakipOtomasyonuDataSet11;
		private System.Windows.Forms.BindingSource markalarBindingSource;
		private StokTakipOtomasyonuDataSet11TableAdapters.MarkalarTableAdapter markalarTableAdapter;
		private StokTakipOtomasyonuDataSet12 stokTakipOtomasyonuDataSet12;
		private System.Windows.Forms.BindingSource bindingSource1;
		private StokTakipOtomasyonuDataSet12TableAdapters.KategorilerTableAdapter kategorilerTableAdapter1;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private System.Windows.Forms.MaskedTextBox txtUrunKodu;
		private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorUrunAdi;
		private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorAlisFiyati;
		private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorSatisFiyati;
	}
}
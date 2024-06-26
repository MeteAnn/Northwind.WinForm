using Northwind.ORM.Entity;
using Northwind.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinFormUI
{
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {

            CmbKategori.DisplayMember = "KategoriAdi";
            CmbKategori.ValueMember = "KategoriID";
            CmbKategori.DataSource = Kategoriler.Select();

            CmbTedarikci.DisplayMember = "SirketAdi";
            CmbTedarikci.ValueMember = "TedarikciID";
            CmbTedarikci.DataSource = Tedarikciler.Select();

            dataGridView1.DataSource = Urunler.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Urun u = new Urun();
            u.UrunAdi = txtAdi.Text;
            u.Fiyat = NupFiyat.Value;
            u.Stok = Convert.ToInt16(NupStok.Value);
            u.KategoriID = (int)CmbKategori.SelectedValue;
            u.TedarikciID = (int)CmbTedarikci.SelectedValue;
            bool sonuc = Urunler.Insert(u);

            if (sonuc)
            {


                MessageBox.Show("Kayıt Eklenmiştir");
                dataGridView1.DataSource = Urunler.Select();


            }
            else
            {
                MessageBox.Show("Kayıt Eklenirken Hata Oluştu");



            }














        }
    }
}

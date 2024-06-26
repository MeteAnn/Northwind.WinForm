using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.ORM.Entity;
using Northwind.ORM.Facade;


namespace Northwind.WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void KategoriListele()
        {


            dataGridView1.DataSource = Kategoriler.Select();
            dataGridView1.Columns["KategoriID"].Visible = false;

        }


        private void Form1_Load(object sender, EventArgs e)
        {




            KategoriListele();





        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Kategori ktg = new Kategori();
            ktg.KategoriAdi = txtName.Text;
            ktg.Tanimi = txtTanimi.Text;

            bool sonuc = Kategoriler.Insert(ktg);

            if (sonuc)
            {
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklenmiştir.");
                KategoriListele();
            }
            else
            {
                MessageBox.Show("Kategori Eklerken Hata Meydana Geldi");



            }
                



        }
    }
}

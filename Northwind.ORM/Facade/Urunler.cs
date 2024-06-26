using Microsoft.Data.SqlClient;
using Northwind.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.ORM.Facade
{
    public class Urunler
    {
        //Select Metodu

        public static DataTable Select()
        {

            SqlDataAdapter adp = new SqlDataAdapter("prc_UrunListele",Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();

            adp.Fill(dt);

            return dt;




        }


        //Insert Metodu
        public static bool Insert(Urun u)
        {

            SqlCommand cmd = new SqlCommand("prc_UrunEkle",Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UrunAdi",u.UrunAdi);
            cmd.Parameters.AddWithValue("@fiyat",u.Fiyat);
            cmd.Parameters.AddWithValue("@stok",u.Stok);
            cmd.Parameters.AddWithValue("kId",u.KategoriID);
            cmd.Parameters.AddWithValue("tId", u.TedarikciID);


           return Tools.ExecuteNonQuery(cmd);



        }



    }
}

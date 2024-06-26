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
    public class Kategoriler
    {
        

        //Select Metodu
        public static DataTable Select()
        {

            SqlDataAdapter adp = new SqlDataAdapter("prc_KategoriListele", Tools.Baglanti);

            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            adp.Fill(dt);

            return dt;


        }




        //Insert Metodu
        public static bool Insert(Kategori k)
        {

            SqlCommand cmd = new SqlCommand("prc_KategoriEkle",Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@adi",k.KategoriAdi);
            cmd.Parameters.AddWithValue("@tanim",k.Tanimi);


            return Tools.ExecuteNonQuery(cmd);;


         
        }







        //Update Metodu
        //Delete Metodu






    }
}

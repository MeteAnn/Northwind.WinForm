using Microsoft.Data.SqlClient;
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
        //Update Metodu
        //Delete Metodu






    }
}

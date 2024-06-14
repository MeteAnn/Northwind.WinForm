using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Northwind.ORM
{
    public class Tools
    {
		//SqlConnection baglanti = new SqlConnection("Server=DESKTOP-C6NAGE9\\SQLEXPRESS;Database=Northwind;Integrated security=true");

		private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
		
		 


		public static SqlConnection Baglanti
		{
			get { return baglanti; }
			
		}




	}
}

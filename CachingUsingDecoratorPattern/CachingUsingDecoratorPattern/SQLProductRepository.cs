using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_CachingAndDecoratorPattern
{
    class SQLProductRepository : IRepository
    {
        private SqlConnection sqlconnection;
        private void connection()
        {
            string constr = @"Data Source=TAVDESK145;Initial Catalog=Products; User Id=sa;Password=test123!@#";
            sqlconnection = new SqlConnection(constr);

        } 
        public List<Product> GetAllProducts()
        {
            connection();
            List<Product> productList = new List<Product>();
            string query = "SELECT * FROM Products";
            SqlCommand command = new SqlCommand(query, sqlconnection)
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlconnection.Open();
            da.Fill(dt);
            sqlconnection.Close();
            foreach (DataRow dr in dt.Rows)
            {
                productList.Add(
                    new Product
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        Price = Convert.ToInt32(dr["Price"])
                    }
                );

            }
            return productList;
        }

        public Product GetProductById(int id)
        {
            connection();
            List<Product> productList = new List<Product>();
            string query = "SELECT * FROM Products where Id=" + id;
            SqlCommand command = new SqlCommand(query, sqlconnection)
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlconnection.Open();
            dataAdapter.Fill(dataTable);
            sqlconnection.Close();
            foreach (DataRow dr in dataTable.Rows)
            {
                productList.Add(
                    new Product
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        Price = Convert.ToInt32(dr["Price"])
                    }
                );

            }
            return productList[0];
        }
    }
}

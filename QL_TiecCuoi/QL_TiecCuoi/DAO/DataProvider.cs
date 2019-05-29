using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_TiecCuoi.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }

            set
            {
                instance = value;
            }
        }
        public DataProvider() { }
		//Replace DESKTOP-QA8LE5A by your SQL Database
        private string connectionSTR = "Data Source=DESKTOP-QA8LE5A;Initial Catalog=QuanLyTiecCuoi;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            Console.WriteLine("Query: "+query);
            DataTable data = new DataTable();
            try
            {
              
                using (SqlConnection connection = new SqlConnection(connectionSTR)) // ket noi layer xuong server
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);//cau truy van thuc thi
                    SqlDataAdapter adapter = new SqlDataAdapter(command);//trung gian lay du lieu
                    adapter.Fill(data);
                    connection.Close();

                }
                return data;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error query :" + e);
               
            }

            return data;

        }

        // them
            public int ExecuteWrite(string query)
            {
            query = query + "; SELECT SCOPE_IDENTITY() as id";
            Console.WriteLine("Query Insert: " + query);
            int insertID = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR)) // ket noi layer xuong server
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);//cau truy van thuc thi

                    insertID = Convert.ToInt32(command.ExecuteScalar());
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                    Console.WriteLine("Insert id: " + insertID);
                  
                }
                return insertID;


            }
            catch (SqlException e)
            {
                Console.WriteLine("Error query insert :" + e);

            }
            return insertID;

        }
        // xoa
        public bool ExecuteDelete(string query)
        {

            
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // ket noi layer xuong server
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//cau truy van thuc thi
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                //command.ExecuteReader();

                connection.Close();
            }
            return true;
        }
        // sua 
        public bool ExecuteUpdate(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // ket noi layer xuong server
            {
                connection.Open();
                Console.WriteLine("Query Update: " + query);
                SqlCommand command = new SqlCommand(query, connection);//cau truy van thuc thi
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet set = new DataSet();
                
              
                command.ExecuteNonQuery();
                //command.ExecuteReader();
                Console.Write("test");

                connection.Close();
            }
            return true;
        }
        // tim kiem
        public DataTable ExecuteSearch(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // ket noi layer xuong server
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//cau truy van thuc thi
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.CommandType = CommandType.StoredProcedure;
                adapter.Fill(data);
                connection.Close();

            }
            return data;
        }
        // Thong tin tiec
       
                
          
           
           
       

    }
}



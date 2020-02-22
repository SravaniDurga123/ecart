using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ADOassignment
{
    class Program
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A63MUHA\SQLEXPRESS;
                        Initial Catalog = practicedb1; User ID = sa; Password=pass@word1");
        SqlCommand cmd = null;
        public void Add(int id, string name, int price, int stock)
        {
            try
            {
                cmd = new SqlCommand("insert into Product values(@id,@name,@price,@stock)",con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message + " " + se.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }

        public void Get(int id)
        {
            cmd = new SqlCommand("select * from Product where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Console.WriteLine("id:{0} name:{1} price:{2} stock:{3}", dr["id"], dr["name"], dr["price"], dr["stock"]);
            }
            else
            {
                Console.WriteLine("invalid id");
            }
        }

        public void getAll()
        {
            cmd = new SqlCommand("select * from Product", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                Console.WriteLine("id:{0} name:{1} price:{2} stock:{3}", dr["id"], dr["name"], dr["price"], dr["stock"]);

            }
            else
            {
                Console.WriteLine("no rows");
            }
        }

        public void delete(int id)
        {
            cmd = new SqlCommand("delete from  Product where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public void update(int id,int price,int stock)
        {
            cmd = new SqlCommand("update Product set price=@price,stock=@stock where id=@id", con);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("menu");
            Console.WriteLine("1.insert");
            Console.WriteLine("2.getId");
            Console.WriteLine("3.Getall");
            Console.WriteLine("4.delete");
            Console.WriteLine("5.update");
            Console.WriteLine("choose");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("enter details");
                int id = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                int price = int.Parse(Console.ReadLine());
                int stock = int.Parse(Console.ReadLine());
                p.Add(id, name, price, stock);
            }
            if (n == 2)
            {
                Console.WriteLine("enter id");
                int id = int.Parse(Console.ReadLine());
                p.Get(id);
            }
            if (n == 3)
            {
                p.getAll();
            }
            if (n == 4)
            {
                Console.WriteLine("enter id to delete");
                int id = int.Parse(Console.ReadLine());
                p.delete(id);
            }
            if (n == 5)
            {
                Console.WriteLine("enter id to update");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter price to update");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("enter stock to update");
                int stock = int.Parse(Console.ReadLine());
                p.update(id, price, stock);
            }
            Console.ReadKey();
        }
    }
}

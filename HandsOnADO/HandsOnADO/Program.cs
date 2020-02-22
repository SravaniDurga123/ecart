using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HandsOnADO
{
    class Program
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-A63MUHA\SQLEXPRESS; 
                         Initial Catalog = practicedb1; User ID = sa; Password=pass@word1");
        SqlCommand cmd = null;
        public void add()
        {
            try
            {
                cmd = new SqlCommand("Insert into project values(@project_no,@project_name,@budget)",con);
                cmd.Parameters.AddWithValue("@project_no", "p4");
                cmd.Parameters.AddWithValue("@project_name", "jhdaj");
                cmd.Parameters.AddWithValue("@budget", 23);
                con.Open(); //open connection
                cmd.ExecuteNonQuery();//executr query
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message+"  ");
            }
            finally
            {
                con.Close();//close connection
            }
        }
        public void GetProjectById(string project_no)
        { try
            {
                cmd = new SqlCommand("select * from project where project_no=@project_no", con);
                cmd.Parameters.AddWithValue("@project_no", project_no);
                con.Open();
               SqlDataReader dr= cmd.ExecuteReader();
                if(dr.HasRows)//check rows existence
                {
                    //read records in datareader
                    dr.Read();//read only one record
                    Console.WriteLine("id:{0} name:{1} budget{2}", dr["project_no"], dr["project_name"], dr["budget"]);
                }
                else
                {
                    Console.WriteLine("invalid project id");
                }
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void GetAllProjects()
        {
            cmd = new SqlCommand("select * from project", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("id:{0} name:{1} budget:{2}", dr["project_no"], dr["project_name"], dr["budget"]);
                }
            }
            else
            {
                Console.WriteLine("table empty");
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            // obj.add();
            //obj.GetProjectById("p2");
            obj.GetAllProjects();
            Console.ReadKey();
        }
    }
}

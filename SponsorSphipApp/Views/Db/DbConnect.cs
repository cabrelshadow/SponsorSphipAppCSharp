using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SponsorSphipApp.View.Db
{
    public class DbConnect
    {
        String ConnectionString = "Data Source =DESKTOP-2GPND6O\\SQLEXPRESS;Initial Catalog=SponsorsphipApp;Integrated Security=True";
        
        SqlConnection con = null;
        public DbConnect()
        {
          con = new SqlConnection(ConnectionString);
        }
        public  void Execute( String Query)
    {
           
           
            try
            {
         
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
               

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
            finally
            {
                con.Close();
            }


    }
        public  SqlDataReader Select(string Query)
        {
         
           
            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
               return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
            return null;
        }
    }
}

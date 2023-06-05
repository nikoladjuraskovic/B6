using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Data;

namespace B6UspehUcenika
{
    public partial class grafika : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q7KL7JB;Initial Catalog=b6;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string upit = "SELECT Razred,ProsOcena FROM Uspeh";
                Series series = Chart1.Series["Series1"];
                cmd = new SqlCommand(upit, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    series.Points.AddXY(dr["Razred"].ToString(), dr["ProsOcena"].ToString());
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
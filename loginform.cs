using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace STUDENT_MANAGEMENT_SYSTEM
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void btnlogin2_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Dotnetprojects\\STUDENT MANAGEMENT SYSTEM\\logindata.mdf\";Integrated Security=True";
            string query = "INSERT INTO [user](USERNAME,PASSWORD) VALUES (@USERNAME,@PASSWORD)";

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@USERNAME", usertxt.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", passtext.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Login Successfully");
        }
    }
}

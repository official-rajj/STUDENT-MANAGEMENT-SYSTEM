using System.Data.SqlClient;

namespace STUDENT_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Dotnetprojects\\STUDENT MANAGEMENT SYSTEM\\Database1.mdf\";Integrated Security=True";
            string query = "INSERT INTO Student(NAME,BRANCH,SEMESTER) VALUES (@NAME,@BRANCH,@SEMESTER)";


            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@NAME", txtname.Text);
            cmd.Parameters.AddWithValue("@BRANCH", txtbranch.Text);
            cmd.Parameters.AddWithValue("@SEMESTER", txtsemester.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registration Successfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            loginform f2 = new loginform();
            f2.Show();
        }
    }
}

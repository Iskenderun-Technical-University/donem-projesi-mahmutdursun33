using System.Data.SqlClient;


namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-TNITFUT;Initial Catalog=kürüphane;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into uusertab values (@Id,@Name,@Age)", cnn);
            

            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", double.Parse(textBox3.Text));
            MessageBox.Show("Connection Open  !");
            cnn.Close();

        }
    }
}


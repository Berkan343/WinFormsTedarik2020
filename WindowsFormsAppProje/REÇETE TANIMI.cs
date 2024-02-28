using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsAppProje
{
    public partial class REÇETE_TANIMI : Form
    {
        public REÇETE_TANIMI()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = UretımDB; Integrated Security = True");


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("INSERT INTO recetetanımı(rctanaurunkod,rctacıklama,rctmiktar,rctsatırsayısı)VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(("Select * from recetetanımı"), baglan );
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("Update recetetanımı set rctanaurunkod=('" + textBox1.Text + "'),rctacıklama=('" + textBox2.Text + "'),rctmiktar=('" + textBox3.Text + "'),rctsatırsayısı=('" + textBox4.Text + "')WHERE rctid='" + textBox5.Text + "'", baglan);
           
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter(("Select * from recetetanımı"), baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter(("Select * from recetetanımı"), baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("DELETE FROM recetetanımı WHERE rctanaurunkod = ('" + textBox1.Text + "')", baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter(("Select * from recetetanımı"), baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
    }
}

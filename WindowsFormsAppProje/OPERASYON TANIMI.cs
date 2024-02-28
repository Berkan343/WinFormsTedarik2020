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
    public partial class OPERASYON_TANIMI : Form
    {
        public OPERASYON_TANIMI()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = UretımDB; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("INSERT INTO operasyon(opkod,optoplamsure,opişlemsure,opbeklemesure,optasımasure,opacıklama)VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(("Select * from operasyon"), baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("DELETE FROM operasyon WHERE opkod = ('" + textBox1.Text + "')", baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter(("Select * from operasyon"), baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter(("Select * from operasyon"), baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("Update operasyon set opkod=('" + textBox1.Text + "'),optoplamsure=('" + textBox2.Text + "'),opişlemsure=('" + textBox3.Text + "'),opbeklemesure=('" + textBox4.Text + "'),optasımasure=('" + textBox5.Text + "'),opacıklama=('" + textBox6.Text + "')WHERE rctid='" + textBox5.Text + "'", baglan);

            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter(("Select * from operasyon"), baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
    }
}

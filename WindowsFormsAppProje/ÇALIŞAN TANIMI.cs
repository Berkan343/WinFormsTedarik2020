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
    public partial class ÇALIŞAN_TANIMI : Form
    {
        public ÇALIŞAN_TANIMI()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = UretımDB; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("INSERT INTO calısantanımı(clstc,clsadsoyad,clsgorev,clsbirimsaatmalyet,clsaylıkmaliyet)VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(("Select * from calısantanımı"), baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter(("Select * from calısantanımı"), baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("DELETE FROM calısantanımı WHERE clstc = ('" + textBox1.Text + "')", baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter(("Select * from calısantanımı"), baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            komut = new SqlCommand("Update calısantanımı set clstc=('" + textBox1.Text + "'),clsadsoyad=('" + textBox2.Text + "'),clsgorev=('" + textBox3.Text + "'),clsbirimsaatmalyet=('" + textBox4.Text + "'),clsaylıkmaliyet=('" + textBox5.Text + "')WHERE rctid='" + textBox5.Text + "'", baglan);

            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter(("Select * from calısantanımı"), baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ANA_FORM aform = new ANA_FORM();
        SqlConnection baglan = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = UretımDB; Integrated Security = True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "berkansukut" && textBox2.Text == "123")
            {
                aform.Show();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre hatalıdır!");
            }
        }
    }
}

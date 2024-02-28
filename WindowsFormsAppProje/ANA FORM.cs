using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppProje
{
    public partial class ANA_FORM : Form
    {
        public ANA_FORM()
        {
            InitializeComponent();
        }
        ÇALIŞAN_TANIMI cform = new ÇALIŞAN_TANIMI();
        private void button1_Click(object sender, EventArgs e)
        {
            cform.Show();
        }
        REÇETE_TANIMI rform = new REÇETE_TANIMI();
        private void button2_Click(object sender, EventArgs e)
        {
            rform.Show();
        }
        İŞ_İSTASYONU_TANIMI iform = new İŞ_İSTASYONU_TANIMI();
        private void button3_Click(object sender, EventArgs e)
        {
            iform.Show();
        }
        OPERASYON_TANIMI oform = new OPERASYON_TANIMI();
        private void button4_Click(object sender, EventArgs e)
        {
            oform.Show();
        }
    }
}

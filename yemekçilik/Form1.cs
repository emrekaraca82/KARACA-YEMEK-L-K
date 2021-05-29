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

namespace yemekçilik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DAMLA\\SQLEXPRESS;Initial Catalog=yemekcilik;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yemekcilikDataSet5.genelmasa' table. You can move, or remove it, as needed.
            this.genelmasaTableAdapter1.Fill(this.yemekcilikDataSet5.genelmasa);
            // TODO: This line of code loads data into the 'yemekcilikDataSet4.genelmasa' table. You can move, or remove it, as needed.
            this.genelmasaTableAdapter.Fill(this.yemekcilikDataSet4.genelmasa);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            formmasa1 frm1 = new formmasa1();
            frm1.Show();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Formmasa2 frm2 = new Formmasa2();
            frm2.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Formmasa3 frm3 = new Formmasa3();
            frm3.Show();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Formmasa4 frm4 = new Formmasa4();
            frm4.Show();

        }
       
       
    }
}

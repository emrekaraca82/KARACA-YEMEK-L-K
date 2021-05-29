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
    public partial class Formmasa2 : Form
    {
        public Formmasa2()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DAMLA\\SQLEXPRESS;Initial Catalog=yemekcilik;Integrated Security=True");
        private void verilerigöster(string veriler)
        {

            SqlDataAdapter da = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }
        private void btnal2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle=new SqlCommand("insert into dbo.masa2(Anayemek,Corbalar,İcecekler,Tatlılar) values('" +cmbana2.Text+ "','" +cmbcorba2.Text + "','"+cmbicecek2.Text+"','"+cmbtatlı2.Text+"')",baglantı);
            ekle.ExecuteNonQuery();
            verilerigöster("Select*from masa2");
            baglantı.Close();
        }

        private void Formmasa2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yemekcilikDataSet1.masa2' table. You can move, or remove it, as needed.
            this.masa2TableAdapter.Fill(this.yemekcilikDataSet1.masa2);

        }

        private void btnsil2_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand sil = new SqlCommand("delete dbo.masa2 where masa2id='" + txtmasa2.Text + "'", baglantı);
            sil.ExecuteNonQuery();
            verilerigöster("Select*from masa2");
            baglantı.Close();
        }

        private void Btngün2_Click(object sender, EventArgs e)
        {
              baglantı.Open();
            SqlCommand guncelle = new SqlCommand("update dbo.masa2 set Anayemek='" +cmbana2.Text + "',Corbalar='" +cmbcorba2.Text + "',İcecekler='"+cmbicecek2.Text+ "',Tatlılar='" +cmbtatlı2.Text + "' where masa2id='" + txtmasa2.Text + "'", baglantı);
            guncelle.ExecuteNonQuery();
            verilerigöster("Select*from masa2");
            baglantı.Close();
        }

        private void btncık2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

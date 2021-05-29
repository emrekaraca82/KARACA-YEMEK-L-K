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
    public partial class Formmasa4 : Form
    {
        public Formmasa4()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DAMLA\\SQLEXPRESS;Initial Catalog=yemekcilik;Integrated Security=True");
        private void verilerigöster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];

        }
        private void btncık4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnal4_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into dbo.masa4(Anayemek,Corba,İcecekler,Tatlılar) values('" + cmbana4.Text + "','" + cmbcorba4.Text + "','" + cmbicecek4.Text + "','" + cmbtatlı4.Text + "')", baglantı);
            ekle.ExecuteNonQuery();
            verilerigöster("Select*from masa4");
            baglantı.Close();
        }

        private void btnsil4_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand sil = new SqlCommand("delete dbo.masa4 where masa1id='" + txtmasa4.Text + "'", baglantı);
            sil.ExecuteNonQuery();
            verilerigöster("Select*from masa4");
            baglantı.Close();
        }

        private void Btngün4_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand guncelle = new SqlCommand("update dbo.masa1 set Anayemek='" + cmbana4.Text + "',Corba='" + cmbcorba4.Text + "',İcecekler='" + cmbicecek4.Text + "',Tatlılar='" + cmbtatlı4.Text + "' where masa1id='" + txtmasa4.Text + "'", baglantı);
            guncelle.ExecuteNonQuery();
            verilerigöster("Select*from masa4");
            baglantı.Close();
        }

        private void Formmasa4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yemekcilikDataSet3.masa4' table. You can move, or remove it, as needed.
            
            this.masa4TableAdapter.Fill(this.yemekcilikDataSet3.masa4);

        }
    }
}

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
    public partial class Formmasa3 : Form
    {
        public Formmasa3()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DAMLA\\SQLEXPRESS;Initial Catalog=yemekcilik;Integrated Security=True");

        private void Formmasa3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yemekcilikDataSet2.masa3' table. You can move, or remove it, as needed.
            this.masa3TableAdapter.Fill(this.yemekcilikDataSet2.masa3);

        }
        private void verilerigöster(string veriler)
        {

            SqlDataAdapter da = new SqlDataAdapter(veriler, baglantı);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];

        }

        private void btnal3_Click(object sender, EventArgs e)
        {

            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into dbo.masa3(Anayemek,Corba,İcecekler,Tatlılar) values('" + cmbana3.Text + "','" + cmbcorba3.Text + "','" + cmbicecek3.Text + "','" + cmbtatlı3.Text + "')", baglantı);
            ekle.ExecuteNonQuery();
            verilerigöster("Select*from masa3");
            baglantı.Close();


        }

        private void btnsil3_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand sil = new SqlCommand("delete dbo.masa3 where masa3id='" + txtmasa3.Text + "'", baglantı);
            sil.ExecuteNonQuery();
            verilerigöster("Select*from masa3");
            baglantı.Close();
        }

        private void Btngün3_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand guncelle = new SqlCommand("update dbo.masa3 set Anayemek='" + cmbana3.Text + "',Corba='" + cmbcorba3.Text + "',İcecekler='" + cmbicecek3.Text + "',Tatlılar='" + cmbtatlı3.Text + "' where masa3id='" + txtmasa3.Text + "'", baglantı);
            guncelle.ExecuteNonQuery();
            verilerigöster("Select*from masa3");
            baglantı.Close();
        }

        private void btncık3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

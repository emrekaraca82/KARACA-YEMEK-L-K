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
    public partial class formmasa1 : Form
    {
        public formmasa1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı=new SqlConnection("Data Source=DAMLA\\SQLEXPRESS;Initial Catalog=yemekcilik;Integrated Security=True");

        private void formmasa1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yemekcilikDataSet.masa1' table. You can move, or remove it, as needed.
            this.masa1TableAdapter.Fill(this.yemekcilikDataSet.masa1);

        }
        private void verilerigöster(string veriler){

        SqlDataAdapter da=new SqlDataAdapter(veriler,baglantı);
        DataSet ds=new DataSet();
        da.Fill(ds);
        dataGridView1.DataSource=ds.Tables[0];

    }
        private void btnal1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle=new SqlCommand("insert into dbo.masa1(Anayemek,Corbalar,İcecekler,Tatlılar) values('" +cmbana1.Text+ "','" +cmbcorba1.Text + "','"+cmbicecek1.Text+"','"+cmbtatlı1.Text+"')",baglantı);
            ekle.ExecuteNonQuery();
            verilerigöster("Select*from masa1");
            baglantı.Close();
            
        }

        private void btnsil1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand sil = new SqlCommand("delete dbo.masa1 where masa1id='" + txtmasa1.Text + "'", baglantı);
            sil.ExecuteNonQuery();
            verilerigöster("Select*from masa1");
            baglantı.Close();

        }

        private void Btngün1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand guncelle = new SqlCommand("update dbo.masa1 set Anayemek='" +cmbana1.Text + "',Corbalar='" +cmbcorba1.Text + "',İcecekler='"+cmbicecek1.Text+ "',Tatlılar='" +cmbtatlı1.Text + "' where masa1id='" + txtmasa1.Text + "'", baglantı);
            guncelle.ExecuteNonQuery();
            verilerigöster("Select*from masa1");
            baglantı.Close();
        
        }


        private void btncık1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

        }
    }
}

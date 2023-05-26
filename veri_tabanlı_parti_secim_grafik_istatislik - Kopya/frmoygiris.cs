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
using System.Data.SqlTypes;

namespace veri_tabanlı_parti_secim_grafik_istatislik
{
    public partial class VTGS : Form
    {
        public VTGS()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-9OPFR8A; Initial Catalog = DBSECIMPRIJE; Integrated Security = True");

        private void SSSSS_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI)values (@P1, @P2, @P3, @P4, @P5, @P6)", baglanti);
                komut.Parameters.AddWithValue("@P1", TXTAD.Text);
                komut.Parameters.AddWithValue("@P2", TXTA.Text);
                komut.Parameters.AddWithValue("@P3", TXTA.Text);
                komut.Parameters.AddWithValue("@P4", TXTA.Text);
                komut.Parameters.AddWithValue("@P5", TXTA.Text);
                komut.Parameters.AddWithValue("@P6", TXTA.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("oy girişi gerçekleşti");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void BTNGRAFİKLER_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
            this.Hide();
        }

        private void BTNÇIKIŞYAP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

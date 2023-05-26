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
namespace veri_tabanlı_parti_secim_grafik_istatislik
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-9OPFR8A; Initial Catalog = DBSECIMPRIJE; Integrated Security = True");


        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBSECIMPRIJEDataSet.TBLILCE' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLILCETableAdapter.Fill(this.dBSECIMPRIJEDataSet.TBLILCE);
            //ilçe adlarini commboboxa çekme 
            baglanti.Open();

            SqlCommand kommut = new SqlCommand("select ILCEAD from TBLILCE", baglanti);
            SqlDataReader dr = kommut.ExecuteReader();
             while (DesignMode==dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            baglanti.Close();

            //grafige toplam sonucları getırme 
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select SUM(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI)FROM TBLILCE", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);


            }
            baglanti.Close();







                }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select*From TBLILCE where ILCEAD=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            chart1.Series["Partiler"].Points.Clear();
            while (dr.Read())

            { 
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());


                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr[2]);

                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr[3]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr[4]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr[5]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr[6]);


                lbla.Text = dr[2].ToString();
                lblb.Text = dr[3].ToString();
                lblc.Text = dr[4].ToString();
                lbld.Text = dr[5].ToString();
                lble.Text = dr[6].ToString();



            }

            baglanti.Close();

        }

        private void FrmGrafikler_FormClosed(object sender, FormClosedEventArgs e)
        {
            VTGS form = new VTGS();
            form.Show();
        }
    }
}

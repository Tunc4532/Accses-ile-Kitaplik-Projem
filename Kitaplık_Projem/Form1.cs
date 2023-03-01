using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kitaplık_Projem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\90536\\OneDrive\\Masaüstü\\Kitaplık1.mdb");
        void listele()
        {
            DataTable dt =  new DataTable();
            OleDbDataAdapter dr = new OleDbDataAdapter("Select * from kitaplik",baglanti);
            dr.Fill(dt);    
            dataGridView1.DataSource= dt;

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }
        string durum = "";
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand gorev = new OleDbCommand("insert into kitaplik (kitapad,yazar,tür,sayfa,durum) values (@e1,@e2,@e3,@e4,@e5)", baglanti);
            gorev.Parameters.AddWithValue("@e1", txtad.Text);
            gorev.Parameters.AddWithValue("@e2",txtyazar.Text);
            gorev.Parameters.AddWithValue("@e3",cmbtur.Text);
            gorev.Parameters.AddWithValue("@e4", txtsayfa.Text);
            gorev.Parameters.AddWithValue("@e1", durum);
            gorev.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kayıt İşlemi Yapıldı", "Bilgi", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
        }

        private void rchkullanılmıs_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void rchsıfır_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;

            txtıd.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            txtyazar.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            cmbtur.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            txtsayfa.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[seçilen].Cells[5].Value.ToString() == "True") 
            {
                rchkullanılmıs.Checked= true;
            }
            else
            {
                rchsıfır.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand gorev = new OleDbCommand("Delete from kitaplik where kitapıd=@e1",baglanti);
            gorev.Parameters.AddWithValue("@e1", txtıd.Text);
            gorev.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silme İşlemi Başarılı","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("update kitaplik set kitapad=@s1,yazar=@s2,tür=@s3,sayfa=@s4,durum=@s5 where kitapıd=@s6", baglanti);
            komut2.Parameters.AddWithValue("@s1", txtad.Text);
            komut2.Parameters.AddWithValue("@s2", txtyazar.Text);
            komut2.Parameters.AddWithValue("@s3", cmbtur.Text);
            komut2.Parameters.AddWithValue("@s4", txtsayfa.Text);
            if (rchkullanılmıs.Checked == true) 
            {
                komut2.Parameters.AddWithValue("@e1", durum);
            }
            if (rchsıfır.Checked == true)   
            {
                komut2.Parameters.AddWithValue("@e1", durum);
            }
            komut2.Parameters.AddWithValue("@s6",txtıd.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            OleDbCommand koomut = new OleDbCommand("Select * From kitaplik where kitapad=@e1",baglanti);
            koomut.Parameters.AddWithValue("@e1",txtkitapara.Text);
            DataTable dre = new DataTable();
            OleDbDataAdapter das = new OleDbDataAdapter(koomut);
            das.Fill(dre);
            dataGridView1.DataSource= dre;
            baglanti.Close();
        }
    }
}

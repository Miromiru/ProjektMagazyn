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
using System.IO;

namespace ProjektMagazyn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grbxReceive.Visible = false;
            grbxSend.Visible = false;
            grbxOrder.Visible = false;
            grbxDelete.Visible = false;
            StorageCapacity();
            if (storageVolume > 1000) { btReceive.Enabled = false; } else {btReceive.Enabled = true;}
        }

        private void btReceive_Click(object sender, EventArgs e)
        {
            grbxReceive.Visible = true;
            grbxSend.Visible = false;
            grbxOrder.Visible = false;
            grbxDelete.Visible = false;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            grbxReceive.Visible = false;
            grbxSend.Visible = true;
            grbxOrder.Visible = false;
            grbxDelete.Visible = false;
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            grbxReceive.Visible = false;
            grbxSend.Visible = false;
            grbxOrder.Visible = true;
            grbxDelete.Visible = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            grbxReceive.Visible = false;
            grbxSend.Visible = false;
            grbxOrder.Visible = false;
            grbxDelete.Visible = true;
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            czytaj();
            StorageCapacity();
            if (storageVolume > 1000) { btReceive.Enabled = false; } else { btReceive.Enabled = true; }
        }



        private void czytaj()
        {
            var select = "SELECT * FROM paczka ORDER BY czasZamowienia DESC, czasOdebrania DESC, czasWyslania DESC";
            var c = new SqlConnection(@"Data Source=LAPTOP-HK5PHBI7;Initial Catalog=MagazynDB;Integrated Security=True;");
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btAddOrder_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HK5PHBI7;Initial Catalog=MagazynDB;Integrated Security=True;");
            SqlCommand cmd;

            int IReceivePackSize = Int32.Parse(txbOrderPackSize.Text);

            con.Open();
            cmd = new SqlCommand("insert into paczka (nrPaczki, nazwaPaczki, wielkoscPaczki, skad, stan, czasZamowienia) values ('" + this.txbOrderPackID.Text + "','" + this.txbOrderPackName.Text + "'," + IReceivePackSize + ",'" + this.txbOrderPackFrom.Text + "','Zamówiona' , '" + this.dtpOrderPack.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btAddSend_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HK5PHBI7;Initial Catalog=MagazynDB;Integrated Security=True;");
            SqlCommand cmd;

            con.Open();
            cmd = new SqlCommand("UPDATE paczka SET stan = 'Wysłana', czasWyslania = '"+ this.dtpSendPack.Text +"', dokad = '"+this.txbSendPackDestination.Text +"' WHERE nrPaczki = '"+ this.txbSendPackID.Text +"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btAddReceive_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HK5PHBI7;Initial Catalog=MagazynDB;Integrated Security=True;");
            SqlCommand cmd;

            con.Open();
            cmd = new SqlCommand("UPDATE paczka SET stan = 'Odebrana', czasOdebrania = '" + this.dtpReceivePack.Text + "' WHERE nrPaczki = '" + this.txbReceivePackID.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btRemovePack_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HK5PHBI7;Initial Catalog=MagazynDB;Integrated Security=True;");
            SqlCommand cmd;

            con.Open();
            cmd = new SqlCommand("DELETE FROM paczka WHERE nrPaczki ='"+ this.txbDeletePackID.Text +"';", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void txbOrderPackID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txbReceivePackID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txbSendPackID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txbDeletePackID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        public int storageVolume { get; set; }
        protected void StorageCapacity()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HK5PHBI7;Initial Catalog=MagazynDB;Integrated Security=True;");
            string sql = "Select sum(wielkoscPaczki) From paczka where stan='Odebrana'";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            try
            {
                if (rd.HasRows)
                {
                    rd.Read();
                    var storageSize = rd.GetInt32(0);
                    lbStorageCapacity.Text = storageSize.ToString() + "/1000 m³";
                    storageVolume = storageSize;
                    
                }
            }
            catch { lbStorageCapacity.Text = "00/1000 m³"; }

            con.Close();
        }
    }
}

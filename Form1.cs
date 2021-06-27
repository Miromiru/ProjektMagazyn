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
        /// <summary>
        /// Aplikacja Magazyn, główne menu
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            grbxReceive.Visible = false;
            grbxSend.Visible = false;
            grbxOrder.Visible = false;
            grbxDelete.Visible = false;
            StorageCapacity();
            StorageVolumeCheck();
        }


        /// <summary>
        /// Odpowiada za pokazanie menu służącego do odebrania paczki
        /// </summary>
        private void btReceive_Click(object sender, EventArgs e)
        {
            grbxReceive.Visible = true;
            grbxSend.Visible = false;
            grbxOrder.Visible = false;
            grbxDelete.Visible = false;
        }


        /// <summary>
        /// Odpowiada za pokazanie menu służącego do wysłania paczki
        /// </summary>
        private void btSend_Click(object sender, EventArgs e)
        {
            grbxReceive.Visible = false;
            grbxSend.Visible = true;
            grbxOrder.Visible = false;
            grbxDelete.Visible = false;
        }

        /// <summary>
        /// Odpowiada za pokazanie menu służącego do składania zamówień na paczkę
        /// </summary>
        private void btOrder_Click(object sender, EventArgs e)
        {
            grbxReceive.Visible = false;
            grbxSend.Visible = false;
            grbxOrder.Visible = true;
            grbxDelete.Visible = false;
        }

        /// <summary>
        /// Odpowiada za pokazanie menu służącego do usunięcia paczki
        /// </summary>
        private void btDelete_Click(object sender, EventArgs e)
        {
            grbxReceive.Visible = false;
            grbxSend.Visible = false;
            grbxOrder.Visible = false;
            grbxDelete.Visible = true;
        }

        /// <summary>
        /// Funkcja odpowiadająca za wywołanie okienka z rekordami z bazy danych
        /// </summary>

        private void btShow_Click(object sender, EventArgs e)
        {
            ReadDB();
            StorageCapacity();
            StorageVolumeCheck();
        }


        ///
        /// Umożliwia na połączenie się z bazą danych, odczytanie rekordów a następnie wyświetlenie ich
        ///  <param name=select> Zawarte w niej jest polecenie sql</param>
        ///  <param name=c> Zawarte jest w niej ścieżka do bazy danych</param>
        ///  <param name=dataAdapter> jest zmienną połączoną z polecenia sql i ścieżką do bazy</param>
        private void ReadDB()
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
        ///
        /// Funkcja odpowiadająca za złożenie zamówienia na paczkę, dane zczytuje bezpośrednio z textboxów
        /// <param name=cmd> Zawarta jest w niej instrukcja do wykoniana w bazie danych</param>
        /// 
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
        ///
        /// Funkcja odpowiadająca za wysłanie paczki, dane zczytuje bezpośrednio z textboxów
        /// <param name=cmd> Zawarta jest w niej instrukcja do wykoniana w bazie danych</param>
        /// 
        private void btAddSend_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HK5PHBI7;Initial Catalog=MagazynDB;Integrated Security=True;");
            SqlCommand cmd;

            con.Open();
            cmd = new SqlCommand("UPDATE paczka SET stan = 'Wysłana', czasWyslania = '" + this.dtpSendPack.Text + "', dokad = '" + this.txbSendPackDestination.Text + "' WHERE nrPaczki = '" + this.txbSendPackID.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        ///
        /// Funkcja odpowiadająca za odebranie paczki, dane zczytuje bezpośrednio z textboxów
        /// <param name=cmd> Zawarta jest w niej instrukcja do wykoniana w bazie danych</param>
        ///
        private void btAddReceive_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HK5PHBI7;Initial Catalog=MagazynDB;Integrated Security=True;");
            SqlCommand cmd;

            con.Open();
            cmd = new SqlCommand("UPDATE paczka SET stan = 'Odebrana', czasOdebrania = '" + this.dtpReceivePack.Text + "' WHERE nrPaczki = '" + this.txbReceivePackID.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        ///
        /// Funkcja odpowiadająca za usunięcie paczki, dane zczytuje bezpośrednio z textboxów
        /// <param name=cmd> Zawarta jest w niej instrukcja do wykoniana w bazie danych</param>
        ///
        private void btRemovePack_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HK5PHBI7;Initial Catalog=MagazynDB;Integrated Security=True;");
            SqlCommand cmd;

            con.Open();
            cmd = new SqlCommand("DELETE FROM paczka WHERE nrPaczki ='" + this.txbDeletePackID.Text + "';", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        ///
        /// Funkcja odpowiadająca za wymuszenie używania cyfr przy wpisywaniu numeru paczki 
        /// 
        private void txbOrderPackID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        ///
        /// Funkcja odpowiadająca za wymuszenie używania cyfr przy wpisywaniu numeru paczki
        ///
        private void txbReceivePackID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        ///
        /// Funkcja odpowiadająca za wymuszenie używania cyfr przy wpisywaniu numeru paczki
        ///
        private void txbSendPackID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        ///
        /// Funkcja odpowiadająca za wymuszenie używania cyfr przy wpisywaniu numeru paczki
        /// 
        private void txbDeletePackID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Zmienna odpowiadająca za zapisanie ilości zajętego miejsca w magazynie
        /// </summary>
        public int storageVolume { get; set; }

        ///
        /// Sprawdza i wypisuje aktualną pojemność magazynu
        /// <param name=con> Zawiera ścieżkę do bazy dancyh</param>
        /// <param name=sql> Zawarta jest w niej instrukcja do wykoniana w bazie danych</param>
        /// <param name=cmd> Łączy zawartość sql i con</param>
        /// 
        protected void StorageCapacity()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HK5PHBI7;Initial Catalog=MagazynDB;Integrated Security=True;");
            string sql = "Select sum(wielkoscPaczki) From paczka where stan='Odebrana'";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            ///
            /// <param name=storageSize> Zczytuje wartość zwróconą przez bazę danych a następnie zamienia na inta po czym zapisywana jest lbStorageCapacity</param>
            ///
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
        ///
        /// Instrukcja warunkowa sprawdzająca czy pojemność magazynu jest przekroczona, jeśli tak to blokuje możliwość odbierania paczek
        ///
        private void StorageVolumeCheck()
        {     
            if (storageVolume > 1000) { btReceive.Enabled = false; } else {btReceive.Enabled = true; } 
        }

    }
}

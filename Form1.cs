using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp_EF_iliskiliTablolar
{
    public partial class Form1 : Form
    {
        Veritabani vt = new Veritabani();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            vt.Ogrenciler.Load();
            vt.Siniflar.Load();

            //Combobox'ý dolduruyorum            
            comboBox_SnfSec.DataSource = vt.Siniflar.Local.ToBindingList();
            comboBox_SnfSec.DisplayMember = "SinifAd";
            //Ayarlardaki 
            comboBox_Ayar_Snf.DataSource = vt.Siniflar.Local.ToBindingList();
            comboBox_Ayar_Snf.DisplayMember = "SinifAd";

            //datagridi dolduruyorum
            dataGridView_OgrListe.DataSource = vt.Ogrenciler.Local.ToBindingList();
            dataGridView_OgrListe.Columns[0].Visible = false;
            dataGridView_OgrListe.Columns[4].Visible = false;

            //özel combobox sutunu oluþturuyorum
            DataGridViewComboBoxColumn _ozelColumnCombobox = new DataGridViewComboBoxColumn();

            foreach (var item in vt.Siniflar.Local)
            {
                _ozelColumnCombobox.Items.Add(item);
            }
            _ozelColumnCombobox.DataPropertyName = "Sinif";
            _ozelColumnCombobox.DisplayMember = "SinifAd";
            _ozelColumnCombobox.ValueMember = "Kendisi";

            dataGridView_OgrListe.Columns.Add(_ozelColumnCombobox);

          






        }






        private void dataGridView_OgrListe_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            vt.SaveChanges();
        }




        
        
        private void button_Ogr_Kaydet_Click(object sender, EventArgs e)
        {
           

        }

        private void dataGridView_OgrListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void comboBox_SnfSec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage_OgrListe_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }




}


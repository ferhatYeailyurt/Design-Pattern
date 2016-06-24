using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace odevDeneme
{
    public partial class sporcuPenWindow : Form
    {
      

        ComponentConfiguration xcon = ComponentConfiguration.ComponentConXml();
        
        public int urunid;
        string diger, ligi, ad, soyad;  
        sporcuController spControll;
        sporcuModell spModell;
        silmelgsporcu silmeLog = silmelgsporcu.silmeSporcu();
        kaydetmelgSporcu spLog = kaydetmelgSporcu.kaydetLoggerSporcu();
        sporcuGuncelleLogger spGuncelLog = sporcuGuncelleLogger.guncelleLogger();

        public sporcuPenWindow()
        {
            spControll = new sporcuController();
            spModell = new sporcuModell();
            InitializeComponent();
        }

        private void alanlariTemizle()
        {
            txtsporcuAdi.Clear();
            txtsporcuSoyAdi.Clear();
            txtdigersporcu.Clear();
            sporcuLigiCombo.Text = "";

        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            getValueDb();
            spControll.kaydet(spModell);
            gosterDataGridView();
            spLog.LogSporcuKaydet("Sporcu Kayıt Yapıldı", spModell.SporcuAdi.ToString(), spModell.SporcuSoyadi.ToString(), spModell.SporcuDiger.ToString(), spModell.SporcuLigi.ToString());
            alanlariTemizle();
        }

        private void getValueDb()
        {
            spModell.SporcuAdi = txtsporcuAdi.Text;
            spModell.SporcuSoyadi = txtsporcuSoyAdi.Text;
            spModell.SporcuDiger = txtdigersporcu.Text;
            spModell.SporcuLigi = sporcuLigiCombo.Text;//daydin
            spControll.setModel(spModell);
        }

        private void gosterDataGridView()
        {
            sporcuDataClassesDataContext datacon = new sporcuDataClassesDataContext();
            dgListele.DataSource = datacon.sporcuPenceresiDbs;
            

        }
           

        private void button2_Click(object sender, EventArgs e)
        {
           gosterDataGridView();

            xcon.textDuzenle(txtsporcuAdi,txtsporcuSoyAdi,btnSil);
     
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            spControll.silme(urunid);
            gosterDataGridView();
            silmeLog.LogSilme1("Sporcu Silme Yapıldı", ad, soyad, diger, ligi);
        }

        private void dgListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunid = (int)dgListele.CurrentRow.Cells["id"].Value;
            ad = (string)dgListele.CurrentRow.Cells["adi"].Value;//daydin
            soyad = (string)dgListele.CurrentRow.Cells["soyadi"].Value;
            ligi = (string)dgListele.CurrentRow.Cells["ligi"].Value;
            diger = (string)dgListele.CurrentRow.Cells["diger"].Value;
        }

        private void duzenleSil_Click(object sender, EventArgs e)
        {
            spControll.silme(urunid);
            silmeLog.LogSilme1("Sporcu Silme Yapıldı", ad, soyad, diger, ligi);
            gosterDataGridView1();
        }

        private void gosterDataGridView1()
        {
            sporcuDataClassesDataContext datacon = new sporcuDataClassesDataContext();
            dgDuzenleGoster.DataSource = datacon.sporcuPenceresiDbs;
        }

        private void duzenleGoster_Click(object sender, EventArgs e)
        {
            gosterDataGridView1();
        }

        private void dgDuzenleGoster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunid = (int)dgDuzenleGoster.CurrentRow.Cells["id"].Value;
            ad = (string)dgDuzenleGoster.CurrentRow.Cells["adi"].Value;//daydin
            soyad = (string)dgDuzenleGoster.CurrentRow.Cells["soyadi"].Value;
            ligi = (string)dgDuzenleGoster.CurrentRow.Cells["ligi"].Value;
            diger = (string)dgDuzenleGoster.CurrentRow.Cells["diger"].Value;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            string adi,soyadi,digeri,ligi;
            sporcuDataClassesDataContext sporcudata = new sporcuDataClassesDataContext();
              sporcuPenceresiDb dbsporcu = sporcudata.sporcuPenceresiDbs.SingleOrDefault(urun => urun.id == this.urunid);
              dbsporcu.adi = txtAdi.Text;
            adi = txtAdi.Text.ToString();//logger update

            dbsporcu.soyadi = txtSoyadi.Text;
            soyadi = txtSoyadi.Text.ToString();//logger update

            dbsporcu.diger = txtDiger.Text;
            digeri = txtDiger.Text.ToString();//logger update

            dbsporcu.ligi = cmbLigi.Text;
            ligi = cmbLigi.Text.ToString();//logger update
              sporcudata.SubmitChanges();
            spGuncelLog.LogSporcuGuncelle("Sporcu Güncelleme Yapıldı", adi, soyadi, digeri, ligi);
               gosterDataGridView1();
           
        }

        private void duzenleGridSporcu()
        {
            DataGridViewRow row = dgDuzenleGoster.CurrentRow;
            txtAdi.Text = row.Cells["adi"].Value.ToString();
            txtAdi.Tag = row.Cells["adi"].Value;
            
            txtSoyadi.Text = row.Cells["soyadi"].Value.ToString();
            txtSoyadi.Tag = row.Cells["soyadi"].Value;
           
            txtDiger.Text = row.Cells["diger"].Value.ToString();
            txtDiger.Tag = row.Cells["diger"].Value;
           
            cmbLigi.SelectedItem = row.Cells["ligi"].Value.ToString();
            cmbLigi.SelectedItem = row.Cells["ligi"].Value;
            
        }
        private void dgDuzenleGoster_DoubleClick(object sender, EventArgs e)
        {
            duzenleGridSporcu();
        }

        private void btnStadyum_Click(object sender, EventArgs e)
        {
            stadyumPenWindow stdpen = new stadyumPenWindow();
            stdpen.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void araSporcu1()
        {
            sporcuDataClassesDataContext sporcuCon = new sporcuDataClassesDataContext();
            dgDuzenleGoster.DataSource = sporcuCon.sporcuPenceresiDbs.Where(x => x.soyadi.Contains(txtsoyadara.Text));
        }
        private void txtsoyadara_TextChanged(object sender, EventArgs e)
        {
            araSporcu1();
        }

        private void txtsporcuAdi_BackColorChanged(object sender, EventArgs e)
        {
           
        }
        hakemPenWindow hk=new hakemPenWindow();
        stadyumModell stm = new stadyumModell();
        stadyumPenWindow st=new stadyumPenWindow();

        hakemmodell hkm=new hakemmodell();

        private void button3_Click(object sender, EventArgs e)
        {
            eslemTable esleme = new eslemTable();
            esleme.Show();
        }

       

        private void araSporcu()
        {
            sporcuDataClassesDataContext sporcuCon = new sporcuDataClassesDataContext();
            dgDuzenleGoster.DataSource = sporcuCon.sporcuPenceresiDbs.Where(x => x.adi.Contains(txtaraSprocu.Text));
        }

        private void txtaraSprocu_TextChanged(object sender, EventArgs e)
        {
            araSporcu();
        }      

        private void button2_Click_1(object sender, EventArgs e)
        {
            hakemPenWindow hakpen = new hakemPenWindow();
            hakpen.Show();
          
        }

    

       
    }
}

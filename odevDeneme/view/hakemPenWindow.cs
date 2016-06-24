using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Data.Odbc;
using Npgsql;
using System.Configuration;

namespace odevDeneme
{
    public partial class hakemPenWindow : Form
    {
        public int urunid;
        hakemController hakCont;
        hakemmodell hakmodel;

        ComponentConfiguration cmp = ComponentConfiguration.ComponentConXml();

        hakemEklemeLogger hkm = hakemEklemeLogger.hakemEkleLogger();

        hakemSilmeLogger hkmSilmelogger = hakemSilmeLogger.hakemsilmelogger();

        hakemLoggerGuncelleme hkmGuncelLogger = hakemLoggerGuncelleme.hkmGuncell();


       string adi, soyadi, klasman, bolge, grup, tur;

       
        
        hakemlerPenceresiDb hdb;
        public hakemPenWindow()
        {
            
            hakCont = new hakemController();
            hakmodel = new hakemmodell();
            InitializeComponent();
        }
        private void temizleForm()
        {
            txthakemAdi.Clear();
            txthakemSoyAdi.Clear();
            txthakemgrup.Clear();
            txthakemturu.Clear();
            hakemklasmanCombo.Text = "";
            txtbolgehakem.Clear();

        }
        private void ekleHakem_Click(object sender, EventArgs e)
        {
            
            getValueDb();
            hakCont.publickaydet(hakmodel);
            gosterhakemDataGridView();
            hkm.LogHakemKaydet("Hakem Kayıt Yapıldı", hakmodel.HakemAdi.ToString(), hakmodel.HakemSoyAdi.ToString(), hakmodel.HakemKlasman.ToString(), hakmodel.HakemBolge.ToString(), hakmodel.HakemGrub.ToString(), hakmodel.HakemTuru.ToString());
            temizleForm();
        }

        private void getValueDb()
        {
            hakmodel.HakemAdi = txthakemAdi.Text;
            hakmodel.HakemSoyAdi = txthakemSoyAdi.Text;
            hakmodel.HakemKlasman = hakemklasmanCombo.Text;
            hakmodel.HakemBolge = txtbolgehakem.Text;
            hakmodel.HakemGrub = txthakemgrup.Text;
            hakmodel.HakemTuru = txthakemturu.Text;
            hakCont.setModel(hakmodel);
        }

        private void gosterhakemDataGridView()
        {
            hakemlerdbDataClassesDataContext hakdbcon = new hakemlerdbDataClassesDataContext();
            dgListele.DataSource = hakdbcon.hakemlerPenceresiDbs;
        }
        private void gosterhakemDataGridView1()
        {
            hakemlerdbDataClassesDataContext hakdbcon = new hakemlerdbDataClassesDataContext();
            dgDuzenleGoster.DataSource = hakdbcon.hakemlerPenceresiDbs;
        }
        private void dggosterhakemDataGridView()
        {
            hakemlerdbDataClassesDataContext hakdbcon = new hakemlerdbDataClassesDataContext();
            dgDuzenleGoster.DataSource = hakdbcon.hakemlerPenceresiDbs;
        }

        private void listele_Click(object sender, EventArgs e)
        {
            gosterhakemDataGridView();
            cmp.textDuzenle(txthakemAdi, txthakemSoyAdi, btnSil);
        }

        private void dgListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunid = (int)dgListele.CurrentRow.Cells["id"].Value;
            adi = (string)dgListele.CurrentRow.Cells["adi"].Value;
            soyadi = (string)dgListele.CurrentRow.Cells["soyadi"].Value;
            klasman = (string)dgListele.CurrentRow.Cells["klasman"].Value;
            bolge = (string)dgListele.CurrentRow.Cells["bolge"].Value;
            grup = (string)dgListele.CurrentRow.Cells["grup"].Value;
            tur = (string)dgListele.CurrentRow.Cells["turu"].Value;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            hakCont.publicsilme(urunid);
            gosterhakemDataGridView();
            hkmSilmelogger.LogHakemSilme("Hakem Silme İşlemi Yapıldı", adi, soyadi, klasman, bolge, grup, tur);
           
        }

        private void txtaraHakem_TextChanged(object sender, EventArgs e)
        {
            araHakem();
        }

        private void araHakem()
        {
            hakemlerdbDataClassesDataContext hakdata = new hakemlerdbDataClassesDataContext();
            dgDuzenleGoster.DataSource = hakdata.hakemlerPenceresiDbs.Where(x => x.adi.Contains(txtaraHakem.Text));

        }
        private void araSoyadHakem()
        {
            hakemlerdbDataClassesDataContext hakdata = new hakemlerdbDataClassesDataContext();
            dgDuzenleGoster.DataSource = hakdata.hakemlerPenceresiDbs.Where(x => x.soyadi.Contains(txtsoyadara.Text));

        }

        private void duzenleGoster_Click(object sender, EventArgs e)
        {
            dggosterhakemDataGridView();
        }

        private void dgDuzenleGoster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            urunid = (int)dgDuzenleGoster.CurrentRow.Cells["id"].Value;
            adi = (string)dgDuzenleGoster.CurrentRow.Cells["adi"].Value;
            soyadi = (string)dgDuzenleGoster.CurrentRow.Cells["soyadi"].Value;
            klasman = (string)dgDuzenleGoster.CurrentRow.Cells["klasman"].Value;
            bolge = (string)dgDuzenleGoster.CurrentRow.Cells["bolge"].Value;
            grup = (string)dgDuzenleGoster.CurrentRow.Cells["grup"].Value;
            tur = (string)dgDuzenleGoster.CurrentRow.Cells["turu"].Value;
        }

        private void hakemklasmanCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void duzenleSil_Click(object sender, EventArgs e)
        {
            hakCont.publicsilme(urunid);
            dggosterhakemDataGridView();
            hkmSilmelogger.LogHakemSilme("Hakem Silme İşlemi Yapıldı", adi, soyadi, klasman, bolge, grup, tur);



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            hakemlerdbDataClassesDataContext hakdata = new hakemlerdbDataClassesDataContext();
            hakemlerPenceresiDb hakdb = hakdata.hakemlerPenceresiDbs.SingleOrDefault(urun => urun.id == this.urunid);
            hakdb.adi = txthakemadi1.Text;
            adi = txthakemadi1.Text.ToString();//logger update

            hakdb.soyadi = txthakemsoyadi1.Text;
            soyadi = txthakemsoyadi1.Text.ToString();//logger update

            hakdb.klasman = cmbhakemklasman1.Text;
            klasman = cmbhakemklasman1.Text.ToString();//logger update

            hakdb.bolge = txthakembolge1.Text;
            bolge = txthakembolge1.Text.ToString();//logger update

            hakdb.grup = txthakemgrup1.Text;
            grup = txthakemturu1.Text.ToString();//logger update

            //hakdb.grup = txthakemgrup1.Text;
            hakdb.turu = txthakemturu1.Text;
            tur = txthakemturu1.Text.ToString();//logger update

            hakdata.SubmitChanges();

            hkmGuncelLogger.LogHakemGuncel("Hakem Güncelleme İşlemi Yapıldı", adi, soyadi, klasman, bolge, grup, tur);

            gosterhakemDataGridView1();




        }
        private void duzenleGridHakem()
        {
            DataGridViewRow row1 = dgDuzenleGoster.CurrentRow;
            txthakemadi1.Text = row1.Cells["adi"].Value.ToString();
            txthakemadi1.Tag = row1.Cells["adi"].Value;


            txthakemsoyadi1.Text = row1.Cells["soyadi"].Value.ToString();
            txthakemsoyadi1.Tag = row1.Cells["soyadi"].Value;

            cmbhakemklasman1.SelectedItem = row1.Cells["klasman"].Value.ToString();
            cmbhakemklasman1.SelectedItem = row1.Cells["klasman"].Value;

            txthakembolge1.Text = row1.Cells["bolge"].Value.ToString();
            txthakembolge1.Tag = row1.Cells["bolge"].Value;

            txthakemgrup1.Text = row1.Cells["grup"].Value.ToString();
            txthakemgrup1.Tag = row1.Cells["grup"].Value;

            txthakemturu1.Text = row1.Cells["turu"].Value.ToString();
            txthakemturu1.Tag = row1.Cells["turu"].Value;

        }

        private void dgDuzenleGoster_DoubleClick(object sender, EventArgs e)
        {
            duzenleGridHakem();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            araSoyadHakem();
        }

       
    }
}






    


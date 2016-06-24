using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevDeneme
{
    public partial class stadyumPenWindow : Form
    {
        public int urunid;
        public int stadid;

        string ad, sehir, lig, diger;


        guncelleloggerStadyum gnclogger = guncelleloggerStadyum.guncelleStadyumlogger();

         silmeStadyumLogger stdSilmeLogger = silmeStadyumLogger.silmeStadyum();

        stadyumLoggerKaydet stdloggerKaydet = stadyumLoggerKaydet.kaydetstadyum();

        

        stadyumController stdcontroller;

        stadyumModell stdmodell;

        public stadyumPenWindow()
        {
            stdcontroller = new stadyumController();
            stdmodell = new stadyumModell();
            InitializeComponent();
        }
        private void getValueDbstd()
        {
            stdmodell.StadyumAdi = txtstdAdi.Text;
            stdmodell.StadyumLigi = stdLigiCombo.Text;
            stdmodell.StadyumSehir = txtstdsehir.Text;
            stdmodell.StadyumDiger = txtdigerstd.Text;
            stdcontroller.setModelS(stdmodell);
            
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            gosterGrid();
        }

        public void gosterGrid()
        {
            stadyumDataClassesDataContext stdcon = new stadyumDataClassesDataContext();
            dgListele.DataSource = stdcon.stadyumPenceresiDbs;
        }

        public void gosterGrid1()
        {
            stadyumDataClassesDataContext stdcon = new stadyumDataClassesDataContext();
            dgDuzenleGoster.DataSource = stdcon.stadyumPenceresiDbs;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            getValueDbstd();
            stdcontroller.stKaydet(stdmodell);
            gosterGrid();
            stdloggerKaydet.LogStadyumKaydet("Stadyum Ekleme Başarılı", stdmodell.StadyumAdi.ToString(), stdmodell.StadyumSehir.ToString(), stdmodell.StadyumLigi.ToString(), stdmodell.StadyumDiger.ToString());

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            stdcontroller.stdSilmeDataBase(urunid);
            gosterGrid();
           stdSilmeLogger.LogStadyumSilme("Stadyum Silme Başarılı", ad,sehir, lig, diger);

        }
        private void dgListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            urunid = (int)dgListele.CurrentRow.Cells["id"].Value;

            ad = (string)dgListele.CurrentRow.Cells["adi"].Value;

            sehir = (string)dgListele.CurrentRow.Cells["sehir"].Value;

            lig = (string)dgListele.CurrentRow.Cells["ligi"].Value;

            diger = (string)dgListele.CurrentRow.Cells["diger"].Value;
        }

        private void duzenleSil_Click(object sender, EventArgs e)
        {
            stdcontroller.stdSilmeDataBase(stadid);
            gosterGrid1();
            stdSilmeLogger.LogStadyumSilme("Stadyum Silme Başarılı", ad, sehir, lig, diger);

        }

        private void dgDuzenleGoster_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgDuzenleGoster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            urunid = (int)dgDuzenleGoster.CurrentRow.Cells["id"].Value;

            ad = (string)dgDuzenleGoster.CurrentRow.Cells["adi"].Value;

            sehir = (string)dgDuzenleGoster.CurrentRow.Cells["sehir"].Value;

            lig = (string)dgDuzenleGoster.CurrentRow.Cells["ligi"].Value;

            diger = (string)dgDuzenleGoster.CurrentRow.Cells["diger"].Value;
        }

        private void duzenleGoster_Click(object sender, EventArgs e)
        {
            gosterGrid1();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
             stadyumDataClassesDataContext stdcon = new stadyumDataClassesDataContext();
             stadyumPenceresiDb stdDb = stdcon.stadyumPenceresiDbs.SingleOrDefault(urun => urun.id == urunid);

             stdDb.adi = txtAdi.Text;
            ad = txtAdi.Text.ToString();

            stdDb.diger = txtDiger.Text;
            diger = txtDiger.Text.ToString();


             stdDb.ligi = cmbLigistd.Text;
            lig = cmbLigistd.Text.ToString();

             stdDb.sehir = txtSehir.Text;
            sehir = txtSehir.Text.ToString();

             stdcon.SubmitChanges();
            //stdcontroller.guncelleDT(urunid);

            gnclogger.LogStadyumGuncelle("Stadyum Güncellendi", ad, sehir, lig, diger);
            gosterGrid1();
            
        }

        private void txtaraStad_TextChanged(object sender, EventArgs e)
        {
            ligara();
        }

        private void dgDuzenleGoster_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = dgDuzenleGoster.CurrentRow;
            txtAdi.Text = row.Cells["adi"].Value.ToString();
            txtAdi.Tag = row.Cells["adi"].Value;

            txtDiger.Text = row.Cells["diger"].Value.ToString();
            txtDiger.Tag = row.Cells["diger"].Value;

            cmbLigistd.Text = row.Cells["ligi"].Value.ToString();
            cmbLigistd.Tag = row.Cells["ligi"].Value;

            txtSehir.Text = row.Cells["sehir"].Value.ToString();
            txtSehir.Tag = row.Cells["sehir"].Value;




        }

        private void araStad()
        {

            stadyumDataClassesDataContext stdcon = new stadyumDataClassesDataContext();
            dgDuzenleGoster.DataSource = stdcon.stadyumPenceresiDbs.Where(x => x.adi.Contains(txtarastd.Text));
        }
        private void ligara()
        {

            stadyumDataClassesDataContext stdcon = new stadyumDataClassesDataContext();
            dgDuzenleGoster.DataSource = stdcon.stadyumPenceresiDbs.Where(x => x.ligi.Contains(txtaraStadSoay.Text));
        }

        private void txtarastd_TextChanged(object sender, EventArgs e)
        {
            araStad();
        }
    }
}

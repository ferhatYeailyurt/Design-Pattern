using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevDeneme
{
    class stadyumController
    {
        public TextBox txtAdi;

        stadyumModell stadyumModel;
        public int stadid;
        public int urunid;

        public stadyumController()
        {

        }

        public stadyumController(stadyumModell sm)
        {
            this.stadyumModel = sm;
        }

        public void setModelS(stadyumModell sm)
        {
            this.stadyumModel = sm;
        }

        private void stadyumKaydet()
        {
            try
            {
                stadyumDataClassesDataContext stdcon = new stadyumDataClassesDataContext();
                stadyumPenceresiDb stddb = new stadyumPenceresiDb();
                stddb.adi = stadyumModel.StadyumAdi;
                stddb.ligi = stadyumModel.StadyumLigi;
                stddb.sehir = stadyumModel.StadyumSehir;
                stddb.diger = stadyumModel.StadyumDiger;
                stdcon.stadyumPenceresiDbs.InsertOnSubmit(stddb);
                stdcon.SubmitChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı");
            }
           
        }

        public void stKaydet(stadyumModell sm)
        {
            stadyumKaydet();
        }

        private void stdSilme(int urunid)
        {
            stadyumDataClassesDataContext stdcon = new stadyumDataClassesDataContext();
            stadyumPenceresiDb stddb = stdcon.stadyumPenceresiDbs.SingleOrDefault(stad =>stad.id  == urunid);


            stdcon.stadyumPenceresiDbs.DeleteOnSubmit(stddb);
            stdcon.SubmitChanges();


        }


      /*  private void guncelle(int urunid) 
        {
            stadyumDataClassesDataContext stdcon = new stadyumDataClassesDataContext();
            stadyumPenceresiDb stdDb = stdcon.stadyumPenceresiDbs.SingleOrDefault(urun => urun.id == urunid);

            stdDb.adi = txtAdi.Text;
            stdDb.diger = stadyumModel.StadyumDiger;
            stdDb.ligi = stadyumModel.StadyumLigi;
            stdDb.sehir = stadyumModel.StadyumSehir;
            stdcon.SubmitChanges();
        }

        public void guncelleDT(int urunid)
        {
            guncelle(urunid);
        }*/
       /* private void dgDuzenleGosterDb() 

        {
            DataGridViewRow row = dgDuzenleGoster.CurrentRow;
            txtAdi.Text =row.Cells["adi"].Value.ToString();
            txtAdi.Tag = row.Cells["adi"].Value;

            txtDiger.Text = row.Cells["diger"].Value.ToString();
            txtDiger.Tag = row.Cells["diger"].Value;

            cmbLigistd.Text = row.Cells["ligi"].Value.ToString();
            cmbLigistd.Tag = row.Cells["ligi"].Value;

            txtSehir.Text = row.Cells["sehir"].Value.ToString();
            txtSehir.Tag = row.Cells["sehir"].Value;
        }*/


        public void stdSilmeDataBase(int urunid)
        {
            stdSilme(urunid);

        }

        private void stdguncelleme(int urunid)
        {
            stadyumDataClassesDataContext stdcon = new stadyumDataClassesDataContext();
            stadyumPenceresiDb stdDb = stdcon.stadyumPenceresiDbs.SingleOrDefault(urun => urun.id == this.urunid);
            stdDb.adi = stadyumModel.StadyumAdi;
            stdcon.SubmitChanges();

        }

        public void stdGuncel(int urunid)
        {
            stdguncelleme(urunid);
        }
    }
}

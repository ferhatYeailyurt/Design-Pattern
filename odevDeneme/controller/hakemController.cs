using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevDeneme
{
    class hakemController
    {
        
        hakemmodell hakModel;
       
        public int urunid;

        
        public hakemController()
        {
            
        }

        public hakemController(hakemmodell h)
        {
            this.hakModel = h;
        }

        public void setModel(hakemmodell h)
        {
            this.hakModel = h;
        }

        public void publickaydet(hakemmodell h)
        {
            privateKaydet();           
        }
                   /* public void dataconString(hakemlerdbDataClassesDataContext hakdata,hakemlerPenceresiDb hakdb)
                    {
                         hakdata = new hakemlerdbDataClassesDataContext();
                        hakdb = new hakemlerPenceresiDb();
                    }*/
        private  void  privateKaydet()
        {
            try
            {
               
                hakemlerdbDataClassesDataContext hakdata = new hakemlerdbDataClassesDataContext();
               hakemlerPenceresiDb hakDb = new hakemlerPenceresiDb();
               hakDb.adi = hakModel.HakemAdi;
                hakDb.soyadi = hakModel.HakemSoyAdi;
                hakDb.klasman = hakModel.HakemKlasman;
                hakDb.bolge = hakModel.HakemBolge;
                hakDb.grup = hakModel.HakemGrub;
                hakDb.turu = hakModel.HakemTuru;
                hakdata.hakemlerPenceresiDbs.InsertOnSubmit(hakDb);
                hakdata.SubmitChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("yanlış işlem yapıldı.");
            }
        }

        public void publicsilme(int urunid)
        {
            privateSilne(urunid);
        }

        private void privateSilne(int urunid)
        {
            hakemlerdbDataClassesDataContext hakdata = new hakemlerdbDataClassesDataContext();
            hakemlerPenceresiDb hakDb = hakdata.hakemlerPenceresiDbs.SingleOrDefault(hakem => hakem.id == urunid);

            hakdata.hakemlerPenceresiDbs.DeleteOnSubmit(hakDb);
            hakdata.SubmitChanges();
                

        }
        

    }
}

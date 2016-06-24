using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevDeneme
{
    class sporcuController
    {
        sporcuModell sporcuModelexam;
        public int urunid;


        public sporcuController()
        {

        }

        public sporcuController(sporcuModell s)
        {
            this.sporcuModelexam = s;

        }


        public void setModel(sporcuModell s)
        {
            this.sporcuModelexam = s;
        }





        public int karakterSay()
        {

            return (sporcuModelexam.SporcuAdi + sporcuModelexam.SporcuSoyadi).Length;
        }




        private void kaydetDataBase()
        {

            try
            {
                sporcuDataClassesDataContext spDataCon = new sporcuDataClassesDataContext();
                sporcuPenceresiDb sporcu = new sporcuPenceresiDb();

                sporcu.adi = sporcuModelexam.SporcuAdi;
                sporcu.soyadi = sporcuModelexam.SporcuSoyadi;
                sporcu.diger = sporcuModelexam.SporcuDiger;
                sporcu.ligi = sporcuModelexam.SporcuLigi;
                spDataCon.sporcuPenceresiDbs.InsertOnSubmit(sporcu);
                spDataCon.SubmitChanges();
            }

            catch (Exception )
            {
                MessageBox.Show("Lütfen İşlemleri Kontrol Ediniz ");
            }
        }

        public void kaydet(sporcuModell s)
        {
            kaydetDataBase();

        }



        public void silme(int urunid)
        {
            silmeDatabase(urunid);
            
        }




        private void silmeDatabase(int urunid)
        {
            sporcuDataClassesDataContext datacon = new sporcuDataClassesDataContext();
            sporcuPenceresiDb sportu = datacon.sporcuPenceresiDbs.SingleOrDefault(sporcu => sporcu.id== urunid);

            datacon.sporcuPenceresiDbs.DeleteOnSubmit(sportu);
            datacon.SubmitChanges();


        }

       /* private void guncellemeSporcu()
        {
            
            sporcuDataClassesDataContext sporcudata = new sporcuDataClassesDataContext();
            sporcuPenceresiDb dbsporcu = new sporcuPenceresiDb();
             dbsporcu=   sporcudata.sporcuPenceresiDbs.SingleOrDefault(urun => urun.id == urunid);
            dbsporcu.adi = sporcuModelexam.SporcuAdi;
            /* dbsporcu.soyadi = spo
             dbsporcu.diger = txtDiger.Text;
             dbsporcu.ligi = cmbLigi.Text;
            sporcudata.SubmitChanges();
           
            
        }

        public void guncel(sporcuModell s)
        {
            guncellemeSporcu();
        }
        */
    }
}

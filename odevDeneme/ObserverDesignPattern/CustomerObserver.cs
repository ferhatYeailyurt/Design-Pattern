using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace odevDeneme
{
    class CustomerObserver : Observer
    {
        Random rnd = new Random();

        fikstur eslestir = new fikstur();

        eslemTablo est = new eslemTablo();

        EslemeTableDataClassesDataContext eslemedatacon = new EslemeTableDataClassesDataContext();

        hakemlerdbDataClassesDataContext hakemcon = new hakemlerdbDataClassesDataContext();

        stadyumDataClassesDataContext stadcon = new stadyumDataClassesDataContext();


        public override void loggerSave()
        {
            islemDatabaseDataClassesDataContext islemContext = new islemDatabaseDataClassesDataContext();
            islemBilgiDb islemdb = new islemBilgiDb();
            islemdb.islem = "Atama İşlemleri Yapıldı.";
            islemdb.zaman = DateTime.Now;
     
            islemContext.islemBilgiDbs.InsertOnSubmit(islemdb);
            islemContext.SubmitChanges();
        }
        public override void Update()
        {
            List<fikstur> _fikstur_olustur = new List<fikstur>();
            eslestir.takimlar(_fikstur_olustur);

            List<fikstur> _fikstur_olusturhk = new List<fikstur>();
            eslestir.hakemler(_fikstur_olusturhk);


            int counthakem = hakemcon.hakemlerPenceresiDbs.Count();

            int countstad = stadcon.stadyumPenceresiDbs.Count();
           

            int[] dizi1hakem = new int[counthakem];

            int[] dizi2hakem = new int[counthakem];

            int[] dizi3stad = new int[countstad];

            Random rndstad = new Random();

            var sorgu = from stad in stadcon.stadyumPenceresiDbs select new { stad.id };
            List<int> saha = new List<int>();

            int ia = 0;
            foreach (var item in sorgu)
            {

                dizi3stad[ia] = item.id;
                    ia++;
            }
           
            int count = saha.Count();
            int[] dizi = new int[count];

            int i = 1;
            foreach (var item in _fikstur_olusturhk)
            {
                dizi1hakem[i - 1] = item.evsahibi;

                dizi2hakem[i - 1] = item.deplasman;
                i++;
                if (i == counthakem + 1)
                    break;

            }           
            rnd.Next(0, counthakem);
            foreach (var result in _fikstur_olustur)
            {

                eslemTablo eslemveriler = new eslemTablo
                {
                    sp1id = result.evsahibi,
                    sp2id = result.deplasman,
                    hkid = dizi1hakem[rnd.Next(0, counthakem)],
                    hk2id = dizi2hakem[rnd.Next(0, counthakem)],
                    stid = dizi3stad[rndstad.Next(0,countstad)],

                };
                eslemedatacon.eslemTablos.InsertOnSubmit(eslemveriler);
                eslemedatacon.SubmitChanges();
               }

        }

    }
}

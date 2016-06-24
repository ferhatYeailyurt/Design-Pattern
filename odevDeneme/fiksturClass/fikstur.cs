using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevDeneme
{
    class fikstur
    {
        sporcuDataClassesDataContext sporcudatacon = new sporcuDataClassesDataContext();

        sporcuPenceresiDb sporcudb = new sporcuPenceresiDb();

        hakemlerdbDataClassesDataContext hakemdatacon = new hakemlerdbDataClassesDataContext();

        hakemlerPenceresiDb hakemdb = new hakemlerPenceresiDb();


        eslestirmeclass _fikstur = new eslestirmeclass();

        public int evsahibi { get; set; }

        public int deplasman { get; set; }

       


        public void hakemler(List<fikstur> haftalik)
        {

            int i = 0, k1 = 0;

            var sorgu_hakemler = from hakem1 in hakemdatacon.hakemlerPenceresiDbs select new { hakem1.id };

            int m = sorgu_hakemler.Count();

            int[] hakemler = new int[m];

            foreach (var result in sorgu_hakemler)
            {
                hakemler[k1] = result.id;
                k1++;


            }


            List<fikstur> hakem = new List<fikstur>();
            for (i = 0; i < hakemler.Count(); i++)
            {
                for (int j = 0; j < hakemler.Count(); j++)
                {
                    if (hakemler[i] != hakemler[j])
                    {
                        hakem.Add(new fikstur() { evsahibi = hakemler[i], deplasman = hakemler[j] });
                    }
                }
            }
            hakem.Reverse();


            int sezonhk = (hakemler.Length - 1) * 2;
            int yari_sezonhk = sezonhk / 2;

            for (int k = 0; k < sezonhk; k++)
            {
                haftalik.AddRange(_fikstur.fiksturhk_ayarla(hakem, sezonhk));
            }


        }

        public void takimlar(List<fikstur> haftalik)
        {

            int i = 0;


            
            var sorgu_takimlar = from sporcu in sporcudatacon.sporcuPenceresiDbs
                                 select new { sporcu.id };

            
            int n = sorgu_takimlar.Count();

            int[] takimlar = new int[n];
                                 
            foreach (var result in sorgu_takimlar)
            {
                takimlar[i] = result.id;
                i++;
                
            }
           
       
            List<fikstur> maclar = new List<fikstur>();

            for (i = 0; i < takimlar.Count(); i++)
            {
                for (int j = 0; j < takimlar.Count(); j++)
                {
                    if (takimlar[i] != takimlar[j])
                    {
                        maclar.Add(new fikstur() { evsahibi = takimlar[i], deplasman = takimlar[j] });
                    }
                }
            }

            maclar.Reverse();


            int sezon = (takimlar.Length - 1) * 2;
            int yari_sezon = sezon / 2;

            for (int k = 0; k < sezon; k++)
            {
                haftalik.AddRange(_fikstur.fikstur_ayarla(maclar, sezon));
            }
        }

    }
      


            

    }


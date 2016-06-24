using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevDeneme
{
    class eslestirmeclass
    {
        public List<fikstur> fikstur_ayarla(List<fikstur> ayarla, int haftlar)
        {
            List<fikstur> result = new List<fikstur>();
          
            for (int i = 0; i < haftlar; i++)
            {
                for (int j = ayarla.Count - 1; j >= 0; j--)
                {
                    if (!result.Any(r => r.evsahibi == ayarla[j].evsahibi || r.deplasman == ayarla[j].evsahibi || r.evsahibi == ayarla[j].deplasman || r.deplasman == ayarla[j].deplasman))
                    {

                        result.Add(ayarla[j]);
                        ayarla.RemoveAt(j);
                    }
                }
            }

            return result;
        }


        public List<fikstur> fiksturhk_ayarla(List<fikstur> ayarla, int haftlar)
        {
            List<fikstur> result = new List<fikstur>();
            ///
            for (int i = 0; i < haftlar; i++)
            {
                for (int j = ayarla.Count - 1; j >= 0; j--)
                {
                    if (!result.Any(r => r.evsahibi == ayarla[j].evsahibi || r.deplasman == ayarla[j].evsahibi || r.evsahibi == ayarla[j].deplasman || r.deplasman == ayarla[j].deplasman))
                    {

                        result.Add(ayarla[j]);
                        ayarla.RemoveAt(j);
                    }
                }
            }

            return result;
        }
    }
}

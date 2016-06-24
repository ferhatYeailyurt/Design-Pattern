using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevDeneme
{
    class stadyumModell
    {
        private String stadyumAdi;

        public string StadyumAdi
        {
            get
            {
                return stadyumAdi;
            }

            set
            {
                stadyumAdi = value;
            }
        }

        public string StadyumSehir
        {
            get
            {
                return stadyumSehir;
            }

            set
            {
                stadyumSehir = value;
            }
        }

        public string StadyumLigi
        {
            get
            {
                return stadyumLigi;
            }

            set
            {
                stadyumLigi = value;
            }
        }

        public string StadyumDiger
        {
            get
            {
                return stadyumDiger;
            }

            set
            {
                stadyumDiger = value;
            }
        }

        private String stadyumSehir;

        private String stadyumLigi;

        private String stadyumDiger;

    }
}

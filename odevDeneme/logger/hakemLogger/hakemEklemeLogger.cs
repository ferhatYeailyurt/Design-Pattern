using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevDeneme
{
    class hakemEklemeLogger
    {
        private string m_exePath = string.Empty;

        private volatile static hakemEklemeLogger hkmLogger;

        private static Object lock_objHakemKaydet = new Object();



        private hakemEklemeLogger()
        {

        }


        public static hakemEklemeLogger hakemEkleLogger()
        {
            lock (lock_objHakemKaydet)
            {
                if (hkmLogger == null)
                {
                    hkmLogger = new hakemEklemeLogger();
                }

                return hkmLogger;
            }


        }


        public void LogHakemKaydet(string logMessage, string textadi, string textsoyadi, string textklasman, string textbolge,string textgrup,string texttur)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
                {
                    LogHakemKaydet1(logMessage, w, textadi, textsoyadi, textklasman,textbolge,textgrup,texttur);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void LogHakemKaydet1(string logMessage, TextWriter txtWriter, string textadi, string textsoyadi, string textklasman, string textbolge, string textgrup, string texttur)
        {
            try
            {
                txtWriter.Write("\r\n Hakem Logger Kaydet İşlemleri : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :  ");
                txtWriter.WriteLine("  Kayıt Mesajı: :{0} Adı: {1} Soyadı: {2} Klasman: {3} Bolge: {4} Grup: {5} Turu: {6}", logMessage, textadi, textsoyadi, textklasman, textbolge, textgrup, texttur);
                txtWriter.WriteLine("----------------------------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı işlem", "mesaj");
            }
        }
    }
}

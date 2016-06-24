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
    class hakemLoggerGuncelleme
    {
        private string m_exePath = string.Empty;

        private volatile static hakemLoggerGuncelleme hkmGuncelLogger;

        private static Object lock_objHakemGuncel = new Object();

        public static hakemLoggerGuncelleme hkmGuncell()
        {
            lock(lock_objHakemGuncel)
            {
                if(hkmGuncelLogger==null)
                {
                    hkmGuncelLogger = new hakemLoggerGuncelleme();
                }
              return  hkmGuncelLogger;
            }
        }
        private hakemLoggerGuncelleme()
        {

        }

        public void LogHakemGuncel(string logMessage, string textadi, string textsoyadi, string textklasman, string textbolge, string textgrup, string texttur)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
                {
                    LogHakemGuncel1(logMessage, w, textadi, textsoyadi, textklasman, textbolge, textgrup, texttur);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void LogHakemGuncel1(string logMessage, TextWriter txtWriter, string textadi, string textsoyadi, string textklasman, string textbolge, string textgrup, string texttur)
        {
            try
            {
                txtWriter.Write("\r\n Hakem Logger Güncelleme İşlemleri : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :  ");
                txtWriter.WriteLine("  Güncelleme Mesajı: :{0} Adı: {1} Soyadı: {2} Klasman: {3} Bolge: {4} Grup: {5} Turu: {6}", logMessage, textadi, textsoyadi, textklasman, textbolge, textgrup, texttur);
                txtWriter.WriteLine("----------------------------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı işlem", "mesaj");
            }
        }
    }
}

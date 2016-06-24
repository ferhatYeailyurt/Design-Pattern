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
    class hakemSilmeLogger
    {
        
        private string m_exePath = string.Empty;

        private volatile static hakemSilmeLogger hkmSilmeLogger;

        private static Object lock_objHakemSilme = new Object();

        public static hakemSilmeLogger hakemsilmelogger()
        {
            lock(lock_objHakemSilme)
            {
                if(hkmSilmeLogger==null)
                {
                    hkmSilmeLogger = new hakemSilmeLogger();
                }
                return hkmSilmeLogger;
            }
        }

        private hakemSilmeLogger()
        {

        }


        public void LogHakemSilme(string logMessage, string textadi, string textsoyadi, string textklasman, string textbolge, string textgrup, string texttur)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
                {
                    LogHakemSilme1(logMessage, w, textadi, textsoyadi, textklasman, textbolge, textgrup, texttur);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void LogHakemSilme1(string logMessage, TextWriter txtWriter, string textadi, string textsoyadi, string textklasman, string textbolge, string textgrup, string texttur)
        {
            try
            {
                txtWriter.Write("\r\n Hakem Logger Silme İşlemleri : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :  ");
                txtWriter.WriteLine("  Silme Mesajı: :{0} Adı: {1} Soyadı: {2} Klasman: {3} Bolge: {4} Grup: {5} Turu: {6}", logMessage, textadi, textsoyadi, textklasman, textbolge, textgrup, texttur);
                txtWriter.WriteLine("----------------------------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı işlem", "mesaj");
            }
        }
    }
}

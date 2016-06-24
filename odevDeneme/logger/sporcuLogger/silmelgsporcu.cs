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
    class silmelgsporcu
    {

        private string m_exePath = string.Empty;

        private volatile static silmelgsporcu silmmelg;

        private static Object lock_objSporcu = new Object();


        private  silmelgsporcu()
        {

        }

        public static silmelgsporcu silmeSporcu()
        {
            lock (lock_objSporcu)
            {
                if (silmmelg == null)
                {
                    silmmelg = new silmelgsporcu();
                }
                return silmmelg;
            }

        }

        public void LogSilme1(string logMessage, string textadi, string textsoyadi,string textdiger,string textligi)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
                {
                    LogSilme(logMessage, w, textadi, textsoyadi,textdiger,textligi);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void LogSilme(string logMessage, TextWriter txtWriter, string textadi, string textsoyadi,string textdiger,string textlig)
        {
            try
            {
                txtWriter.Write("\r\nSporcu Logger Silme İşlemleri : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :  ");
                txtWriter.WriteLine("  Silme Mesajı: :{0} Adı: {1} Soyadı: {2} Diger: {3} Ligi: {4}", logMessage, textadi, textsoyadi,textdiger,textlig);
                txtWriter.WriteLine("----------------------------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hatalı işlem", "mesaj");
            }
        }
    }
}

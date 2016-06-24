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
    class kaydetmelgSporcu
    {

        private string m_exePath = string.Empty;


        private volatile static kaydetmelgSporcu kaydetlgsporcu;


        private static Object lock_objSporcuKaydet = new Object();


        public static kaydetmelgSporcu kaydetLoggerSporcu()
        {
            lock(lock_objSporcuKaydet)
            {
                if(kaydetlgsporcu==null)
                {
                    kaydetlgsporcu = new kaydetmelgSporcu();
                }

                return kaydetlgsporcu;
            }
        }
        private kaydetmelgSporcu()
        {

        }

        public void LogSporcuKaydet(string logMessage, string textadi, string textsoyadi, string textdiger, string textligi)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
                {
                    LogSporcuKaydet1(logMessage, w, textadi, textsoyadi, textdiger, textligi);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void LogSporcuKaydet1(string logMessage, TextWriter txtWriter, string textadi, string textsoyadi, string textdiger, string textlig)
        {
            try
            {
                txtWriter.Write("\r\nSporcu Logger Kaydet İşlemleri : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :  ");
                txtWriter.WriteLine("  Kayıt Mesajı: :{0} Adı: {1} Soyadı: {2} Diger: {3} Ligi: {4}", logMessage, textadi, textsoyadi, textdiger, textlig);
                txtWriter.WriteLine("----------------------------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hatalı işlem", "mesaj");
            }








        }

        }
    }

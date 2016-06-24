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
    
    class sporcuGuncelleLogger
    {

        private string m_exePath = string.Empty;

        private volatile static sporcuGuncelleLogger spguncelleLogger;

        private static Object obj_Guncelle = new Object();


        private sporcuGuncelleLogger()
        {

        }



        public static sporcuGuncelleLogger guncelleLogger()
        {
            
            lock(obj_Guncelle)
            {
                if(spguncelleLogger==null)
                {
                    spguncelleLogger = new sporcuGuncelleLogger();
                }

                return spguncelleLogger;
            }
        }




        public void LogSporcuGuncelle(string logMessage, string textadi, string textsoyadi, string textdiger, string textligi)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
                {
                    LogSporcuGuncelle1(logMessage, w, textadi, textsoyadi, textdiger, textligi);
                }
            }
            catch (Exception ex)
            {

            }
        }


        public void LogSporcuGuncelle1(string logMessage, TextWriter txtWriter, string textadi, string textsoyadi, string textdiger, string textlig)
        {
            try
            {
                txtWriter.Write("\r\nSporcu Logger Güncelle İşlemleri : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :  ");
                txtWriter.WriteLine("  Güncelleme Mesajı: :{0} Adı: {1} Soyadı: {2} Diger: {3} Ligi: {4}", logMessage, textadi, textsoyadi, textdiger, textlig);
                txtWriter.WriteLine("----------------------------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hatalı işlem", "mesaj");
            }

        }

        }
    }
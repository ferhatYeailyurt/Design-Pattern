﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevDeneme
{
    class stadyumLoggerKaydet
    {
        private string m_exePath = string.Empty;

        private static Object lock_obj = new Object();

        private volatile static stadyumLoggerKaydet stdLoggerKaydet;

        public static stadyumLoggerKaydet kaydetstadyum()
        {
            lock(lock_obj)
            {
                if(stdLoggerKaydet==null)
                {
                    stdLoggerKaydet = new stadyumLoggerKaydet();
                }
                return stdLoggerKaydet;
            }
        }
        private stadyumLoggerKaydet()
        {

        }
        public void LogStadyumKaydet(string logMessage, string textadi, string textsehir, string textligi, string textdiger)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
                {
                    LogStadyumKaydet1(logMessage, w, textadi, textsehir, textligi, textdiger);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void LogStadyumKaydet1(string logMessage, TextWriter txtWriter, string textadi, string textsehir, string textligi, string textdiger)
        {
            try
            {
                txtWriter.Write("\r\nStadyum Logger Kaydet İşlemleri : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :  ");
                txtWriter.WriteLine("  Kayıt Mesajı: :{0} Adı: {1} Şehir: {2} Ligi: {3} Diger: {4}", logMessage, textadi, textsehir, textligi, textdiger);
                txtWriter.WriteLine("----------------------------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hatalı işlem", "mesaj");
            }
        }

    }
}

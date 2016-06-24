using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Drawing.Design;
using System.Configuration;
using System.Drawing;

namespace odevDeneme
{
    class ComponentConfiguration
    {
    
        private static Object lock_objXMLComponent = new Object();

        private volatile static ComponentConfiguration cmpCon;

        private ComponentConfiguration()
        {

        }

        public void textDuzenle(TextBox textadi,TextBox textsoyadi, Button btn)
        {

           var doc = new XmlDocument();
            doc.Load("componentsconfig.xml");

            foreach (XmlNode node12 in doc.SelectNodes("//textbox[@tip]"))
            {
                if (node12.Attributes["tip"].Value == "birinci")
                {
                   
                    ListViewItem childList1 = new ListViewItem();

                    childList1.Text = node12.SelectSingleNode("textcolor").FirstChild.Value;
                    string bgcolor, textcolor1 = childList1.Text.ToString();

                    childList1.Text = node12.SelectSingleNode("bgcolor").FirstChild.Value;
                    bgcolor = childList1.Text.ToString();
                    textadi.BackColor = Color.FromName(textcolor1);
                   textadi.ForeColor = Color.FromName(bgcolor);
                    MessageBox.Show("Renkler Başarı İle Değişti");


                }
                if (node12.Attributes["tip"].Value == "ikinci")
                {
                    ListViewItem childList2 = new ListViewItem();

                    childList2.Text = node12.SelectSingleNode("textcolor").FirstChild.Value;
                    string textcolor1 = childList2.Text.ToString();

                    childList2.Text = node12.SelectSingleNode("bgcolor").FirstChild.Value;
                    string bgcolor = childList2.Text.ToString();
                    textsoyadi.BackColor = Color.FromName(textcolor1);
                    textsoyadi.ForeColor = Color.FromName(bgcolor);



                    MessageBox.Show("Renkler Başarı İle Değişti");
                    
                }
               
            }

            foreach (XmlNode node13 in doc.SelectNodes("//button[@tip]"))
            {
                if (node13.Attributes["tip"].Value == "buton")
                {
                    ListViewItem childList3 = new ListViewItem();
                    childList3.Text = node13.SelectSingleNode("textcolor").FirstChild.Value;
                    string butoncolor1 = childList3.Text.ToString();

                    childList3.Text = node13.SelectSingleNode("bgcolor").FirstChild.Value;
                    string bgcolor = childList3.Text.ToString();
                    btn.BackColor = Color.FromName(butoncolor1);
                    btn.ForeColor = Color.FromName(bgcolor);
                    MessageBox.Show("Renkler Başarı İle Değişti");
                    }
            }


        }

        public static ComponentConfiguration ComponentConXml()
        {
            
            lock(lock_objXMLComponent)
            {
                if(cmpCon==null)
                {
                    cmpCon = new ComponentConfiguration();
                }

                return cmpCon;
            }
        }
    }
}

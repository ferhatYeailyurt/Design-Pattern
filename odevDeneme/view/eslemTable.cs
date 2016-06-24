using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevDeneme
{
    public partial class eslemTable : Form
    {
        public eslemTable()
        {
            InitializeComponent();
        }


        fikstur eslestir = new fikstur();

        EslemeTableDataClassesDataContext eslemedatacon = new EslemeTableDataClassesDataContext();

        sporcuDataClassesDataContext sporcu1 = new sporcuDataClassesDataContext();

        hakemlerdbDataClassesDataContext hakemcon = new hakemlerdbDataClassesDataContext();


        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();


            product.Attach(new CustomerObserver());


            product.ChangeStock();

            
            eslemGridview.DataSource = eslemedatacon.eslemTablos;

        }

        private void eslemTable_Load(object sender, EventArgs e)
        {
  
        }

    }
}



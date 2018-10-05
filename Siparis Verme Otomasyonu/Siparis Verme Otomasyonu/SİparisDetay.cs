using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Siparis_Verme_Otomasyonu
{
    public partial class SİparisDetay : Form
    {
        private Order gelenOrd;

        public SİparisDetay()
        {
            InitializeComponent();

        }

        public SİparisDetay(Order ord)
        {
            InitializeComponent();
            if (ord != null) this.gelenOrd = ord;
        }

        private void SİparisDetay_Load(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (Product item in gelenOrd.Products)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.ProductName;
                li.SubItems.Add(item.Price.ToString());
                li.SubItems.Add(item.Stock.ToString());
                listView1.Items.Add(li);

                total += item.Price;
            }
            lblShipper.Text = gelenOrd.Shipper.ShipperName;
            lblTotal.Text = total.ToString();
        }
    }
}

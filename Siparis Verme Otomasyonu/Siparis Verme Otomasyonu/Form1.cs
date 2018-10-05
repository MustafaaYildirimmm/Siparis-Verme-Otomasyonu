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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Category> CategoryList = new List<Category>();
        List<Product> ProductList = new List<Product>();
        List<Shipper> ShipList = new List<Shipper>();

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Category
           

            Category c1 = new Category();
            c1.CategoryName = "Teknoloji";
            c1.Description = "bilgisyar ve telefon";
            CategoryList.Add(c1);

            Category c2 = new Category();
            c2.CategoryName = "Kozmotik";
            c2.Description = "parfum vew makyaj malzemleri";
            CategoryList.Add(c2);

            Category c3 = new Category();
            c3.CategoryName = "Pets";
            c3.Description = "Kedi Mamaları ve kumu";
            CategoryList.Add(c3);

            foreach  (Category item in CategoryList)
            {
                cmbKategori.Items.Add(item);
            }
            #endregion
            
            #region Product

            

            Product p1 = new Product();
            p1.ProductName = "Bilgisyar";
            p1.Price = 7000;
            p1.Stock = 10;
            p1.categoryName = c1;
            p1.Description = "gereksiz pahali";
            ProductList.Add(p1);

            Product p2 = new Product();
            p2.ProductName = "Telefon";
            p2.Price = 6000;
            p2.Stock = 20;
            p2.categoryName = c1;
            p2.Description = "gereksiz  yere stokda çok var";
            ProductList.Add(p2);

            Product p3 = new Product();
            p3.ProductName = "Köpek mamasi";
            p3.Price=14.99m;
            p3.Stock = 20;
            p3.categoryName = c2;
            p3.Description = "yas mama";
            ProductList.Add(p3);

            Product p4 = new Product();
            p4.ProductName = "Kedi Kumu";
            p4.Price = 24.99m;
            p4.Stock = 10;
            p4.categoryName = c2;
            p4.Description = "nane-mentollü";
            ProductList.Add(p4);

            Product p5 = new Product();
            p5.ProductName = "allik";
            p5.Price = 25.99m;
            p5.Stock = 20;
            p5.categoryName = c3;
            p5.Description = "8 renk cesidi car";
            ProductList.Add(p5);

            Product p6 = new Product();
            p6.ProductName = "Ruj";
            p6.Price = 15;
            p6.Stock = 100;
            p6.categoryName = c3;
            p6.Description = "12 cesit renk secenegi mevcut";
            ProductList.Add(p6);
            #endregion

            #region Shipper

           

            Shipper s1 = new Shipper();
            s1.ShipperName = "ARAS";
            s1.Phone = "0 212 356 98 78";
            s1.Region = "MASLAK";
            s1.City = "İSTANBUL";
            s1.Address = "12 sok . asdsa";
            ShipList.Add(s1);

            Shipper s2 = new Shipper();
            s2.ShipperName = "UPS";
            s2.Phone = "0 312 35 3 65 3 ";
            s2.Region = "Etiler";
            s2.City = "ANKARA";
            s2.Address = "etimek mah.";
            ShipList.Add(s2);

            Shipper s3 = new Shipper();
            s3.ShipperName = "MNG";
            s3.Region = "BUCA";
            s3.City = "İZMİR";
            s3.Phone = "0 232 563 45 32";
            s3.Address = "dokuzcesmlere ";
            ShipList.Add(s3);

            //kargo isimlerini radibuttonlara ekliyoruz..

            foreach (Shipper item in ShipList)
            {
                foreach (var cont in this.Controls)
                {
                    if (cont is RadioButton)
                    {
                        RadioButton rdb = (RadioButton)cont;
                        if (rdb.Text==null||rdb.Text=="")
                        {
                            rdb.Text = item.ShipperName;
                            rdb.Tag = item;
                            break;
                        }
                    }
                }
            }
            #endregion
        }
       

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category secilen = (Category)cmbKategori.SelectedItem;
            listView1.Items.Clear();
            foreach (Product item in ProductList)
            {
                if (secilen==item.categoryName)
                {     
                    ListViewItem li = new ListViewItem();
                    li.Text = item.ProductName;
                    li.SubItems.Add(item.Price.ToString());
                    li.SubItems.Add(item.Stock.ToString());
                    li.Tag = item;
                    listView1.Items.Add(li);
                }
            }
        }

        ListView.SelectedListViewItemCollection seciliElemanlar;
        List<Product> seciliUrunler = new List<Product>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            seciliElemanlar = listView1.SelectedItems;
            foreach (ListViewItem item in seciliElemanlar)
            {
                Product urunler = (Product)item.Tag;
                seciliUrunler.Add(urunler);
                lstSepet.Items.Add(urunler);
            }
        }
        
        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            int check = 0;
            RadioButton rdbbtn=new RadioButton();
            foreach (var item in this.Controls)
            {
                if (item is RadioButton)
                {
                    rdbbtn = (RadioButton)item;
                    if (rdbbtn.Checked==true)
                    {
                        check++;
                        break;
                    }
                }
            }

            if (check==0||seciliElemanlar==null)
            {
                MessageBox.Show("Kargo Firmasi veya urun Seciniz");
            }
            else
            {
                Customer cst = new Customer();
                cst.Adi = "mustafa";
                cst.Soyadi = "yildirim";
                cst.Phone=" 0 542 363 21 32";

                Order ord = new Order();
                ord.Customer = cst;
                ord.OrderDate = DateTime.Now;
                ord.OrderName = new Guid().ToString().Replace("-", "");
                ord.Products = seciliUrunler;
                ord.Shipper = (Shipper)rdbbtn.Tag;
                ord.Customer = cst;

                foreach (Product item in seciliUrunler)
                {
                    item.Stock--;
                    listView1.Items.Clear();
                }

                SİparisDetay frm = new SİparisDetay(ord);
                frm.ShowDialog();

            }

            
        }
    }
}

﻿using Proje_Ogrenci_Akademisyen.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ogrenci_Akademisyen.Formlar
{
    public partial class FrmOgrenciPanel : Form
    {
        public FrmOgrenciPanel()
        {
            InitializeComponent();
        }
        public string numara;
        OgrenciSinavEntities db = new OgrenciSinavEntities();
        int ogrenciID;
        private void FrmOgrenciPanel_Load(object sender, EventArgs e)
        {
            TxtNumara.Text = numara;
            TxtAd.Text=db.TblOgrenci.Where(x=>x.OgrNumara==numara).Select(y=>y.OgrAd).FirstOrDefault();
            TxtSoyad.Text=db.TblOgrenci.Where(x=>x.OgrNumara==numara).Select(y=>y.OgrSoyad).FirstOrDefault();
            TxtMail.Text=db.TblOgrenci.Where(x=>x.OgrNumara==numara).Select(y=>y.OgrMail).FirstOrDefault();
            TxtSifre.Text=db.TblOgrenci.Where(x=>x.OgrNumara==numara).Select(y=>y.OgrSifre).FirstOrDefault();
            TxtBolum.Text=db.TblOgrenci.Where(x=>x.OgrNumara==numara).Select(y=>y.OgrBolum).FirstOrDefault().Value.ToString();

            ogrenciID = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrID).FirstOrDefault();

            var sinavNotlari = (from x in db.TblNotlar
                                select new
                                {
                                    x.TblDersler.DersAd,
                                    x.Sinav1,
                                    x.Sinav2,
                                    x.Sinav3,
                                    x.Quiz1,
                                    x.Quiz2,
                                    x.Ortalama,
                                    x.Ogrenci
                                }).Where(y=>y.Ogrenci==ogrenciID).ToList();
            dataGridView1.DataSource = sinavNotlari;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtYeniSifre.Text == TxtYeniSifre2.Text)
            {
                var deger = db.TblOgrenci.Find(ogrenciID);
                deger.OgrSifre = TxtYeniSifre.Text;
                db.SaveChanges();
                MessageBox.Show("Şifre değiştirme işlemi başarılı bir şekilde gerçekleştirildi.");
            }
            else
            {
                MessageBox.Show("Girilen şifreler birbiri ile uyuşmuyor.");
            }
        }
    }
}

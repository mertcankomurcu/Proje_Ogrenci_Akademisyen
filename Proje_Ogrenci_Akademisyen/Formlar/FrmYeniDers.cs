using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje_Ogrenci_Akademisyen.Entity;

namespace Proje_Ogrenci_Akademisyen.Formlar
{
    public partial class FrmYeniDers : Form
    {
        public FrmYeniDers()
        {
            InitializeComponent();
        }
        OgrenciSinavEntities db = new OgrenciSinavEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblDersler t=new TblDersler();
            t.DersAd = TxtDersAd.Text;
            db.TblDersler.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni ders kaydetme işlemi başarılı bir şekilde gerçekleştirildi.", "Yeni Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

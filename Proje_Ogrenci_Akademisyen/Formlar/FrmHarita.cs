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
    public partial class FrmHarita : Form
    {
        public FrmHarita()
        {
            InitializeComponent();
        }

        private void PnlDersListesi_Click(object sender, EventArgs e)
        {
            FrmDersListesi frm = new FrmDersListesi();
            frm.Show();
        }

        private void PnlOgrenciKayit_Click(object sender, EventArgs e)
        {
            FrmOgrenciKayit frm = new FrmOgrenciKayit();
            frm.Show();
        }

        private void PnlBolumListesi_Click(object sender, EventArgs e)
        {
            FrmBolumListesi frm =new FrmBolumListesi();
            frm.Show();
        }

        private void PnlYeniBolum_Click(object sender, EventArgs e)
        {
            FrmBolumler frm= new FrmBolumler();
            frm.Show();
        }

        private void PnlNotlar_Click(object sender, EventArgs e)
        {
            FrmNotlar frm = new FrmNotlar();
            frm.Show();
        }

        private void PnlOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenci frm=new FrmOgrenci();
            frm.Show();
        }

        private void PnlOgrenciKyt_Click(object sender, EventArgs e)
        {
            FrmOgrenciKayit frm = new FrmOgrenciKayit();
            frm.Show();
        }

        private void PnlYardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kömür Digital","Yardım Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void PnlYeniDers_Click(object sender, EventArgs e)
        {
            FrmYeniDers frm = new FrmYeniDers();
            frm.Show();
        }

        private void PanelCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

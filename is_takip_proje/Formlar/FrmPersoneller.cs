using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class FrmPersoneller : Form
    {
        DbisTakipEntities db = new DbisTakipEntities();
        public FrmPersoneller()
        {
            InitializeComponent();
        }

        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            Personeller();
            DepartmanListele();
        }
        void DepartmanListele()
        {
            var departmanlar = (from x in db.tbl_departmanlar select new { x.ID, x.Ad }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Ad";
            lookUpEdit1.Properties.DataSource = departmanlar;
        }
        void Personeller()
        {
            var degerler = from x in db.tbl_personel
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.Mail,
                               x.Departman,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tbl_personel t = new tbl_personel();
            t.Ad = txtAd.Text;
            t.Soyad = txtSoyad.Text;
            t.Mail = txtMail.Text;
            t.Gorsel = txtGorsel.Text;
            t.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.tbl_personel.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Peronel başarılı bir şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Personeller();
        }
    }
}

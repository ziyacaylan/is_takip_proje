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
    public partial class FrmDepartmanlar : Form
    {
        DbisTakipEntities db = new DbisTakipEntities();
        public FrmDepartmanlar()
        {
            InitializeComponent();
        }

        // crud ---> create read update delete
        void Listele()
        {            
            var degerler = (from x in db.tbl_departmanlar
                            select new
                            {
                                x.ID,
                                x.Ad
                            }).ToList();
            gridControl1.DataSource = degerler;
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            tbl_departmanlar t = new tbl_departmanlar();
            t.Ad = txtAd.Text;
            db.tbl_departmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var deger = db.tbl_departmanlar.Find(x);
            if (XtraMessageBox.Show("Silmek istediğinize emin misiniz_?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)!=DialogResult.No)
            {
                db.tbl_departmanlar.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Departman silme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Listele();
                txtID.Text = "";
                txtAd.Text = "";
            }
            else
            {
                XtraMessageBox.Show("Departman silme işlemi gerçekleşmedi...!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

                txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void FrmDepartmanlar_Load(object sender, EventArgs e)
        {
            Listele();
            txtID.Text = "";
            txtAd.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtID.Text);
            var deger = db.tbl_departmanlar.Find(x);
            deger.Ad = txtAd.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman güncelleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtID.Text = "";
            txtAd.Text = "";
            Listele();
        }

    }
}

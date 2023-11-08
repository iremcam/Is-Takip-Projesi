using DevExpress.XtraBars;
using DevExpress.XtraEditors.ColorPick.Picker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {

        }

        //departman listele butonu
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.XtraForm1 frm = new Formlar.XtraForm1();
            frm.MdiParent = this;
            frm.Show();
        }


        //personel listele butonu
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.XtraForm2 frm = new Formlar.XtraForm2();
            frm.MdiParent = this;
            frm.Show();
        }

     


       
        //Firma işlemleri
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.Firma frm = new Formlar.Firma();
            frm.MdiParent = this;
            frm.Show();
        }


        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.XtraForm6 frm = new Formlar.XtraForm6();
            frm.MdiParent = this;
            frm.Show();
        }

        //Hesap MAKİNESİ
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.XtraForm7 frm = new Formlar.XtraForm7();
            frm.MdiParent = this;
            frm.Show();
        }

        //GÖREVLER
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.XtraForm8 frm = new Formlar.XtraForm8();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
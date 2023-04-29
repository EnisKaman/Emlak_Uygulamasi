using FinalApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalApp
{
    public partial class EvKayitFormu : Form
    {
        Form1 frm;
        public EvKayitFormu(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void EvKayitFormu_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = $"Haşgeldin, {frm.kullaniciadi}";
            if (frm.kullaniciadi == "admin")
            {
                btnKaydet.Enabled = true;
            }
            else {
                btnKaydet.Enabled = false;
                txtAlan.Enabled=false;
                txtIlanNo.Enabled = false;
                txtKatNo.Enabled = false;
                txtOdaSayisi.Enabled = false;
                txtSemt.Enabled = false;
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            EvBul evBul = new EvBul(this);
            evBul.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var ctx = new EvContext())
            {
                var ev = new Ev { IlanNo= int.Parse(txtIlanNo.Text.Trim()), Alan=int.Parse(txtAlan.Text.Trim()), KatNo=int.Parse(txtKatNo.Text.Trim()), OdaSayisi= int.Parse(txtOdaSayisi.Text.Trim()), Semt= txtSemt.Text.Trim() };
                ctx.Evler.Add(ev);
                int sonuc = ctx.SaveChanges();
                if (sonuc>0)
                {
                    MessageBox.Show("Kayıt Başarılı");
                    Clean();
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız");
                }
            }
        }
        void Clean()
        {
            foreach(Control itrm in this.Controls)
            {
                if (itrm is TextBox)
                {
                    itrm.Text = String.Empty;
                }
            }
        }
    }
}

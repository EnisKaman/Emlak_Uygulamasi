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
    public partial class EvBul : Form
    {
        EvKayitFormu frm;
        public EvBul(EvKayitFormu frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            
            using (var ctx = new EvContext())
            {
                var sonuc = from ev in ctx.Evler
                            where ev.IlanNo == int.Parse(txtIlanNo.Text.Trim())
                            select ev;
                var bulunan = sonuc.FirstOrDefault();
                if (bulunan != null)
                {
                    BulunanEvBilgileri beb = new BulunanEvBilgileri(this);
                    beb.EvBilgileri.Text= $"İlan No:{bulunan.IlanNo.ToString()}\nAlan: {bulunan.Alan.ToString()}\n{bulunan.KatNo.ToString()}\n{bulunan.OdaSayisi.ToString()}\n{bulunan.Semt.ToString()}";
                    
                    frm.txtIlanNo.Text= bulunan.IlanNo.ToString();
                    frm.txtAlan.Text=bulunan.Alan.ToString();
                    frm.txtKatNo.Text=bulunan.KatNo.ToString();
                    frm.txtOdaSayisi.Text=bulunan.OdaSayisi.ToString();
                    frm.txtSemt.Text=bulunan.Semt.ToString();
                    beb.Show();
                    this.Close();
                }
            }
        }
    }
}

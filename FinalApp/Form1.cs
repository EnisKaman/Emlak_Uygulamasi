using FinalApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalApp
{
    public partial class Form1 : Form
    {
        public string kullaniciadi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            using (var ctx = new EvContext())
            {
                var sonuc = from u in ctx.Users
                            where u.Username==txtKullaniciAdi.Text.Trim() && u.Password==int.Parse(txtSifre.Text.Trim())
                            select u;
                var user = sonuc.FirstOrDefault();
                if (user != null)
                {
                    this.kullaniciadi= user.Username;
                    
                    EvKayitFormu ekf = new EvKayitFormu(this);                       
                    
                    ekf.ShowDialog();
                    this.Close();
                }
            }
            
        }
    }
}

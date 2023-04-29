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
    public partial class BulunanEvBilgileri : Form
    {
        EvBul frm;
        public BulunanEvBilgileri(EvBul frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

    }
}

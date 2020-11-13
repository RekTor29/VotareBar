using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotareBar
{
    public partial class frmMain : Form
    {
        int minimoprg = 0;
        int massimoprg = 250;
        public frmMain()
        {
            InitializeComponent();
            //Testi dei RadioButton RDB
            rdb1.Text = "Scarso";
            rdb2.Text = "Discreto";
            rdb3.Text = "Ottimo";

            //Testo nel bottone BTN1
            btn1.Text = "Vota";

            //Testo delle label LBL
            lbl1.Text = "Scarso";
            lbl2.Text = "Discreto";
            lbl3.Text = "Ottimo";

            //Setup delle PRGBAR
            prg1.Maximum = 100;
            prg2.Maximum = 100;
            prg3.Maximum = 100;

            //SetState usato per esigenza di Design
            prg1.SetState(2);
            prg2.SetState(3);
            prg3.SetState(1);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
           if (rdb1.Checked == true)
           {
                prg1.Increment(1);
           }
           if (rdb2.Checked == true)
           {
                prg2.Increment(1);
           }
           if (rdb3.Checked == true)
           {
                prg3.Increment(1);
           }
        }
    }
}

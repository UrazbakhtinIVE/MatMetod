using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatMetod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double q = double.Parse(qTB.Text);
            double l = double.Parse(lTB.Text);
            double d = double.Parse(dTb.Text);
            double t = double.Parse(TTB.Text);
            double r = double.Parse(RTb.Text);
            double k01 = double.Parse(K01TB.Text);
            double EA2 = double.Parse(Ea2TB.Text);


            HTC hTC = new HTC(l, d, q,t, r, k01, EA2);

     
            
            uTB.Text = hTC.modelHTS().ToString();
            timeVarTb.Text = hTC.timeVar().ToString();
            K1TB.Text = hTC.k1().ToString();
           
        }

       

        

        
    }
}

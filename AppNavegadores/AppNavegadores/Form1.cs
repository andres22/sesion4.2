using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNavegadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkMozilla_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = " ";
            if (chkChrome.Checked == true) ;
            {
                texto = texto + "Chrome" + " ";
            }
            if (chkInternetExplorer.Checked == true);
            {
                texto = texto + "Internet Explorer" + " " ;
            }
            if (chkMozilla.Checked == true) ;
            {
                texto = texto + "Mozilla" + " " ;
               
            }
            Text = texto;
        }

        private void lblSeleccionado_Click(object sender, EventArgs e)
        {

        }
    }
}

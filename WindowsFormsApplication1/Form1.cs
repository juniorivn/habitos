using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre about = new Sobre();
            //Set the Parent Form of the Child window.
            about.MdiParent = this;
            // Display the new form.
            about.Show();
        }

        private void dicasSobreMudançasDeHábitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu newMDIChild = new menu();
            //Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
    }
}

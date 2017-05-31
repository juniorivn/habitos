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
    public partial class perguntas : Form
    {
        public perguntas()
        {
            InitializeComponent();
            
        }

        private void perguntas_Load(object sender, EventArgs e)
        {

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                lbl1.Visible = true;               
                lbl1.Text = "Preencha o seu nome acima!";
            }
            else
            {
                lbl1.Visible = true;
            }
            //lbl1.Visible = true;
        }
    }
}

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
            if (txtNome.Text == ""){
                MessageBox.Show("Insira seu nome!");
            }
            else{
                lbl1.Visible = true;
                lbl1.Text = "Você é fumante?";
                optFumarSim.Visible = true;
                optFumarNao.Visible = true;
                grupoPergunta1.Visible = true;
            }
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = "http://www.youtube.com/v/JaW1aDog8nQ&autoplay=1";
        }
    }
}

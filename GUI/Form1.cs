using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPrincipal : Form
    {
        private byte i = 0; // Controla se o ponto flutuante já foi inserido no número
        private string marcadorDecimal = ".";

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtCampoX.Text = TxtCampoX.Text + "3";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtCampoX.Text = TxtCampoX.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtCampoX.Text = TxtCampoX.Text + "2";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtCampoX.Text = TxtCampoX.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtCampoX.Text = TxtCampoX.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtCampoX.Text = TxtCampoX.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtCampoX.Text = TxtCampoX.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtCampoX.Text = TxtCampoX.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtCampoX.Text = TxtCampoX.Text + "9";
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnDevimal_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                TxtCampoX.Text += marcadorDecimal;
                i = 1;
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtCampoX.Text += "0";
        }

        private void MnuVirgulaDecimal_Click(object sender, EventArgs e)
        {
            BtnDecimal.Text = ",";
            marcadorDecimal = ",";
        }

        private void BtnLimparCampoX_Click(object sender, EventArgs e)
        {
            TxtCampoX.Text = "";
            i = 0;
        }

        private void BtnLimparCampoY_Click(object sender, EventArgs e)
        {
            TxtCampoY.Text = "";

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            TxtCampoY.Text = TxtCampoX.Text;
            TxtCampoX.Text = "";
            i = 0;
        }

        private void MnuPontoDecimal_Click(object sender, EventArgs e)
        {
            marcadorDecimal = ".";
            BtnDecimal.Text = ".";
        }

        /// <summary>
        /// Função que apaga o último caractere da string no TxtCampoX.
        /// Antes de apagá-lo, testa se esse caractere é uma vírgula ou um ponto decimal.
        /// Nesse caso, o valor da variável i é zerado.
        /// Isso permite que novo símbolo decimal possa ser digitado.
        /// </summary>
        private void BtnApagarCaractereDireita_Click(object sender, EventArgs e)
        {
            // Testa se há pelo menos um caractere para ser eliminado.
            if (TxtCampoX.Text.Length > 0)
            {
                string str = TxtCampoX.Text;
                int tam = str.Length - 1;
                string caractere = str.Substring(tam, 1); // Pega o último caractere digitado.

                if ( caractere == "," || caractere == ".") 
                {
                    i = 0;
                }
            }
            TxtCampoX.Text = TxtCampoX.Text.Remove(TxtCampoX.Text.Length - 1);
        }
    }
}



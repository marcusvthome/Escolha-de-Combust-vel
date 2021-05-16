using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escolha_de_Combustível
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            double Consumo = 0.7;

            bool erros = false;

            if (txtValorEtanol.Text.Trim() == "")
            {
                errorProvider1.SetError(txtValorEtanol, "Campo obrigatório");
                erros = true;
            }

            if (txtValorGasolina.Text.Trim() == "")
            {
                errorProvider1.SetError(txtValorGasolina, "Campo obrigatório");
                erros = true;
            }

            if (erros == false)
            {
                if (txtKmEtanol.Text.Trim() != "" && txtKmGasolina.Text.Trim() != "")
                {
                    double ConsumoEtanol = double.Parse(txtValorEtanol.Text);
                    double ConsumoGasolina = double.Parse(txtValorGasolina.Text);
                    Consumo = CalculoCombustivel.CalcularConsumo(ConsumoEtanol, ConsumoGasolina);
                }

                double ValorEtanol = double.Parse(txtValorEtanol.Text);
                double ValorGasolina = double.Parse(txtValorGasolina.Text);

                MessageBox.Show(CalculoCombustivel.CalcularCombustivel(ValorEtanol, ValorGasolina, Consumo)); ;

                txtValorEtanol.Text = "";
                txtValorGasolina.Text = "";
                txtKmEtanol.Text = "";
                txtKmGasolina.Text = "";

                txtValorEtanol.Focus();
            }
        }

            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (MessageBox.Show("Deseja fechar o formulário?", "", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    e.Cancel = true;
            }
    }
}

